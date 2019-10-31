import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LabelsService {
  readonly rootUrl = 'https://localhost:5001/api/label';
  constructor(private http: HttpClient) { }
  GetLabel(email) {
    return this.http.get(this.rootUrl + '/label?email=' + email);
  }
  createLabel(label, email) {
    const body = {
      label: label,
      email: email
    };
    return this.http.post(this.rootUrl + '/add' , body);
  }
  editLabel(id, label) {
    const newdata = {
      Id: id,
      Label: label
    };
    return this.http.put(this.rootUrl + '/update', newdata);
  }
  deleteLabel(id) {
    return this.http.delete(this.rootUrl + '/delete?id=' + id);
  }
}
