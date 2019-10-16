import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl, NgForm } from '@angular/forms';
import { UserService } from 'src/app/Service/user.service';
import {MatSnackBar} from '@angular/material/snack-bar';

@Component({
  selector: 'app-forget-password',
  templateUrl: './forget-password.component.html',
  styleUrls: ['./forget-password.component.css']
})
export class ForgetPasswordComponent implements OnInit {
forget: FormGroup;
constructor(public userService: UserService, private snackBar: MatSnackBar) { }

ngOnInit() {
  this.forget = new FormGroup({
    email: new FormControl('', [Validators.required])
  });
}
onSubmit(form: NgForm) {

  console.log('under submit', this.forget.value);
   this.userService.forgetPassword(this.forget.value).subscribe((data: any) => {
    // tslint:disable-next-line: triple-equals
    this.snackBar.open(data.result);
    }
  );
}
}
