import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class ModelService {

  constructor(private http: Http) { }

  getModels() {
    this.http.get('/api/models')
      .map(m => m.json());
  }
}
