import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ListStudentsComponent } from './students/list-students.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,ListStudentsComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'studentexample';
}
