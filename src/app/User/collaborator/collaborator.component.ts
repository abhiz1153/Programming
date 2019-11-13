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
  items = [];
  addemail: string;
  userData = JSON.parse(localStorage.getItem('userData'));
  constructor(private collaboratordailog: MatDialogRef<CollaboratorComponent>,
    @Inject(MAT_DIALOG_DATA) private data, private collaborator: CollaboratorService) {
    this.note = this.data.notesData;
  }

  ngOnInit() {
    this.getList();
  }
  sendData() {
    this.collaborator.add(this.userData.email, this.note.id, this.addemail).subscribe((data: any) => {
    });
  }
  getList() {
    this.collaborator.getCollaborators(this.note.id).subscribe((status: any) => {
      this.items = status;
    });
  }
  deleteCollaborator(id) {
    this.collaborator.removeCollaborator(id).subscribe((status: any) => {
      this.collaboratordailog.close();
    });
  }
  closeCollaborator() {
    this.collaboratordailog.close();
  }
}
