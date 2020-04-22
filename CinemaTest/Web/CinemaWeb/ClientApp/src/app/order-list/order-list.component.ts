import { Component } from '@angular/core';
import { Order } from '../models/order';

@Component({
    selector: 'app-order-list',
    templateUrl: './order-list.component.html',
    styleUrls: ['./order-list.component.css']
})
/** order-list component*/
export class OrderListComponent {
/** order-list ctor */

  displayedColumns = ['Title', 'Room', 'Seat', 'StartTime', 'Actions'];
  dataSource = ELEMENT_DATA;
    constructor() {

    }
}

const ELEMENT_DATA: Order[] = [
  { _id: 1, Title: 'abc', Room: 1, SeatRow: 1, SeatColumn: 1, StartTime: '2020.02.15 16:30' },
  { _id: 1, Title: 'aht', Room: 2, SeatRow: 1, SeatColumn: 2, StartTime: '2020.02.15 16:30' },
  { _id: 1, Title: 'kut', Room: 2, SeatRow: 1, SeatColumn: 1, StartTime: '2020.05.10 20:30' },
  { _id: 1, Title: 'wqe', Room: 1, SeatRow: 3, SeatColumn: 2, StartTime: '2020 06.12 16:30' }

];
