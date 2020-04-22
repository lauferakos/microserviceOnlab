import { Component, Input } from '@angular/core';

import { Film } from '../models/film';

@Component({
    selector: 'app-film-details',
    templateUrl: './film-details.component.html',
    styleUrls: ['./film-details.component.css']
})
/** film-details component*/
export class FilmDetailsComponent {
/** film-details ctor */

  @Input() Film: Film;
    constructor() {

    }
}
