import { Component, OnInit } from '@angular/core';
import { TableuserService } from './tableuser.service';
import { User } from '../../models/user.model'

@Component({
  selector: 'app-tableuser',
  templateUrl: './tableuser.component.html',
  styleUrls: ['./tableuser.component.scss']
})
export class TableuserComponent implements OnInit {

  //Se crea variable para almacenar respuesta de api
  users: User[] = [];

  constructor(private userService: TableuserService) {

  }

  ngOnInit(): void {

  }

  getUsers() {
    //Se llama función creada en el servicio
    this.userService.getAllUser()
      .subscribe(users => this.users = users);
  }
}
