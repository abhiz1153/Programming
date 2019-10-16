
import { NgModule, Component } from '@angular/core';
import {CommonModule} from '@angular/common';
import { RegisterComponent } from './User/register/register.component';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './User/login/login.component';
import { ForgetPasswordComponent } from './User/forget-password/forget-password.component';
import {ResetComponent} from './User/reset/reset.component';
import { DashboardComponent } from './User/dashboard/dashboard.component';
import {CardsComponent} from './User/cards/cards.component';
const appRoutes: Routes = ([
  // {path : '' ,redirectTo:'./register' ,pathMatch:'full'},
  {path : 'register', component: RegisterComponent},
  {path : 'login', component: LoginComponent},
  {path : 'forget' , component: ForgetPasswordComponent},
  {path : 'reset' , component: ResetComponent},
  {path : 'dashboard' , component : DashboardComponent},
  {path : 'cards' , component : CardsComponent}
]);
@NgModule({
  imports: [
    CommonModule,
      RouterModule.forRoot(appRoutes,
        { enableTracing: true }
      )
    ],
    exports: [RouterModule]
  })

export class AppRoutingModule { }
