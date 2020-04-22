import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Film } from '../models/film';
import { Observable } from 'rxjs';

@Injectable()
export class FilmService {

  private _url: string = "https://localhost:32769/searching/Film/List";
    constructor(private http : HttpClient) {

  }

  getAllFilm(): Observable<Film[]> {
    return this.http.get<Film[]>(this._url);
  }
}
