import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl, NgForm } from '@angular/forms';
import { UserService } from 'src/app/Service/user.service';
import { AuthService, SocialUser, FacebookLoginProvider, GoogleLoginProvider} from 'angular-6-social-login';
import {MatSnackBar} from '@angular/material/snack-bar';
import {Router} from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
login: FormGroup;
user: any = SocialUser;
  constructor(
    public userService: UserService,
    public socialAuthService: AuthService,
    private snackBar: MatSnackBar,
    private router: Router
    ) { }

  ngOnInit() {
    this.login = new FormGroup({
      email: new FormControl('', [Validators.required]),
      password: new FormControl('', [Validators.required])
    });
  }
   facebooklogin() {
     let socialPlatformProvider;
     console.log('Facebook');
   socialPlatformProvider = FacebookLoginProvider.PROVIDER_ID;
    this.socialAuthService.signIn(socialPlatformProvider).then((userData) =>{
     console.log('userdata', userData);
     this.userService. facebook(userData.email).subscribe((data: any) => {
        this.router.navigate(['/dashboard']);
    });
 });
 }
 googlelogin() {
   let socialPlatformProvider;
   console.log('Google');
   socialPlatformProvider = GoogleLoginProvider.PROVIDER_ID;
   this.socialAuthService.signIn(socialPlatformProvider).then((userData) => {
     console.log('user data', userData);
     console.log('user email', userData.email);
     this.userService. google(userData.email).subscribe((data: any) => {
        this.router.navigate(['/dashboard']);
    });
 });
}
 onSubmit(form: NgForm) {

    console.log('under submit', this.login.value);
     this.userService.loginUser(this.login.value).subscribe((data: any) => {
      this.router.navigate(['/dashboard']);
      }
     );
  }
}
