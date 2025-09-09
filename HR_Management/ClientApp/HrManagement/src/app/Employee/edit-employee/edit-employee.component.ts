import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { ActivatedRoute, ActivatedRouteSnapshot, Router } from '@angular/router';

import { AddEmployee } from '../../models/Employee/add-employee';
import { EmployeeService } from '../../services/employee.service';
import { CommonModule } from '@angular/common';
import { CompanyService } from '../../services/company.service';
import { DepartmentService } from '../../services/department.service';

@Component({
  selector: 'app-edit-department',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './edit-employee.component.html',
  styleUrl: './edit-employee.component.css'
})
export class EditEmployeeComponent implements OnInit {
  editEmployeeForm!: FormGroup;
  EmployeeId!: number;
  isFormSubmitted: boolean = false;
  isLoading: boolean = true;

  companies: any[] = [];
  departments: any[] = [];
  constructor(private FB: FormBuilder,
    private employeeService: EmployeeService,
    private route: ActivatedRoute, private department: DepartmentService
    , private company: CompanyService,
    private router: Router) {
   
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
  ngOnInit(): void {
    this.loadCompanies();
  this.  loadDepartments();
    this.editEmployeeForm = this.FB.group({
      fullName: ['', Validators.required],
      title: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      address: ['', Validators.required],
      phoneNumber: ['', Validators.required],
      departmentId: [0, Validators.required],
      salary: [0, Validators.required],
      companyId: [0, Validators.required]
    });
    this.route.paramMap.subscribe(params => {
      const idParam = params.get('id');
      this.EmployeeId = idParam ? +idParam : 0;
      if (this.EmployeeId > 0) {
   
        this.loadEmployee();
      } else {
        this.isLoading = false;
      }
    });
  }

  loadEmployee() {
    this.employeeService.getEmployeeById(this.EmployeeId)
      .subscribe({
        next: (employee: AddEmployee) => this.editEmployeeForm.patchValue(employee),
        error: (err: any) => console.error(err)
      })
  }
  get editEmployee_fullNameFormControl(): any {
    return this.editEmployeeForm.controls["fullName"];
  }
  get editEmployee_titleFormControl(): any {
    return this.editEmployeeForm.controls["title"];
  }
  get editEmployee_emailFormControl(): any {
    return this.editEmployeeForm.controls["email"];
  }
  get editEmployee_addressFormControl(): any {
    return this.editEmployeeForm.controls["address"];
  }
  get editEmployee_phoneNumberFormControl(): any {
    return this.editEmployeeForm.controls["phoneNumber"];
  }
  get editEmployee_departmentIdFormControl(): any {
    return this.editEmployeeForm.controls["departmentId"];
  }
  get editEmployee_salaryFormControl(): any {
    return this.editEmployeeForm.controls["salary"];
  }
  get editEmployee_companyIdFormControl(): any {
    return this.editEmployeeForm.controls["companyId"];
  }

  updateEmployee() {
    this.isFormSubmitted = true;
    if (this.editEmployeeForm.valid) {
      const updatedEmployee = {
        id: this.EmployeeId, ...this.editEmployeeForm.value
      };
      this.employeeService.updateEmployee(this.EmployeeId, updatedEmployee).subscribe({
        next: () => this.router.navigate(['/employees']),
        error: (err) => console.error(err)
      })
    }
  }
}

