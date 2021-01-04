import { Component, Inject, OnInit } from '@angular/core';
import { UsersService } from '../users.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})

export class UserListComponent implements OnInit {
  public users: User[];
  public count = 0;

  constructor(usersService: UsersService) {
    usersService.getAllUsers().subscribe(result => {
      this.users = result;
      this.count = result.length;
    }, error => console.error(error));
  }

  ngOnInit() {
  }

}

interface User {
  userId: number;
  email: string;
  password: string;
}
