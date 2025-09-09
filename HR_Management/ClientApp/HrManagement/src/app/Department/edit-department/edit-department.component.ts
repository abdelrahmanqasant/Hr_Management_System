import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { ActivatedRoute, ActivatedRouteSnapshot, Router } from '@angular/router';
import { DepartmentService } from '../../services/department.service';
import { AddDepartment } from '../../models/Department/add-department';
import { CompanyService } from '../../services/company.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-edit-department',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './edit-department.component.html',
  styleUrl: './edit-department.component.css'
})
export class EditDepartmentComponent implements OnInit{
  editDepartmentForm!: FormGroup;
  departmentId!: number;
  isFormSubmitted: boolean = false;
  isLoading: boolean = true;
  companies: any[] = [];
  constructor(private FB: FormBuilder,private companyService :CompanyService, private departmentService: DepartmentService, private route: ActivatedRoute,
    private router: Router) {

    }
  ngOnInit(): void {
    this.loadCompanies();
    this.editDepartmentForm = this.FB.group({
      name: ['', Validators.required],
      description: ['', Validators.required],
      companyId: [0, Validators.required]
    });
    this.route.paramMap.subscribe(params => {
      const idParam = params.get('id');
      this.departmentId = idParam ? +idParam : 0;
      if (this.departmentId > 0) {
        this.loadDepartment();
      } else {
        this.isLoading = false;
      }
    });
  }
  loadCompanies() {
    this.companyService.getCompanies().subscribe({
      next: (data) => this.companies = data,
      error: (err: any) => { console.error(err) }
    })
  }
  get editDepartment_nameFormControl(): any {
    return this.editDepartmentForm.controls["name"];
  }
  get editDepartment_descriptionFormControl(): any {
    return this.editDepartmentForm.controls["description"];
  }
  get editDepartment_companyIdFormControl(): any {
    return this.editDepartmentForm.controls["companyId"];
  }

  loadDepartment() {
    this.departmentService.getDepartmentById(this.departmentId)
      .subscribe({
        next: (department: AddDepartment) => this.editDepartmentForm.patchValue(department),
        error: (err: any) => console.error(err)
      })
  }
  updateDepartment() {
    this.isFormSubmitted = true;
    if (this.editDepartmentForm.valid) {
      const updatedDepartment = {
        id: this.departmentId, ...this.editDepartmentForm.value
      };
      this.departmentService.updateDepartment(this.departmentId, updatedDepartment).subscribe({
        next: () => this.router.navigate(['/departments']),
        error: (err) => console.error(err)
      })
    }
  }
}
