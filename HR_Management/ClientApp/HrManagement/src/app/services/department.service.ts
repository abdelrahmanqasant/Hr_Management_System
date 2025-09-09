import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DepartmentList } from '../models/Department/department-list';
import { AddDepartment } from '../models/Department/add-department';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {
  private apiUrl = "https://localhost:7050/api/departments";
  constructor(private http: HttpClient) { }

  getDepartments(): Observable<DepartmentList[]> {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage.getItem('token')}`);
    return this.http.get<DepartmentList[]>(this.apiUrl, {headers});
  }
  getDepartmentById(id: number): Observable<AddDepartment> {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage.getItem('token')}`);
    return this.http.get<AddDepartment>(`${this.apiUrl}/${id}`, {headers});
  }

  addDepartment(department: AddDepartment) {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage.getItem('token')}`);
    return this.http.post(this.apiUrl, department, {headers});
  }
  updateDepartment(id: number, department: AddDepartment) {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage.getItem('token')}`);
    return this.http.put(`${this.apiUrl}/${id}`, department, {headers});
  }
}
