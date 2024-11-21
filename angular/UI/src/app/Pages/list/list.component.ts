import { Component , inject,OnInit } from '@angular/core';
import { StudentService } from '../../Service/student.service';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-list',
  standalone: true,
  imports: [RouterLinkActive,RouterOutlet,RouterLink],
  templateUrl: './list.component.html',
  styleUrl: './list.component.css'
})
export class ListComponent implements OnInit{
  StudentService = inject(StudentService);
  StudentList:any[]=[];
  ngOnInit(): void {
    this.loadStudents();
  }
  loadStudents(){
    this.StudentService.getStudents().subscribe((res:any) =>{
      this.StudentList=res;
    })
  }
}
