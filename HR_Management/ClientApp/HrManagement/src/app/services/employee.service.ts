import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { EmployeeList } from '../models/Employee/employee-list';
import { AddEmployee } from '../models/Employee/add-employee';
import { EmployeesInCompany } from '../models/Employee/EmployeesInCompany';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  private apiUrl = "https://localhost:7050/api/employees"; 
  constructor(private http: HttpClient) { }
  getEmployees(): Observable<EmployeeList[]> {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage.getItem('token')}`);
    return this.http.get<EmployeeList[]>(this.apiUrl, {headers}); 
  }
  getEmployeeById(id: number): Observable<AddEmployee> {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage.getItem('token')}`);
    return this.http.get<AddEmployee>(`${this.apiUrl}/${id}`, {headers});
  }
  getEmployeesByCompany(companyId?: number): Observable<EmployeesInCompany[]> {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage.getItem('token')}`);
   
    let url = `${this.apiUrl}/ByCompany/${companyId}`;
   
    return this.http.get<EmployeesInCompany[]>(url, {headers});
  }
  addEmployee(employee: AddEmployee) {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage.getItem('token')}`);
    return this.http.post(this.apiUrl, employee, {headers});
  }
  updateEmployee(id: number, employee: AddEmployee) {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage.getItem('token')}`);
    return this.http.put(`${this.apiUrl}/${id}`, employee, {headers});
  }
}
