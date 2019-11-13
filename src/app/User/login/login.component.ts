import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl, NgForm } from '@angular/forms';
import { UserService } from 'src/app/Service/user.service';
import { AuthService, SocialUser, FacebookLoginProvider, GoogleLoginProvider } from 'angular-6-social-login';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  login: FormGroup;
  cardss = false;
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
    socialPlatformProvider = FacebookLoginProvider.PROVIDER_ID;
    this.socialAuthService.signIn(socialPlatformProvider).then((userData) => {
      this.userService.facebook(userData.email).subscribe((data: any) => {
        console.log(data.result);
        localStorage.setItem('userData', JSON.stringify(data));
        this.router.navigate(['/dashboard']);
      });
    });
  }
  googlelogin() {
    let socialPlatformProvider;
    socialPlatformProvider = GoogleLoginProvider.PROVIDER_ID;
    this.socialAuthService.signIn(socialPlatformProvider).then((userData) => {
      this.userService.google(userData.email).subscribe((data: any) => {
        localStorage.setItem('userData', JSON.stringify(data));
        this.router.navigate(['/dashboard']);
      });
    });
  }
  onSubmit() {
    this.userService.loginUser(this.login.value).subscribe((data: any) => {
      localStorage.setItem('userData', JSON.stringify(data));
      this.router.navigate(['/dashboard']);
    });
  }
  adminLogin() {
    this.userService.adminLogin(this.login.value).subscribe((data: any) => {
      if (data.result === 'LOGIN SUCCESSFUL') {
        this.router.navigate(['/AdminPage']);
      }
    });
  }
  admin() {
    this.cardss = false;
  }
  userLogin() {
    this.cardss = true;
  }
}
