import { Component, OnInit } from '@angular/core';
import { Film } from '../models/film';
import { FilmService } from '../services/film.service';

@Component({
    selector: 'app-film-list',
    templateUrl: './film-list.component.html',
    styleUrls: ['./film-list.component.css']
})
/** film-list component*/
export class FilmListComponent implements OnInit {
/** film-list ctor */
  displayedColumns = ['Title', 'Duration', 'Director', 'Actions'];
  dataSource = [];
  isDetailsShow: boolean = false;
  selectedFilm: Film = null;

  constructor(private _filmService: FilmService) {

  }

  ngOnInit() {
    this._filmService.getAllFilm().subscribe(data => this.dataSource= data);
    }

  showDetails(element: Film) {

    this.isDetailsShow = true;
    this.selectedFilm = element;
  }

}

