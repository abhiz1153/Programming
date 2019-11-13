import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/Service/notes.service';

@Component({
  selector: 'app-archive',
  templateUrl: './archive.component.html',
  styleUrls: ['./archive.component.scss']
})
export class ArchiveComponent implements OnInit {
  notes = [];
  userData = JSON.parse(localStorage.getItem('userData'));
  constructor(private notesService: NotesService) { }
  ngOnInit() {
    this.notesService.GetArchive(this.userData.email).subscribe((data: any) => {
      this.notes = data;
    });
  }
  unarchive(id) {
    this.notesService.RemoveArchive(id).subscribe((data: any) => {
    });
  }
}
