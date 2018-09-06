import { Injectable } from "@angular/core";
import { Airports } from "./airport.model";
import { HttpHeaders, HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs/Rx';


@Injectable()
export class AirlineService {
  constructor(private readonly http: HttpClient)
  { }

  public getAirports(): Observable<Airports[]> {
    const url = `https://localhost:44301/api/airports/get`;
    const headers = new HttpHeaders({ });
    const options = { headers: headers };

    return this.http.get(url, options).catch((error: any) => Observable.throw(error));
  }
}
