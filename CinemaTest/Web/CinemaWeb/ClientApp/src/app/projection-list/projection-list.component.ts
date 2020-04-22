import { Component, OnInit } from '@angular/core';
import { Projection } from '../models/projection';
import { ProjectionService } from '../services/projection.service';

@Component({
    selector: 'app-projection-list',
    templateUrl: './projection-list.component.html',
    styleUrls: ['./projection-list.component.css']
})
/** projection-list component*/
export class ProjectionListComponent implements OnInit {
/** projection-list ctor */

  dataSource = [];
  displayedColumns = ['Room', 'FreeSeats', 'StartTime', 'Actions'];
  constructor(private _projectionService: ProjectionService) {

    }
  ngOnInit() {
    this.dataSource = this._projectionService.getAllProjectionByFilmId();
    }
}

