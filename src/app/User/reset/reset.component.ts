import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl, NgForm } from '@angular/forms';
import { UserService } from 'src/app/Service/user.service';
import {MatSnackBar} from '@angular/material/snack-bar';
@Component({
  selector: 'app-reset',
  templateUrl: './reset.component.html',
  styleUrls: ['./reset.component.scss']
})
export class ResetComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
