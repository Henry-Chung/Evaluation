import { User } from './../../shared/models/user';
import { UserService } from './../../core/services/user.service';
import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { from } from 'rxjs';

@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.css'],
})
export class UserDetailsComponent implements OnInit {
  user: User;
  id: number;
  constructor(
    private userService: UserService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe((p) => {
      this.id = +p.get('id');

      this.userService.getUserDetails(this.id).subscribe((u) => {
        this.user = u;
        console.log(this.user);
      });
    });
  }
}
