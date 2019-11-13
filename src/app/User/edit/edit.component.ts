import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { NotesService } from 'src/app/Service/notes.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.scss']
})
export class EditComponent implements OnInit {
  note;
  constructor(private dialogRef: MatDialogRef<EditComponent>,
    @Inject(MAT_DIALOG_DATA) private data,
    private noteService: NotesService
  ) {
    this.note = this.data.notesData;
  }

  ngOnInit() {
  }
  update(title, description) {
    this.noteService.UpdateNotes(title, description, this.note.id).subscribe((data: any) => { });
  }
}
