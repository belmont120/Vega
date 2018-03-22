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
  model: Model = <Model>{};

  constructor(private makeService: MakeService, private modelService: ModelService) {
  }

  ngOnInit() {
    this.makeService.getMakes().subscribe(makes => {
      this.makes = makes
    });

    this.modelService.getModels().subscribe(models => {
      this.models = models
    });
  }

  onMakeChange() {
    var selectedMake = this.vehicle.make;
    this.models = this.models.filter(m => m.make.id === selectedMake.id);

  }

  onModelChange() {
    var selectedMake = this.makes.find(m => m.id === this.vehicle.model.make.id);
    this.make = selectedMake;
    this.vehicle.make = selectedMake;
  }
}
