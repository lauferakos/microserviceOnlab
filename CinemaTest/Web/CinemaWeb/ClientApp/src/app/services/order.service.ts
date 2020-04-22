import { Injectable } from '@angular/core';

@Injectable()
export class OrderService {
    constructor() {

  }

  getAllOrderByUserId() {
    return [
      { _id: 1, Title: 'abc', Room: 1, SeatRow: 1, SeatColumn: 1, StartTime: '2020.02.15 16:30' }

    ];
  }

}
