import { Component } from '@angular/core';
import { AuthService } from './auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  constructor(public authservice: AuthService){
    authservice.handleAuthentication();

  }

  ngOnInIt(){
    if(localStorage.getiItem('isLoggedIn') === 'true'){
      this.authservice.renewSession();
    }
  }
}
