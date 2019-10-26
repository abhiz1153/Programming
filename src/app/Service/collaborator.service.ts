import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CollaboratorService {
  readonly rootUrl = 'https://localhost:5001/api/collaborators';
  constructor(private http: HttpClient) { }

add(sender, id, reciver) {
  const body = {
    SenderEmail: sender,
    NoteId: id,
    ReciverEmail: reciver
    };
    return this.http.post(this.rootUrl + '/add', body);
}
}
