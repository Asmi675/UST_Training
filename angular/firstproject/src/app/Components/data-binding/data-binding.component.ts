import { Component } from '@angular/core';

@Component({
  selector: 'app-data-binding',
  standalone: true,
  imports: [],
  templateUrl: './data-binding.component.html',
  styleUrl: './data-binding.component.css'
})
//whatever we write inside export class(variable) , it can be accessed in html by usimng {{variable}}.
//variable declaration can be done only in export
export class DataBindingComponent {
  name : string ="Asmi"
  courseName : string  = "Angular 18";
  inputType ="checkbox";
  inputType1 ="radio";
  amount =99999;
  city : any;
  currentDate : Date = new Date(); 
  isIndian : boolean = false;
  constructor(){
    this.city = "Chennai";
  }
}
