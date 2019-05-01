import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Item } from '../item';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ItemService {
  constructor (
    private http: HttpClient
  ) {}

  postOrder(items: Item[]) {
    return this.http.post(`https://xgbtd6ys0b.execute-api.eu-west-1.amazonaws.com/Prod/api/calculatesalestaxes`,items);
  }

}
