import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  readonly rootUrl = 'https://localhost:5001/';
  constructor(private http: HttpClient) { }

  registerUser(user) {
   const body = {
      FirstName: user.firstName,
      LastName: user.lastName,
      Email: user.email,
      City: user.city,
      Password: user.password
    };
    console.log('test', body);
    return this.http.post(this.rootUrl + 'api/account/register', body);
  }
 loginUser(user) {
   const body = {
     Email: user.email,
     Password: user.password
   };
   console.log('test', body);
    return this.http.post(this.rootUrl + 'api/account/login', body);
 }

 forgetPassword(user) {
   const body = {
     Email: user.email
   };
   return this.http.put(this.rootUrl + 'api/account/forgetpassword', body);
 }
 facebook(user) {
   const body = {
     Email: user
   };
   console.log('data in user service', user);
   return this.http.post(this.rootUrl + 'api/account/facebooklogin', body);
 }
 google(user) {
  const body = {
    Email: user
  };
  console.log('data in user service', user);
  return this.http.post(this.rootUrl + 'api/account/google', body);
}
}
