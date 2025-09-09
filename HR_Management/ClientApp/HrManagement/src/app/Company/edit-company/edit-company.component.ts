import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CompanyService } from '../../services/company.service';
import { AddCompany } from '../../models/Company/add-company';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-edit-company',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './edit-company.component.html',
  styleUrl: './edit-company.component.css'
})
export class EditCompanyComponent implements OnInit {
  editCompanyForm!: FormGroup;
  companyId!: number;
  isFormSubmitted: boolean = false;
  isLoading: boolean = true;
  constructor(private FB: FormBuilder,
    private router: Router, private route: ActivatedRoute,
    private companyService: CompanyService) { }

  ngOnInit(): void {
    this.editCompanyForm = this.FB.group({
      name: ['', Validators.required],
      address: ['', Validators.required],
      industry: ['', Validators.required],
    });

  
    this.route.paramMap.subscribe(params => {
      const idParam = params.get('id');
      this.companyId = idParam ? +idParam : 0;
      if (this.companyId > 0) {
        this.loadCompany();
      } else {
        this.isLoading = false;
      }
    });
  }

  loadCompany() {
    this.companyService.getCompanyById(this.companyId).
      subscribe({
        next: (company: AddCompany) =>
          this.editCompanyForm.patchValue(company),
        error: (err: any) => console.error(err)


      })
  }
  get editCompany_nameFormControl(): any {
    return this.editCompanyForm.controls["name"];
  }
  get editCompany_addressFormControl(): any {
    return this.editCompanyForm.controls["address"];
  }
  get editCompany_industryFormControl(): any {
    return this.editCompanyForm.controls["industry"];
  }


  updateComapny() {
    this.isFormSubmitted = true;
    if (this.editCompanyForm.valid) {
      const updatedCompany = {
        id: this.companyId,         
        ...this.editCompanyForm.value
      };

      this.companyService.updateCompany(this.companyId, updatedCompany).subscribe({
        next: () => this.router.navigate(['/Companies']),
        error: (err) => console.error(err)
      });
    }
  }
}
