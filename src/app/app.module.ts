import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatFormFieldModule, MatSelectModule, MatInputModule, MatLabel, MatMenuModule } from '@angular/material';
import { RegisterComponent } from './User/register/register.component';
import {AppRoutingModule} from './app-routing.module';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { MatToolbarModule, MatButtonModule, MatSidenavModule, MatIconModule, MatListModule, MatCardModule } from '@angular/material';
import { FormsModule , ReactiveFormsModule} from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';
import { UserService } from './Service/user.service';
import { LoginComponent } from './User/login/login.component';
import { ForgetPasswordComponent } from './User/forget-password/forget-password.component';
import {  SocialLoginModule, AuthServiceConfig, GoogleLoginProvider, FacebookLoginProvider} from 'angular-6-social-login';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import { ResetComponent } from './User/reset/reset.component';
import { DashboardComponent } from './User/dashboard/dashboard.component';
import { CardsComponent } from './User/cards/cards.component';
export function getAuthServiceConfigs() {
  const config = new AuthServiceConfig(
      [
        {
          id: GoogleLoginProvider.PROVIDER_ID,
          provider: new GoogleLoginProvider('934977231069-8mtj2ihulrvr0eikc58cj5bdeepg6vui.apps.googleusercontent.com')
        },
        {
          id: FacebookLoginProvider.PROVIDER_ID,
          provider: new FacebookLoginProvider ('363406137898633')
        }
      ]);
  return config;
}

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    LoginComponent,
    ForgetPasswordComponent,
    ResetComponent,
    DashboardComponent,
    CardsComponent

  ],
  imports: [
    BrowserModule,
    MatFormFieldModule,
    BrowserAnimationsModule,
    MatSelectModule,
    MatInputModule,
    AppRoutingModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatCardModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    SocialLoginModule,
    MatSnackBarModule,
    MatMenuModule
    ],
  providers: [UserService,
    { provide: AuthServiceConfig, useFactory: getAuthServiceConfigs }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
platformBrowserDynamic().bootstrapModule(AppModule);
