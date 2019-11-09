import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AdminService {
  readonly rootUrl = 'https://localhost:5001/api/admin';
  constructor(private http: HttpClient) { }
  userStatic() {
    return this.http.get(this.rootUrl + '/loginlist');
  }
}
