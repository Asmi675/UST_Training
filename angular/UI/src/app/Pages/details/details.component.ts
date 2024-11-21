import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-details',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './details.component.html',
  styleUrl: './details.component.css'
})
export class DetailsComponent {
  studentDetail: any={
    "studentId": 0,
    "studentName":"",
    "studentGrade":"",
    "studentRollNo":"",
    "isActive": true,
    "createdDate":"",
    "modifiedDate":new Date()
  }

  http=inject(HttpClient)
  onSubmit()
  {
    this.http.get("https://localhost:7088/api/TblStudents/"+ this.studentDetail.studentId).subscribe((res:any)=> {
      this.studentDetail.studentName = res.studentName,this.studentDetail.studentGrade = res.studentGrade,this.studentDetail.studentRollNo = res.studentRollNo,this.studentDetail.isActive = res.isActive,this.studentDetail.createdDate = res.createdDate;
  })
  }
}
