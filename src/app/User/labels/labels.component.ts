import { Component, OnInit } from '@angular/core';
import { LabelsService } from 'src/app/Service/labels.service';

@Component({
  selector: 'app-labels',
  templateUrl: './labels.component.html',
  styleUrls: ['./labels.component.scss']
})
export class LabelsComponent implements OnInit {
label: string;
labels = [];
userData = JSON.parse(localStorage.getItem('userData'));
  constructor(private labelservice: LabelsService) { }

  ngOnInit() {
    this.labelservice.GetLabel(this.userData.email).subscribe((data: any) => {
      this.labels = data;
    });
  }
  addLabel() {
    this.labelservice.createLabel(this.label, this.userData.email).subscribe((data: any) => { });
  }
    updateLabel(id, value) {
    console.log(id, value);
    this.labelservice.editLabel(id, value).subscribe((data: any) => { });
  }
  deleteLabels(id) {
    this.labelservice.deleteLabel(id).subscribe((data: any) => { });
  }
}
