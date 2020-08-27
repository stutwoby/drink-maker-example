import { Injectable } from '@angular/core';
import * as signalR from '@aspnet/signalr'

@Injectable({
  providedIn: 'root'
})
export class SignalrService {
  private hubConnection: signalR.HubConnection;
  data: string[] = [];

  constructor() { }

  public startConnection() {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl("https://localhost:44322/drink-hub")
      .build();

    this.hubConnection
      .start()
      .then(() => console.log('Connection started'))
      .catch(err => console.log('Error while starting connection: ' + err))
  }

  public addDrinksListener() {
    this.hubConnection.on('makeDrink', (data) => {
      this.data.push(data as string);
      console.log(data);
    });
  }
}
