import { Component ,inject , OnInit} from '@angular/core';
import { StudentService } from '../../Service/student.service';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-update',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './update.component.html',
  styleUrl: './update.component.css'
})
export class UpdateComponent implements OnInit{
  studentObj: any ={
  "studentId":0,
  "studentName":"",
  "studentGrade":"",
  "studentRollNo":"",
  "isActive": true,
  "createdDate":"",
  "modifiedDate":""
}
studentService = inject(StudentService)
studentList:any[]=[];

ngOnInit(): void {
    this.loadStudents();
  }
  loadStudents(){
    this.studentService.getStudents().subscribe((res:any) => {
      this.studentList=res;
    })
  }
    onEdit(data: any){
      debugger;
      this.studentObj=data;
    }
    http = inject(HttpClient);
    onUpdate(){
      debugger;
      this.http.put("https://localhost:7088/api/TblStudents/"+
      this.studentObj.studentId,this.studentObj).subscribe((res:any)=>{
        debugger;
        if(res.result)
        alert("student record created!")
        else{
          alert("Some problem in update")
        }
      })
    }
  }
