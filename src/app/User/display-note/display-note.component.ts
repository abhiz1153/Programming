import { Component, OnInit, Input } from '@angular/core';
import { NotesService} from 'src/app/Service/notes.service';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { EditComponent } from '../edit/edit.component';
import { Router } from '@angular/router';

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
constructor(private notesService: NotesService, public dialog: MatDialog, private router: Router) { }
  userData = JSON.parse(localStorage.getItem('userData'));
  ngOnInit() {
    this.notesService.GetNotes(this.userData.email).subscribe((data: any) => {
      this.notes = data;
      console.log(this.notes);
      });
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
updatecolor(color, id) {
  console.log('Color', color);
  console.log('ID', id);
  this.notesService.AddColor(id, color).subscribe((data: any) => {
  });
}

}
