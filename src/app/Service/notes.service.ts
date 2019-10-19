import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { MatCalendarBody } from '@angular/material';
@Injectable({
  providedIn: 'root'
})
export class NotesService {
  readonly rootUrl = 'https://localhost:5001/api/notes';
  constructor(private http: HttpClient) { }


  GetNotes(note) {
  return this.http.get(this.rootUrl + '/note?email=' + note);
}
 AddNotes(title, description, email) {
const newnote = {
 Email: email,
 Title: title,
 Description: description
  };
  return this.http.post(this.rootUrl + '/add', newnote);
 }
 AddReminder(date, id) {
 return this.http.put(this.rootUrl + '/reminder?id=' + id + '&reminder=' + date, null);
}
GetReminder(note) {
  return this.http.get(this.rootUrl + '/getReminder?email=' + note);
}
AddArchive(id) {
  console.log('ID' , id);
  return this.http.put(this.rootUrl + '/isarchive?id=' + id, null);
}
GetArchive(note) {
  return this.http.get(this.rootUrl + '/archivenote?email=' + note);
}
}
