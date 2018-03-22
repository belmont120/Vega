import { Make } from "./make";
import { Model } from "./model";


export class Vehicle {
    public id: number = 0;
    public make: Make = <Make>{};
    public model: Model = <Model>{};
}