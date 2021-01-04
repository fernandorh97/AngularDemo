import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

const headers: HttpHeaders = new  HttpHeaders();
headers.set('Content-Type', 'application/x-www-form-urlencoded');

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private http: HttpClient) {}

  getAllUsers() {
    return this.http.get<any>('usertest');
  }

  addUser(user : User) {
    return this.http.post('usertest/add', user, { headers: headers });
  }
}


export interface User {
  userId: number;
  email: string;
  password: string;
}