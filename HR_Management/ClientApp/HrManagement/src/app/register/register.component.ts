import { Component } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { AccountService } from '../services/account.service';
import { Router, RouterLink } from '@angular/router';
import { RegisterUser } from '../models/register-user';
import { CommonModule } from '@angular/common';
import { CompareValidation } from '../Validators/CustomValidators';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule,RouterLink],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
  registerForm: FormGroup;
  isRegisterFormSubmitted: boolean = false;

  constructor(private accountService: AccountService, private router: Router)
  {
    this.registerForm = new FormGroup({
      personName : new FormControl(null, [Validators.required]),


      email : new FormControl(null,[Validators.required,Validators.email]),

      phoneNumber: new FormControl(null, [Validators.required]),

      password: new FormControl(null, [Validators.required]), 

      confirmPassword: new FormControl(null, [Validators.required])
    },
      {
        validators: [CompareValidation("password", "confirmPassword")]
      }
    );

  }

  get register_personNameControl() : any {
    return this.registerForm.controls["personName"];
  }
  get register_emailControl() : any {
    return this.registerForm.controls["email"];
  }
  get register_phoneNumberControl() : any {
    return this.registerForm.controls["phoneNumber"];
  }
  get register_passwordControl() : any {
    return this.registerForm.controls["password"];
  }
  get register_confirmPasswordControl() : any {
    return this.registerForm.controls["confirmPassword"];
  }


  registerSubmitted() {
    this.isRegisterFormSubmitted = true;
    if (this.registerForm.valid) {
      this.accountService.PostRegister(this.registerForm.value).subscribe({
        next: (response: any) => {
          console.log(response);
          localStorage["token"] = response.token;
          localStorage["refreshToken"] = response.refreshToken;

          this.isRegisterFormSubmitted = false;
          this.router.navigate(['/Account']);
          this.registerForm.reset();
        },
        error: (error: any) => { console.log(error) },
        complete: () => { }
      });
    }
  }
}
