import { Component, input } from '@angular/core';

@Component({
  selector: 'app-my-listbox',
  standalone: true,
  templateUrl: './my-listbox.component.html',
  styleUrl: './my-listbox.component.css'
})
export class MyListboxComponent {
  listClasses = 'full-width outlined';
  sectionClasses = ['expandable', 'elevated'];
  buttonClasses = {highlighted: true,embiggened: false, };

  


    
}
