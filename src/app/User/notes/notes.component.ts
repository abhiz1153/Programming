import { Component, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { NotesService } from 'src/app/Service/notes.service';
import { FormGroup } from '@angular/forms';


@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.scss']
})
export class NotesComponent implements OnInit {
  notesForm: FormGroup;
  popup1 = false;
  popup2 = true;
  title: string;
  description: string;
  userData = JSON.parse(localStorage.getItem('userData'));
  constructor(public dialog: MatDialog,
    private noteService: NotesService) { }

  ngOnInit() {
  }
  onclick() {
    this.popup1 = true;
    this.popup2 = false;
  }
  back() {
    this.popup1 = false;
    this.popup2 = true;
    this.noteService.AddNotes(this.title, this.description, this.userData.email).subscribe((data: any) => { });
  }
}
