import { DatePipe } from '@angular/common';
import { Component } from '@angular/core';

export class Student
{
  id: number;
  name: string;
  gender: string;
  email?: string;
  phoneNumber?: number;
  dateOfBirth: Date;
  department: string;
  isActive: boolean;
  photoPath?: string;

}
@Component({
  selector: 'app-list-students',
  standalone: true,
  imports: [DatePipe],
  templateUrl: './list-students.component.html',
  styleUrl: './list-students.component.css'
})
export class ListStudentsComponent {
  students : Student[] = [ {
    id: 1,
    name:"Aparna",
    gender: "Female",
    email: "Aparna@gmail.com",
    phoneNumber: 9234567891,
    dateOfBirth: new Date(24-2-2002),
    department: "CSE",
    isActive: true,
    photoPath: "./stud3.jpg"
  },
  {
    id: 2,
    name:"Ashna",
    gender: "Female",
    email: "Ashna@gmail.com",
    phoneNumber: 8263567895,
    dateOfBirth: new Date(23-18-2002),
    department: "CSE",
    isActive: true,
    photoPath: "./stud1.jpg"
  },
  {
    id: 3,
    name:"Simran",
    gender: "Female",
    email: "Simran@gmail.com",
    phoneNumber: 9583567892,
    dateOfBirth: new Date(1-10-2002),
    department: "CSE",
    isActive: true,
    photoPath: "./stud2.jpg"
  }
]

}
