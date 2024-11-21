import { Component } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-breadtoast',
  standalone: true,
  imports: [],
  templateUrl: './breadtoast.component.html',
  styleUrl: './breadtoast.component.css'
})
export class BreadtoastComponent {

  constructor(private toastr: ToastrService) {}

  showSuccess() {
    this.toastr.success('Ran into some error!', 'Warning!');
}
}