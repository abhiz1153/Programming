import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { UserService } from 'src/app/Service/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']

})
export class DashboardComponent implements OnInit {
  profile = true;
  profilepic: File =  null;
  userData = JSON.parse(localStorage.getItem('userData'));
  tempimage = this.userData.profilePicture;
    constructor(private userService: UserService, private router: Router) { }

   ngOnInit() {
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
  localStorage.removeItem('userData');
  this.router.navigate(['/login']);
}
}
