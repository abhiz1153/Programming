import { Component, OnInit, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']

})
export class DashboardComponent implements OnInit {
  profile = true;
   constructor() { }
  ngOnInit() {
  }
  onclick() {
       this.profile = false;
 }
//  back() {
//    this.profile1 = false;
//     this.profile2 = true;  
//  }
}
