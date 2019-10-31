import { Component, OnInit, Input } from '@angular/core';
import { NotesService} from 'src/app/Service/notes.service';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { EditComponent } from '../edit/edit.component';
import { Router } from '@angular/router';
import { CollaboratorComponent } from '../collaborator/collaborator.component';
import { DataService } from 'src/app/Service/data.service';
import { LabelsService } from 'src/app/Service/labels.service';

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
      console.log('list', result);
      this.listview = result;
    });
    this.notesService.GetNotesLabels().subscribe((labelresult: any) => {
      console.log('list', labelresult);
      this.allLabels = labelresult;
    });
    this.notesService.GetNotes(this.userData.email).subscribe((data: any) => {
      this.notes = data.sort((a, b) => b.isPin - a.isPin);
      console.log(this.notes);
      });
      this.labelservice.GetLabel(this.userData.email).subscribe((labellist: any) => {
        this.labels = labellist;
      });
  }
  stopPropagation(event) {
    event.stopPropagation();
  }
  private newMethod() {
    return this;
  }

  reminder(id) {
    console.log('ID' , id);
    console.log('DATE' , this.adddate);
  this.notesService.AddReminder(this.adddate, id).subscribe((data: any) => {
   });
  }
  archive(id) {
    console.log('ID' , id);
    this.notesService.AddArchive(id).subscribe((data: any) => {
    });
  }
  delete(id) {
    console.log('ID' , id);
    this.notesService.AddTrash(id).subscribe((data: any) => {
    });
  }
  openDialog(note): void {
    const dialogRef = this.dialog.open(EditComponent, {
      panelClass: 'custom-modalbox',
      data: {notesData: note}
    });
  }
    openCollaborator(note):  void {
      const collaboratordailog = this.dialog.open(CollaboratorComponent, {
        panelClass: 'custom-modalbox',  height: '300px',
        data: {notesData: note}
      });
    }
updatecolor(color, id) {
  console.log('Color', color);
  console.log('ID', id);
  this.notesService.AddColor(id, color).subscribe(() => {
  });
}
pin(index, id) {
  this.notesService.addPin(id).subscribe((status: any) => {
    this.notes[index].isPin = 1;
    this.notes = this.notes.sort((a, b) => b.isPin - a.isPin);
    console.log(status);
  }, (error: any) => {
   alert(error);
  });
}

unpin(index, id) {
  this.notesService.unPin(id).subscribe((status: any) => {
    this.notes[index].isPin = 0;
    this.notes = this.notes.sort((a, b) => b.isPin - a.isPin);
    console.log(status);
  });
}}
