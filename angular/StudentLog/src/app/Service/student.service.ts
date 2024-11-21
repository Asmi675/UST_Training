import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private http :HttpClient) { }
  getStudents(){
    return this.http.get("https://localhost:7088/api/TblStudents");
  }
}
