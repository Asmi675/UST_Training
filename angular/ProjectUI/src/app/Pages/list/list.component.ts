import { Component, OnInit, inject } from '@angular/core';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { UserService } from '../../Service/user.service';
@Component({
  selector: 'app-list',
  standalone: true,
  imports: [RouterLink,RouterLinkActive,RouterOutlet],
  templateUrl: './list.component.html',
  styleUrl: './list.component.css'
})
export class ListComponent implements OnInit{
  UserService = inject(UserService);
  UserList:any[]=[];
  ngOnInit(): void {
    this.loadUsers();
  }
  loadUsers(){
    this.UserService.getUsers().subscribe((res:any) =>{
      this.UserList=res;
    })
  }
}
