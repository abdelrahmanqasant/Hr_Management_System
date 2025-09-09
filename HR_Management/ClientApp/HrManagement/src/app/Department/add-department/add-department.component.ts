import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { DepartmentService } from '../../services/department.service';
import { CommonModule } from '@angular/common';
import { CompanyService } from '../../services/company.service';

@Component({
  selector: 'app-add-department',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './add-department.component.html',
  styleUrl: './add-department.component.css'
})
export class AddDepartmentComponent implements OnInit{
  addDepartmentForm: FormGroup;
  isAddDepartmentFormSubmitted: boolean = false;
  companies: any[] = [];
  constructor(private FB: FormBuilder, private service: DepartmentService,private company:CompanyService, private router: Router) {

    this.addDepartmentForm = FB.group({
      name: ['', Validators.required],
      description: ['', Validators.required],
      companyId: [0,Validators.required]
    });
    

  }
    ngOnInit(): void {
      this.loadCompanies();
    }
  loadCompanies() {
    this.company.getCompanies().subscribe({
      next: (data) => this.companies = data,
      error: (err: any) => {console.error(err) }
    })
  }

  get addDepartment_nameFormControl(): any {
    return this.addDepartmentForm.controls["name"];
  }
  get addDepartment_descriptionFormControl(): any {
    return this.addDepartmentForm.controls["description"];
  }
  get   addDepartment_companyIdFormControl(): any {
    return this.addDepartmentForm.controls["companyId"];
  }


  addDepartment() {
    this.isAddDepartmentFormSubmitted = true;
    if (this.addDepartmentForm.valid) {
      this.service.addDepartment(this.addDepartmentForm.value).subscribe({

        next: (data) => {
          this.router.navigate(['/departments']);
          this.isAddDepartmentFormSubmitted = false;
          this.addDepartmentForm.reset();
        },

      })
    }
  }
}
