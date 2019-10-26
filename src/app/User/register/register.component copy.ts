import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl, NgForm } from '@angular/forms';
import { UserService } from 'src/app/Service/user.service';
import {MatSnackBar} from '@angular/material/snack-bar';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  register: FormGroup;
  reg = false;
  constructor(public userService: UserService, private snackBar: MatSnackBar) { }
  ngOnInit() {
    this.register = new FormGroup({
      firstName: new FormControl('', [Validators.pattern('^[a-zA-Z]{4,15}'), Validators.required]),
      lastName: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{4,15}')]),
      email: new FormControl('', [Validators.required, Validators.email]),
      city: new FormControl('', [Validators.required]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{6,15}')]),
      confirmPassword: new FormControl('', [Validators.required])
    });
   }
   onSubmit(form: NgForm) {

    console.log('under submit', this.register.value);
     this.userService.registerUser(this.register.value, this.reg).subscribe((data: any) => {
       console.log(data.result);
       this.snackBar.open(data.result);
     });
   }
    //  resetForm(form: NgForm)
    // {
    //   form.reset();
    //   this.register = {
    //     firstName:
    //   }

    // }
    registerevent($event) {
      this.reg = $event;
    }
  }
