import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule, FormGroup, Validators, FormControl } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { AccountService } from '../services/account.service';
import { CompareValidation } from '../Validators/CustomValidators';

@Component({
  selector: 'app-changepassword',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterLink],
  templateUrl: './changepassword.component.html',
  styleUrl: './changepassword.component.css'
})
export class ChangepasswordComponent {
  changePasswordForm: FormGroup;
  isChangePasswordFormSubmitted: boolean = false;

  constructor(public accountservice: AccountService, private router: Router) {
    this.changePasswordForm = new FormGroup({
      currentPassword: new FormControl(null, [Validators.required]),
      newPassword: new FormControl(null, [Validators.required]),
      confirmNewPassword: new FormControl(null, [Validators.required])

    },
      {
        validators: [CompareValidation("newPassword", "confirmNewPassword")]
      }
    );

  
}

  




  get changepassword_currentPassword(): any {
    return this.changePasswordForm.controls["currentPassword"]
  }
  get changepassword_newPassword(): any {
    return this.changePasswordForm.controls["newPassword"]
  }
  get changepassword_confirmNewPassword(): any {
    return this.changePasswordForm.controls["confirmNewPassword"]
  }



  public changePasswordSubmitted() {



    this.isChangePasswordFormSubmitted = true;
    if (this.changePasswordForm.valid) {
      this.accountservice.PostChangePassword(this.changePasswordForm.value).subscribe({
        next: (response: any) => {
          console.log(response),
            localStorage["token"] = response.token;
          localStorage["refreshToken"] = response.refreshToken;
          this.isChangePasswordFormSubmitted = false;
          this.changePasswordForm.reset();
          this.router.navigate(['/Account']);
        },
        error: (error:any) => {console.error(error) },
        complete: () => { }
      })
    }
  }
}


