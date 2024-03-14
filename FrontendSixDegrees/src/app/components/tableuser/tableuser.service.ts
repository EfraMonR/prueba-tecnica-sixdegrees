import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from './../../models/user.model'

@Injectable({
  providedIn: 'root'
})
export class TableuserService {

  constructor(
    private http: HttpClient
  ) { }

  getAllUser(): Observable<User[]>  {
    return this.http.get<User[]>('https://localhost:44380/api/User/GetUsers')
  }
}
