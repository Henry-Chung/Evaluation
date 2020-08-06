import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
@Injectable({
  providedIn: 'root',
})
export class ApiService {
  constructor(protected http: HttpClient) {}

  getAll(path: string): Observable<any[]> {
    // we need to append the common url with path that is being passed
    // map is same as select in C# LINQ
    // 1, 2, 3 select, map (n => n*n ) = 1, 4, 9
    // 1, 2, 3 where, filter(n => n > 2) = 3
    return this.http
      .get(`${environment.apiUrl}${path}`)
      .pipe(map((resp) => resp as any[]));
  }
}
