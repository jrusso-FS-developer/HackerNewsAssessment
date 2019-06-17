import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HackerNewsService {
  constructor(private http: HttpClient) { }

  public getStories(): Observable<any> {
    return this.http.get('/api/stories');
  }
}
