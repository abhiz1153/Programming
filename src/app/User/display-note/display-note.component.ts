import { Component, OnInit } from '@angular/core';
import { NotesService} from 'src/app/Service/notes.service';
@Component({
  selector: 'app-display-note',
  templateUrl: './display-note.component.html',
  styleUrls: ['./display-note.component.scss']
})
export class DisplayNoteComponent implements OnInit {
  notes = [];
  adddate;
  userData = JSON.parse(localStorage.getItem('userData'));
  constructor(private notesService: NotesService) { }


  ngOnInit() {
     this.notesService.GetNotes(this.userData.email).subscribe((data: any) => {
    this.notes = data;
    console.log('Notes' , data);
    console.log('ALL NOTES', this.notes);
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
}
