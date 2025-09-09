import { Component } from '@angular/core';
import { AccountService } from '../services/account.service';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Login } from '../models/Login';
import { CommonModule } from '@angular/common';
import { Router, RouterLink } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterLink],
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  loginForm: FormGroup;
  isLoginFormSubmitted: boolean = false;
    
    registerForm: any;
  constructor(public accountService: AccountService, private router: Router) {
    this.loginForm = new FormGroup({
      email: new FormControl(null, [Validators.required, Validators.email]),
      password :new FormControl(null , [Validators.required])
    })
  }

  get login_emailFormControl() :any{
    return this.loginForm.controls["email"];
  }
  get login_passwordFormControl(): any {
    return this.loginForm.controls["password"];
  }

  loginSubmitted() {
    this.isLoginFormSubmitted = true;
    if (this.loginForm.valid) {
      this.accountService.PostLogin(this.loginForm.value).subscribe({
        next: (response: any) => {
          console.log(response);
          this.isLoginFormSubmitted = false;
          this.accountService.currentUserName = response.email;
          localStorage.setItem('token', response.token);

          localStorage.setItem('refreshToken', response.refreshToken);
          this.accountService.SetToken(response.token, response.role);
          this.router.navigate(['/Account']);
          this.loginForm.reset();
        },
         error: (error: any) => { console.log(error) },
        complete: () => { }
      })
    }
  }
}
