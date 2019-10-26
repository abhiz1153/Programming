import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { RegisterComponent } from './register.component';
import { ReactiveFormsModule , FormsModule} from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { MatFormFieldModule, MatInputModule } from '@angular/material';
import { MatButtonModule, MatCardModule } from '@angular/material';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {CardsComponent} from '../cards/cards.component';
import {MatToolbarModule} from '@angular/material/toolbar';
import { HttpClientModule } from '@angular/common/http';
describe('RegisterComponent', () => {
  let component: RegisterComponent;
  let fixture: ComponentFixture<RegisterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RegisterComponent ,CardsComponent],
      imports: [ReactiveFormsModule,
        FormsModule,
        MatSnackBarModule,
        BrowserModule,
        MatFormFieldModule,
        MatInputModule,
        MatCardModule,
        MatButtonModule,
        MatSnackBarModule,
        BrowserAnimationsModule,
        MatToolbarModule,
        HttpClientModule
     ]

    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
  it('Form should be invalid', async(() => {
    component.register.controls['firstName'].setValue('');
    component.register.controls['lastName'].setValue('');
    component.register.controls['email'].setValue('');
    component.register.controls['city'].setValue('');
    component.register.controls['password'].setValue('');
    component.register.controls['confirmPassword'].setValue('');
    expect(component.register.valid).toBeFalsy();
  }));
  it('Form should be valid', async(() => {
    component.register.controls['firstName'].setValue('Abhishek');
    component.register.controls['lastName'].setValue('Sharma');
    component.register.controls['email'].setValue('abhishek@gmail.com');
    component.register.controls['city'].setValue('Bangalore');
    component.register.controls['password'].setValue('password');
    component.register.controls['confirmPassword'].setValue('password');
    expect(component.register.valid).toBeTruthy();
  }));
});
