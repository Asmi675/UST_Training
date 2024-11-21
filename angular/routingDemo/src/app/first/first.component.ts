import { Component } from '@angular/core';
import { RouterOutlet , RouterLink , RouterLinkActive } from '@angular/router';
import { ChildAComponent } from './child-a/child-a.component';
import { ChildBComponent } from './child-b/child-b.component';

@Component({
  selector: 'app-first',
  standalone: true,
  imports: [ RouterOutlet , RouterLink , RouterLinkActive ],
  templateUrl: './first.component.html',
  styleUrl: './first.component.css'
})
export class FirstComponent {

}
