import { Component, OnInit, Input } from '@angular/core';
import { NotesService } from 'src/app/Service/notes.service';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { EditComponent } from '../edit/edit.component';
import { Router } from '@angular/router';
import { CollaboratorComponent } from '../collaborator/collaborator.component';
import { DataService } from 'src/app/Service/data.service';
import { LabelsService } from 'src/app/Service/labels.service';
import { CdkDragDrop, moveItemInArray } from '@angular/cdk/drag-drop';

export interface DialogData {
  title: string;
  description: string;
}
@Component({
  selector: 'app-display-note',
  templateUrl: './display-note.component.html',
  styleUrls: ['./display-note.component.scss']
})
export class DisplayNoteComponent implements OnInit {
  listview = false;
  allLabels = [];
  labels = [];
  notes = [];
  adddate: string;
  image: File = null;
  searchkey = 1;
  temp;
  display;
  cardType: string;
  colorPalette = [
    { name: 'default', colorCode: '#FDFEFE' },
    { name: 'Red', colorCode: '#ef9a9a' },
    { name: 'Cyan', colorCode: '#80deea' },
    { name: 'Blue', colorCode: '#2196f3' },
    { name: 'Indigo', colorCode: '#9fa8da' },
    { name: 'LightBlue', colorCode: '#90caf9' },
    { name: 'Purple', colorCode: '#b39ddb' },
    { name: 'Yellow', colorCode: '#fff59d' },
    { name: 'Lime', colorCode: '#e6ee9c' },
    { name: 'Pink', colorCode: ' #f48fb1' },
    { name: 'gray', colorCode: '#eeeeee' },
    { name: 'Brown', colorCode: '#bcaaa4' },
  ];
  constructor(private notesService: NotesService,
    public dialog: MatDialog,
    private router: Router,
    private data: DataService,
    private labelservice: LabelsService) { }

  userData = JSON.parse(localStorage.getItem('userData'));
  ngOnInit() {
    this.data.dash$.subscribe((result: boolean) => {
      this.listview = result;
    });
    this.notesService.GetNotesLabels().subscribe((labelresult: any) => {
      this.allLabels = labelresult;
    });
    this.notesService.GetNotes(this.userData.email).subscribe((data: any) => {
      this.notes = data.sort((a, b) => b.isPin - a.isPin);
    });
    this.labelservice.GetLabel(this.userData.email).subscribe((labellist: any) => {
      this.labels = labellist;
    });
    this.data.dashh$.subscribe((result: string) => {
      if (this.searchkey) {
        this.temp = this.notes;
        this.searchkey = 0;
      }
      if (!(/^\s*$/.test(result))) {
        const re = new RegExp(result, 'gi');
        setTimeout(() => {
          this.notes = this.temp.filter(ele => (ele.title.match(re) || ele.description.match(re)));
        }, 200);
      }
    });
    this.property();
  }
  stopPropagation(event) {
    event.stopPropagation();
  }
  private newMethod() {
    return this;
  }

  reminder(id) {
    this.notesService.AddReminder(this.adddate, id).subscribe((data: any) => {
    });
  }
  archive(id) {
    this.notesService.AddArchive(id).subscribe((data: any) => {
    });
  }
  delete(id) {

    this.notesService.AddTrash(id).subscribe((data: any) => {
    });
  }
  openDialog(note): void {
    const dialogRef = this.dialog.open(EditComponent, {
      panelClass: 'custom-modalbox',
      data: { notesData: note }
    });
  }
  openCollaborator(note): void {
    const collaboratordailog = this.dialog.open(CollaboratorComponent, {
      panelClass: 'custom-modalbox', height: '300px',
      data: { notesData: note }
    });
  }
  updatecolor(color, id) {
    this.notesService.AddColor(id, color).subscribe(() => {
    });
  }
  pin(index, id) {
    this.notesService.addPin(id).subscribe((status: any) => {
      this.notes[index].isPin = 1;
      this.notes = this.notes.sort((a, b) => b.isPin - a.isPin);
    }, (error: any) => {
      alert(error);
    });
  }

  unpin(index, id) {
    this.notesService.unPin(id).subscribe((status: any) => {
      this.notes[index].isPin = 0;
      this.notes = this.notes.sort((a, b) => b.isPin - a.isPin);
    });
  }
  notesLabel(id, noteid, label) {
    this.notesService.AddNotesLabel(id, noteid, label).subscribe((result: any) => { });
  }
  removeLabel(id) {
    this.notesService.RemoveNotesLabel(id).subscribe((result: any) => { });
  }
  onFileUpload(event, id) {
    this.image = <File>event.target.files[0];
    this.addImages(id);
  }
  addImages(id) {
    const formData = new FormData();
    formData.append('image', this.image);
    this.notesService.AddImages(id, formData).subscribe((status: any) => {
    });
  }
  drop(event: CdkDragDrop<string[]>) {
    moveItemInArray(this.notes, event.previousIndex, event.currentIndex);
    this.notesService.AddIndex(this.userData.email, event.currentIndex, event.previousIndex).subscribe((status: any) => {
    });
  }
  property() {
    if (this.userData.cardType === 'Advance') {
      this.display = true;
    } else {
      this.display = false;
    }
  }
}
