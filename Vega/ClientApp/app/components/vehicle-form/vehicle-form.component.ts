import { ModelService } from './../../services/model.service';
import { Make } from './../../models/make';
import { Vehicle } from './../../models/vehicle';
import { MakeService } from './../../services/make.service';
import { Component, OnInit } from '@angular/core';
import { Model } from '../../models/model';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes: any[] = [];
  models: any[] = [];
  vehicle: Vehicle = <Vehicle>{};
  make: any;
  model: any;

  constructor(private makeService: MakeService) {
  }

  ngOnInit() {
    this.makeService.getMakes().subscribe(makes => {
      this.makes = makes
    });
  }

  onMakeChange() {
    this.models = this.vehicle.make.models;
  }

}
