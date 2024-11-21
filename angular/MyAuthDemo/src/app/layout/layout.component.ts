import { Component , inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router ,RouterLink,RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-layout',
  standalone: true,
  imports: [RouterOutlet,RouterLink,FormsModule],
  templateUrl: './layout.component.html',
  styleUrl: './layout.component.css'
})
export class LayoutComponent {
  loggedUserData:any;
  constructor(){
    const loggedData = localStorage.getItem("loginUser");
    if(loggedData != null){
      this.loggedUserData = loggedData;
    }
  }
  router=inject (Router)
  LogOff(){
    localStorage.removeItem('loginUser');
    this.router.navigateByUrl('login');
  }
}
