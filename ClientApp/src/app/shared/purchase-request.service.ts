import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PurchaseRequestService {

  constructor(private http: HttpClient) {
    
  }
  putPurcahseRequest(pr){
    var tok = localStorage.getItem('token');
    if(tok != null){
      var tokenHeader = new HttpHeaders({'Authorization':'Bearer ' + tok});
      return this.http.put(environment.apiBaseURI + '/PurchaseRequest', pr, {headers : tokenHeader});
    }
  }
  getPurchaseRequestList(status){
    var tok = localStorage.getItem('token');
    if(tok != null){
      var tokenHeader = new HttpHeaders({'Authorization':'Bearer ' + tok});
      return this.http.get(environment.apiBaseURI + '/PurchaseRequest?status=' + status,{headers : tokenHeader});
    }
  }
}