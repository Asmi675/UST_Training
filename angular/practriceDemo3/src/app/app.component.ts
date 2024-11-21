import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MyListboxComponent } from './my-listbox/my-listbox.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet ,MyListboxComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})


export class AppComponent {

  theme = "Dark";
  firstName = "Anjali";


  save = false; 
//in html ----->   //<button [disabled]="save">Save</button> 
  
  submit = true; 
//in html ----->   //<button [disabled]="submit">Submit</button> 

}
