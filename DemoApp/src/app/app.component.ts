import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'DemoApp';
  response = 'loading';
  constructor(private http: HttpClient){
    this.http.get('http://localhost:5000/demo',{responseType: 'text'}).subscribe((response:any)=>{
      console.log(response);
      this.response = response;
    })
  }
}
