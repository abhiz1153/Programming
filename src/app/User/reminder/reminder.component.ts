import { Component, OnInit } from '@angular/core';
import { NotesService} from 'src/app/Service/notes.service';
@Component({
  selector: 'app-reminder',
  templateUrl: './reminder.component.html',
  styleUrls: ['./reminder.component.scss']
})
export class ReminderComponent implements OnInit {
  notes = [];
  userData = JSON.parse(localStorage.getItem('userData'));
  constructor(private notesService: NotesService) { }

  ngOnInit() {
    this.notesService.GetReminder(this.userData.email).subscribe((data: any) => {
      this.notes = data;
  });
  }
}
