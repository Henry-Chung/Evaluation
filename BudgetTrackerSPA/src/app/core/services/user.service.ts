import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Observable } from 'rxjs';
import { User } from 'src/app/shared/models/user';
@Injectable({
  providedIn: 'root',
})
export class UserService {
  constructor(private apiService: ApiService) {}

  getAllUsers(): Observable<User[]> {
    // http://localhost:58601/api/genres
    // http://localhost:58601/api/account/login
    return this.apiService.getAll('users');
  }

  getUserDetails(id: number): Observable<User> {
    return this.apiService.getOne(`${'users/'}${id}`);
  }
}
