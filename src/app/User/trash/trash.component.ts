import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/Service/notes.service';

@Component({
  selector: 'app-trash',
  templateUrl: './trash.component.html',
  styleUrls: ['./trash.component.scss']
})
export class TrashComponent implements OnInit {
  notes = [];
  userData = JSON.parse(localStorage.getItem('userData'));
  constructor(private notesService: NotesService) { }

  ngOnInit() {
    this.notesService.GetTrash(this.userData.email).subscribe((data: any) => {
      this.notes = data;
  });
}

  restoreAll() {
    this.notesService.RestoreAll(this.userData.email).subscribe((data: any) => {
    });
  }
  deleteAll() {
    this.notesService.DeleteAll(this.userData.email).subscribe((data: any) => {
    });
  }
  Remove(id) {
    this.notesService.Delete(id).subscribe((data: any) => {
    });
  }
  Restore(id) {
    this.notesService.Restore(id).subscribe((data: any) => {
    });
  }
}
