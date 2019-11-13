import { Component, OnInit, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-cards',
  templateUrl: './cards.component.html',
  styleUrls: ['./cards.component.scss']
})
export class CardsComponent implements OnInit {
  card1 = false;
  card2 = false;
  control = false;
  select = 'ADD TO CARD';
  @Output() registerevent = new EventEmitter<string>();
  constructor() { }
  ngOnInit() {
  }
  basic() {
    this.card2 = true;
    this.control = true;
    this.select = 'SELECTED';
    this.registerevent.emit('Basic');
  }
  advance() {
    this.card1 = true;
    this.control = true;
    this.select = 'SELECTED';
    this.registerevent.emit('Advance');
  }
}
