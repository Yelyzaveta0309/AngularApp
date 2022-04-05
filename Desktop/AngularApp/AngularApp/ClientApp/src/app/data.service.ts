import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';

@Injectable()
export class DataService {
 
  constructor(private http: HttpClient) {}
 
  getProducts() {
    return this.http.get("/api/products");
  }
  getManufacturers() {
    return this.http.get("/api/manufacturers");
  }
  getCategories() {
    return this.http.get("/api/categories");
  }
  getProductsInfo() {
    return this.http.get("/api/productsInfo");
  }
}
