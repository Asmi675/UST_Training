import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { BreadtoastComponent } from "./breadtoast/breadtoast.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, BreadtoastComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'toster';
}
