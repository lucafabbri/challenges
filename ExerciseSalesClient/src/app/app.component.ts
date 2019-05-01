
import { Component, NgModule } from '@angular/core';
import { ItemService } from './shared/items.service';
import { Item } from '../app/item';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.less']
})
export class AppComponent {
  constructor(private itemService: ItemService) {}
  receipt: {};
  items: Item[] = [];
  item: Item = {
    name:"",
    isImported:false,
    category: 0,
    unitPrice: 0,
    quantity: 0,
    total: 0,
    salesTax: 0,
  };
  title = 'ExerciseSalesClient';
  postItems () : void {
    this.itemService.postOrder(this.items).subscribe(data => this.receipt = data);
  };
  addItem() : void{
    this.items.push({
      name: this.item.name,
      isImported:this.item.isImported,
      category: this.item.category,
      unitPrice: this.item.unitPrice,
      quantity: this.item.quantity,
      total: 0,
      salesTax: 0,
    });
    console.log(this.items)
    this.item = {
      name:"",
      isImported:false,
      category: 0,
      unitPrice: 0,
      quantity: 0,
      total: 0,
      salesTax: 0,
    };
    console.log(this.items)
  }
}
