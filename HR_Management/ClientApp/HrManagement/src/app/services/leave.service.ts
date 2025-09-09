import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LeaveRequestStatus, LeaveRequestVM } from '../models/Leave/leave-request-vm';
import { AddLeaveRequestVM } from '../models/Leave/add-leave-request-vm';
import { UpdateLeaveRequestVM } from '../models/Leave/update-leave-request-vm';
import { EditLeaveRequestVM } from '../models/Leave/edit-leave-request-vm';
import { LeaveRequestSummaryVM } from '../models/Leave/leave-request-summary-vm';

@Injectable({
  providedIn: 'root'
})

export class LeaveService {
  private apiUrl = "https://localhost:7050/api/leaveRequests";

  constructor(private http: HttpClient) { }
  private authHeaders(): HttpHeaders {
    let headers = new HttpHeaders();
    const token = localStorage.getItem('token');
    if (token)
    {
      headers = headers.append('Authorization', ` Bearer ${token}`);
    }
    headers = headers.append('Content-Type', 'application/json');
    
  
  return headers
 
  }
  getRequests(): Observable<LeaveRequestVM[]> {
   
    return this.http.get<LeaveRequestVM[]>(this.apiUrl,
      { headers: this.authHeaders() });
  }
  getRequesById(id: number): Observable<LeaveRequestVM> {
    return this.http.get<LeaveRequestVM>(`${this.apiUrl}/${id}`,
      { headers: this.authHeaders() })
  }
  
  addRequest(request: AddLeaveRequestVM): Observable<AddLeaveRequestVM> {
    return this.http.post<AddLeaveRequestVM>(this.apiUrl,
      { headers: this.authHeaders() })
  }
  updateRequest(id: number, request: EditLeaveRequestVM): Observable<LeaveRequestVM> {
    return this.http.put<LeaveRequestVM>(`${this.apiUrl}/${id}`,
      { headers: this.authHeaders() })
  }
  deleteRequest(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`,
      { headers: this.authHeaders() })
  }
  updateStatus(id: number, status: LeaveRequestStatus): Observable<LeaveRequestVM> {
    return this.http.put<LeaveRequestVM>(`${this.apiUrl}/${id}/status`, status,
      { headers: this.authHeaders() })
  }
  getSummaryByEmployee(employeeId: number): Observable<LeaveRequestSummaryVM> {
    return this.http.get<LeaveRequestSummaryVM>
      (`${this.apiUrl}/Employee/${employeeId}/summary`,
      { headers: this.authHeaders()})
  }

}
