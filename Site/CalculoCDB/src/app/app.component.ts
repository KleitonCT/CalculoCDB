import { Component } from '@angular/core';
import { ApiService } from 'src/service/api.service';
import { CalculoCdbRequest } from 'src/model/CalculoCdbRequest';
import { CalculoCdbResponse } from 'src/model/CalculoCdbResponse';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'CalculoCDB';
  response = new CalculoCdbResponse(0, 0);
  request = new CalculoCdbRequest(0, 0);
  
  constructor(private apiService:ApiService) {}
   
  // refreshPeople() {
  //   this.apiService.getPeople()
  //     .subscribe(data => {
  //       console.log(data)
  //       this.people=data;
  //     })      
 
  // }
 
  calculateCDB() {
    this.apiService.calculateCDB(this.request)
      .subscribe(data => {
        console.log(data)
        this.response=data;
      })      
  }
}
