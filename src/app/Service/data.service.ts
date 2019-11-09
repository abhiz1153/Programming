import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private dashboard = new Subject<string>();
  dashh$ = this.dashboard.asObservable();

  private _dashboard = new Subject<Boolean>();
  dash$ = this._dashboard.asObservable();
  constructor() { }
  viewlist(value: boolean) {
    this._dashboard.next(value);
  }
  searchData(data: string) {
    this.dashboard.next(data);
  }
}