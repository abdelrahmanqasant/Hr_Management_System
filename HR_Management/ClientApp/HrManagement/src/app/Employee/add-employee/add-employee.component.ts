import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { EmployeeService } from '../../services/employee.service';
import { CommonModule } from '@angular/common';
import { DepartmentService } from '../../services/department.service';
import { CompanyService } from '../../services/company.service';

@Component({
  selector: 'app-add-employee',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './add-employee.component.html',
  styleUrl: './add-employee.component.css'
})
export class AddEmployeeComponent implements OnInit{
  addEmployeeForm: FormGroup;
  isAddEmployeeFormSubmitted: boolean = false;
  companies: any[] = [];
  departments: any[] = [];
  constructor(private FB: FormBuilder,
    private service: EmployeeService,
    private department: DepartmentService
    ,private company :CompanyService , private router: Router) {
    this.addEmployeeForm = FB.group({
      fullName: ['',Validators.required],
      title: ['',Validators.required],
      email: ['',[Validators.required , Validators.email]] ,
      address: ['',Validators.required],
      phoneNumber: ['',Validators.required] ,
      departmentId: [0, Validators.required],
      salary: [0, Validators.required],
      companyId : [0,Validators.required]
    })

  }
    ngOnInit(): void {
      this.loadCompanies();
      this.loadDepartments();
    }


  loadDepartments(): void {
    this.department.getDepartments().subscribe({

      next: (data) => 

        this.departments = data,
             
      error: (err: any) => { console.error(err) }
    })
  }

  loadCompanies(): void {
    this.company.getCompanies().subscribe({
      next: (data) => 
        this.companies = data,

       
      
      error: (err) => {
        console.error(err);
       
      }
    });
  }
  get addEmployee_fullNameFormControl(): any {
    return this.addEmployeeForm.controls["fullName"];
  }
  get addEmployee_titleFormControl(): any {
    return this.addEmployeeForm.controls["title"];
  }
  get addEmployee_emailFormControl(): any {
    return this.addEmployeeForm.controls["email"];
  }
  get addEmployee_addressFormControl(): any {
    return this.addEmployeeForm.controls["address"];
  }
  get addEmployee_phoneNumberFormControl(): any {
    return this.addEmployeeForm.controls["phoneNumber"];
  }
  get addEmployee_departmentIdFormControl(): any {
    return this.addEmployeeForm.controls["departmentId"];
  }
  get addEmployee_salaryFormControl(): any {
    return this.addEmployeeForm.controls["salary"];
  }
  get addEmployee_companyIdFormControl(): any {
    return this.addEmployeeForm.controls["companyId"];
  }

  addEmployee() {
    this.isAddEmployeeFormSubmitted = true;
    if (this.addEmployeeForm.valid) {
      this.service.addEmployee(this.addEmployeeForm.value).subscribe({
        next: (data) => {
          this.router.navigate(['/employees']);
          this.isAddEmployeeFormSubmitted = false;
          this.addEmployeeForm.reset();
        }

      })
    }
  }
 
}
