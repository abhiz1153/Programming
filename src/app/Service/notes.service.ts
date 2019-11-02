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
RemoveArchive(id) {
  console.log('ID' , id);
  return this.http.put(this.rootUrl + '/unarchive?id=' + id, null);
}
AddTrash?(id) {
  console.log('ID' , id);
  return this.http.put(this.rootUrl + '/trash?id=' + id, null);
}
GetTrash(email) {
  return this.http.get(this.rootUrl + '/trashlist?email=' + email);
}
Delete(id) {
  return this.http.delete(this.rootUrl + '/delete?id=' + id);
}
Restore(id) {
  return this.http.put(this.rootUrl + '/restore?id=' + id, null);
}
DeleteAll(Email) {
  return this.http.delete(this.rootUrl + '/removetrash?Email=' + Email);
}
RestoreAll(Email) {
  return this.http.put(this.rootUrl + '/restoreall?Email=' + Email, null);
}
UpdateNotes(Title, Description, Id) {
  const updatenote = {
    Id: Id,
    Title: Title,
    Description: Description
     };
     return this.http.put(this.rootUrl + '/update', updatenote);
}
AddColor(id, color) {
  return this.http.put(this.rootUrl + '/color?id=' + id + '&color=' + color, null);
}
addPin(id) {
  return this.http.put(this.rootUrl + '/ispin?id=' + id, null);
}
unPin(id) {
  return this.http.put(this.rootUrl + '/unpin?id=' + id, null);
}
GetNotesLabels() {
  return this.http.get(this.rootUrl + '/viewall');
}
AddNotesLabel(id, Labelid, label) {
  const add = {
    LableId: Labelid,
    NoteId: id,
    Label: label
     };
     return this.http.post(this.rootUrl + '/addlabel', add);
}
RemoveNotesLabel(id) {
  return this.http.delete(this.rootUrl + '/deletelabel?id=' + id);
}
AddImages(id, formData) {
  return this.http.put(this.rootUrl + '/upload?id=' + id , formData);
}
}
