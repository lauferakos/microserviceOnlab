import { Injectable } from '@angular/core';

@Injectable()
export class ProjectionService {
    constructor() {

  }

  getAllProjectionByFilmId()
  {
    return [
      { _id: 1, film: { _id: 1, Title: 'asd', Director: 'asd', Duration: 200 }, room: 1, freeseats: 20, startTime: '2020.02.10 20:00' },
      { _id: 1, film: { _id: 1, Title: 'asd', Director: 'asd', Duration: 200 }, room: 2, freeseats: 20, startTime: '2020.02.10 21:00' },
      { _id: 1, film: { _id: 1, Title: 'asd', Director: 'asd', Duration: 200 }, room: 3, freeseats: 20, startTime: '2020.02.10 22:00' }
    ];
  }
}
