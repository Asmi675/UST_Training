import { HttpClient } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-delete',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './delete.component.html',
  styleUrl: './delete.component.css'
})
export class DeleteComponent {
  DeleteDetail: any = {
    "studentId": 0,
    "studentName": "",
    "studentGrade": "",
    "studentRollNo": "",
    "isActive": true,
    "createdDate": "",
    "modifiedDate": new Date()
  }
  http = inject(HttpClient)
  onDelete() {
    this.http.delete("https://localhost:7088/api/TblStudents/" + this.DeleteDetail.studentId).subscribe((res: any) => {
      
      alert("Student record successfully Deleted!");
    })
  }
}
