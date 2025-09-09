import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';
import { EmployeeList } from '../../models/Employee/employee-list';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { EmployeesInCompany } from '../../models/Employee/EmployeesInCompany';
import { CompanyList } from '../../models/Company/company-list';
import { CompanyService } from '../../services/company.service';
import { AccountService } from '../../services/account.service';

@Component({
  selector: 'app-employee-list',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterLink],
  templateUrl: './employee-list.component.html',
  styleUrl: './employee-list.component.css'
})
export class EmployeeListComponent implements OnInit {
  employees: EmployeeList[] = [];
  employeesInCompany: EmployeesInCompany[] = [];
  filteredEmployee: any[] = [];
  companies: CompanyList[] = [];
  searchTerm: string = '';
  selectedCompanyId: number | null = null;
  isLoading: boolean = true;

  constructor(private service: EmployeeService, public companyService: CompanyService,
    public accountService: AccountService) { }

  ngOnInit(): void {
    this.loadCompanies();
    this.getEmployees();
  }
  loadCompanies() {
    this.companyService.getCompanies().subscribe({
      next: (data) => this.companies = data,
      error: (err: any) => console.error(err)
    })
  }
  getEmployees(): void {
    this.service.getEmployees().subscribe({
      next: (data) => {
        this.employees = data;
        this.filteredEmployee = data;   
        this.isLoading = false;
      },
      error: (err) => console.error(err)
    });
  }


  loadEmployeesByCompany(): void {
    if (!this.selectedCompanyId) {
      this.filteredEmployee = this.employees;  
      return;
    }

    this.service.getEmployeesByCompany (this.selectedCompanyId)
      .subscribe({
        next: (data) => {
          this.employeesInCompany = data;
          this.filteredEmployee = data;   
        },
        error: (err) => console.error(err)
      });
  }

  applyFilters(): void {
    const source = this.selectedCompanyId ? this.employeesInCompany : this.employees;
    this.filteredEmployee = source.filter(emp =>
      emp.fullName.toLowerCase().includes(this.searchTerm.toLowerCase())
    );
  }
}
