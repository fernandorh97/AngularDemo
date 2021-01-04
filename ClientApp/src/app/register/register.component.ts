import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { User, UsersService } from '../users.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(private usersService: UsersService) {}

  formdata;

  submitted = false;
  registered = false;

  ngOnInit() {
    this.formdata = new FormGroup({
      emailid: new FormControl("", [
        Validators.required,
        Validators.email
      ]),
      passwd: new FormControl("", [
        Validators.required,
        Validators.minLength(5)
      ])
    });
  }

  onClickSubmit() {
    this.submitted = true;
    
    if (!this.formdata.invalid) {
      this.registered = true;

      var add_user = <User>{};
      add_user.email = this.formdata.value.emailid;
      add_user.password = this.formdata.value.passwd;
  
      this.usersService.addUser(add_user).subscribe(result => {
      });
    }
  }

}