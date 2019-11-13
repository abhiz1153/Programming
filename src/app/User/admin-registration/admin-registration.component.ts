import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl, NgForm } from '@angular/forms';
import { AdminService } from 'src/app/Service/admin.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-admin-registration',
  templateUrl: './admin-registration.component.html',
  styleUrls: ['./admin-registration.component.scss']
})
export class AdminRegistrationComponent implements OnInit {
  register: FormGroup;
  registerForm: any;
  constructor(private adminService: AdminService, private route: Router) { }

  ngOnInit() {
    this.register = new FormGroup({
      firstName: new FormControl('', [Validators.pattern('^[a-zA-Z]{4,15}'), Validators.required]),
      lastName: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{4,15}')]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{6,15}')])
    });
  }
  onSubmit(form: NgForm) {
    this.adminService.registerAdmin(this.register.value).subscribe((data: any) => {
      this.route.navigate(['/login']);
    });
  }
}
