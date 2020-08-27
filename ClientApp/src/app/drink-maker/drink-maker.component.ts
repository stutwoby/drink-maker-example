import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SignalrService } from '../services/signalr.service';
import { ThrowStmt } from '@angular/compiler';

@Component({
  selector: 'app-drink-maker',
  templateUrl: './drink-maker.component.html',
  styleUrls: ['./drink-maker.component.css']
})
export class DrinkMakerComponent implements OnInit {
  constructor(private http: HttpClient, private signalrService: SignalrService) { }

  ngOnInit() {
    this.signalrService.startConnection();
    this.signalrService.addDrinksListener();
  }

  public startToMakeDrink(drinkId: number) {
    this.http.get('https://localhost:44322/api/drink/make/' + drinkId)
      .subscribe(res => {
        console.log(res);
      });
  }

}
