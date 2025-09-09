import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
 

import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { CompanyService } from '../../services/company.service';
@Component({
  selector: 'app-add-company',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './add-company.component.html',
  styleUrl: './add-company.component.css'
})
export class AddCompanyComponent {
  addCompanyForm: FormGroup;
  isAddCompanyFormSubmitted: boolean = false;
  constructor(private FB:FormBuilder, private service: CompanyService, private router: Router)
  {
    this.addCompanyForm =
      this.FB.group({
        name: ['', Validators.required],
        address: ['', Validators.required],
        industry: ['', Validators.required]
    



      
    })

  }

  get addCompany_nameFormControl(): any {
    return this.addCompanyForm.controls["name"];
  }
  get addCompany_addressFormControl(): any {
    return this.addCompanyForm.controls["address"];
  }
  get addCompany_industryFormControl(): any {
    return this.addCompanyForm.controls["industry"];
  }


  addCompany() {
    this.isAddCompanyFormSubmitted = true;
    if (this.addCompanyForm.valid) {
      this.service.createCompany(this.addCompanyForm.value).subscribe({

        next: () => {
          this.router.navigate(['/Companies']);
          this.isAddCompanyFormSubmitted = false;
          this.addCompanyForm.reset();
        },
        error: (err: any) => {console.error(err) }


      })
    }
  }
}
