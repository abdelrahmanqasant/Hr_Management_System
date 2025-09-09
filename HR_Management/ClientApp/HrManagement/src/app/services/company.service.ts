import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CompanyList } from '../models/Company/company-list';
import { Observable } from 'rxjs/internal/Observable';
import { CreateCompany } from '../models/create-company';
import { AddCompany } from '../models/Company/add-company';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {
  private apiUrl = "https://localhost:7050/api/Companies";

  constructor(private http: HttpClient) { }

  getCompanies(): Observable<CompanyList[]>
  {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage.getItem('token')}`);
    return this.http.get<CompanyList[]>(this.apiUrl, {headers});
  }
  getCompanyById(id: number): Observable<AddCompany>
  {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage.getItem('token')}`);
    return this.http.get<AddCompany>(`${this.apiUrl}/${id}`, {headers});
  }

  createCompany(company: CreateCompany)
  {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage.getItem('token')}`);
    return this.http.post(this.apiUrl, company, {headers});
  }
  updateCompany(id: number, company: AddCompany) {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage.getItem('token')}`);
    return this.http.put(`${this.apiUrl}/${id}`, company, {headers});
  }
}
