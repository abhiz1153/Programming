import { Component, OnInit, Inject } from '@angular/core';
import { CollaboratorService } from 'src/app/Service/collaborator.service';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material';

@Component({
  selector: 'app-collaborator',
  templateUrl: './collaborator.component.html',
  styleUrls: ['./collaborator.component.scss']
})
export class CollaboratorComponent implements OnInit {
  note;
  addemail: string;
  userData = JSON.parse(localStorage.getItem('userData'));
  constructor( private collaboratordailog: MatDialogRef<CollaboratorComponent>,
        @Inject(MAT_DIALOG_DATA) private data, private collaborator: CollaboratorService) {
      this.note = this.data.notesData;
     }

  ngOnInit() {
  }
  sendData() {
   this.collaborator.add(this.userData.email, this.note.id, this.addemail).subscribe((data: any) => {
    console.log(data.result);
  });
  }
}
