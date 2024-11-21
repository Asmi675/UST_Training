import { HttpClient } from '@angular/common/http';
import { Component,inject } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-new',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './add-new.component.html',
  styleUrl: './add-new.component.css'
})
export class AddNewComponent {
  studentObj :any ={
    "studentId":0,
    "studentName":"",
    "studentGrade":"",
    "studentRollNo":"",
    "isActive": true,
    "createdDate":"",
    "modifiedDte":""
  }
  http = inject(HttpClient);
  onSubmit(){
    debugger;
    this.http.post("https://localhost:7088/api/TblStudents",
    this.studentObj).subscribe((res:any)=> {
      debugger;
      if(res.studentId >=0)
      alert("Student record successfully created!");
      else{
        alert("Something went wrong in student creation")
      }
    })
  }
}
