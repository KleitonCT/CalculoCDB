import { HttpClient, HttpHeaders } from '@angular/common/http';
import { CalculoCdbRequest } from 'src/model/CalculoCdbRequest';
import { CalculoCdbResponse } from 'src/model/CalculoCdbResponse';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
 
@Injectable({providedIn:'root'})
export class ApiService {
 
  baseURL: string = "https://localhost:44399/api/";
 
  constructor(private http: HttpClient) {
  }
 
  calculateCDB(request:CalculoCdbRequest): Observable<any> {
    const headers = { 'content-type': 'application/json'}  
    const body=JSON.stringify(request);
    console.log(body)
    return this.http.post<CalculoCdbResponse>(this.baseURL + 'CalculoCDB', body,{'headers':headers})
  }
 
}