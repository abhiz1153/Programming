
import { NgModule, Component } from '@angular/core';
import {CommonModule} from '@angular/common';
import { RegisterComponent } from './User/register/register.component';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './User/login/login.component';
import { ForgetPasswordComponent } from './User/forget-password/forget-password.component';
import {ResetComponent} from './User/reset/reset.component';
import { DashboardComponent } from './User/dashboard/dashboard.component';
import {CardsComponent} from './User/cards/cards.component';
import { NotesComponent } from './User/notes/notes.component';
import { ReminderComponent } from './User/reminder/reminder.component';
import { ArchiveComponent } from './User/archive/archive.component';
import { TrashComponent } from './User/trash/trash.component';
import { DisplayNoteComponent } from './User/display-note/display-note.component';
const appRoutes: Routes = ([
   {path : '' , redirectTo: './login' , pathMatch: 'full'},
  {path : 'register', component: RegisterComponent},
  {path : 'login', component: LoginComponent},
  {path : 'forget' , component: ForgetPasswordComponent},
  {path : 'reset' , component: ResetComponent},
  {path : 'dashboard' , component : DashboardComponent,
  children: [
    { path: '', component: DisplayNoteComponent},
    { path : 'displaynote', component: DisplayNoteComponent},
    { path : 'reminder', component: ReminderComponent},
    {path : 'archive' , component: ArchiveComponent},
    {path : 'trash' , component : TrashComponent}
  ]
},

  {path : 'cards' , component : CardsComponent},
  {path: 'notes' , component : NotesComponent},
  {path : 'displaynote', component: DisplayNoteComponent}
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
