import { Component, OnInit } from '@angular/core';
import { Order } from '../models/order';
import { OrderService } from '../services/order.service';

@Component({
    selector: 'app-basket',
    templateUrl: './basket.component.html',
    styleUrls: ['./basket.component.css']
})
/** basket component*/
export class BasketComponent implements OnInit {
/** basket ctor */

  dataSource = [];
  displayedColumns = ['Title', 'Room', 'Seat', 'StartTime'];

  constructor(private _orderService: OrderService) {

    }
  ngOnInit() {
    this.dataSource = this._orderService.getAllOrderByUserId();
    }
}


