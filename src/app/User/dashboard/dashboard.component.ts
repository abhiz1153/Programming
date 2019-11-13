import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { UserService } from 'src/app/Service/user.service';
import { Router } from '@angular/router';
import { DataService } from 'src/app/Service/data.service';
import { MatDialog } from '@angular/material';
import { LabelsComponent } from '../labels/labels.component';
import { LabelsService } from 'src/app/Service/labels.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']

})
export class DashboardComponent implements OnInit {
  list = true;
  labels = [];
  profile = true;
  popup1 = false;
  popup2 = true;
  profilepic: File = null;
  userData = JSON.parse(localStorage.getItem('userData'));
  tempimage = this.userData.profilePicture;
  constructor(private userService: UserService,
    private router: Router, private data: DataService,
    public dialog: MatDialog, private label: LabelsService) { }
  ngOnInit() {
    this.label.GetLabel(this.userData.email).subscribe((data: any) => {
      this.labels = data;
      console.log('labels', this.labels);
    });

  }
  onclick() {
    this.profile = false;
  }
  onFileUpload(event) {
    this.profilepic = <File>event.target.files[0];
    this.profiles();
    console.log(' pic', event.target.files[0]);
  }
  profiles() {
    const formData = new FormData();
    formData.append('profilePicture', this.profilepic);
    this.userService.getProfile(this.userData.email, formData).subscribe((status: any) => {
      this.tempimage = status.result;
      this.userData.profilePicture = this.tempimage;
      localStorage.setItem('userData', JSON.stringify(this.userData));
      console.log(' result', status);
    });
  }
  signout() {
    this.userService.logout(this.userData.email).subscribe((status: any) => {
      console.log(status);
    });
    localStorage.removeItem('userData');
    this.router.navigate(['/login']);

  }
  listview() {
    this.popup1 = true;
    this.popup2 = false;
    return this.data.viewlist(this.list);
  }
  gridview() {
    this.popup1 = false;
    this.popup2 = true;
    return this.data.viewlist(false);
  }
  openEdit(): void {
    const collaboratordailog = this.dialog.open(LabelsComponent, {
      panelClass: 'custom-modalbox', height: '300px',
    });
  }
  search(key) {
    return this.data.searchData(key);
  }
}
