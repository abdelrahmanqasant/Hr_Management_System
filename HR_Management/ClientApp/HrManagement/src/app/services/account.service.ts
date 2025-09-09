
import { Injectable } from '@angular/core';
import { RegisterUser } from '../models/register-user';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Login } from '../models/Login';
import { ChangePassword } from '../models/change-password';
const API_BASE_URL: string = "https://localhost:7050/api/account/";
@Injectable({
  providedIn: 'root'
})
export class AccountService {
  public currentUserName: string | null = null;

  constructor(private httpClient: HttpClient) { }
  public PostRegister(registerUser: RegisterUser): Observable<any> {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage['token']}`);
    return this.httpClient.post<RegisterUser>(`${API_BASE_URL}register`, registerUser, { headers: headers });
  }

  public PostLogin(login: Login): Observable<any> {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage
      .getItem('token')}`);
    return this.httpClient.post<any>(`${API_BASE_URL}login`,
      login, { headers: headers });
  }
  public getLogout(): Observable<string> {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage
      .getItem('token')}`);
    return this.httpClient.get<string>(`${API_BASE_URL}logout`);
  }
  public PostChangePassword(changepassword: Partial<ChangePassword>):
    Observable<any> {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", ` Bearer ${localStorage
      .getItem('token')}`);
    return this.httpClient.post<any>(`${API_BASE_URL}changePassword`,
      changepassword,

      { headers:headers }
    );


  }
  getRole(): string | null {
    return localStorage.getItem('role');
  }
  isAdmin(): boolean {
    const token = localStorage.getItem('token');
    if (!token) return false;

    try {
      const payload = JSON.parse(atob(token.split('.')[1]));

      const roleClaim = payload['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'];

      return roleClaim && roleClaim === 'Admin';
    } catch (e) {
      console.error('Error decoding token', e);
      return false;
    }
  }
  public SetToken(token: string, role: string) {
    localStorage.setItem('token', token);
    localStorage.setItem('role', role);
  }
  getRoleFromToken(): string | null {
    const token = localStorage.getItem('token');
    if (!token) return null;
    const payload = JSON.parse(atob(token.split('.')[1]));
    return payload["role"] || null;
  }
  isLoggedIn() :boolean{
    const token = localStorage.getItem('token');
    return !!token
  }

}
