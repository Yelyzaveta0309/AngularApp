import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';
import { ProductInfo } from './productInfo';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css'],
    providers: [DataService]
})

export class AppComponent implements OnInit{

  productsInfo: ProductInfo[];
  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.loadProductsInfo();
  }

  loadProductsInfo() {
    this.dataService.getProductsInfo()
      .subscribe((data: ProductInfo[]) => this.productsInfo = data);
  }
}

