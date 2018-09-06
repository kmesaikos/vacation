import { Component, OnInit } from '@angular/core';
import { AirlineService } from './airlines.service';
import { Airports } from './airport.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html', 
})
export class HomeComponent implements OnInit {
 
  airports: any;
  airportId: number;
  constructor(private readonly airlineService: AirlineService)
  { }

  ngOnInit(): void {
    this.getAirports();
  }

  getAirports() {
    this.airlineService.getAirports()
      .subscribe(data => {
        this.airports = data;
        console.log(this.airports);
      })
  }

  selectName() {
    alert(this.airportId);
  }
}
