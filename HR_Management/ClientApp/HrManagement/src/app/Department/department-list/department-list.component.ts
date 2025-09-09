import { Component, OnInit } from '@angular/core';
import { DepartmentList } from '../../models/Department/department-list';
import { DepartmentService } from '../../services/department.service';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { AccountService } from '../../services/account.service';

@Component({
  selector: 'app-department-list',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterLink],
  templateUrl: './department-list.component.html',
  styleUrl: './department-list.component.css'
})
export class DepartmentListComponent implements OnInit{
  departments: DepartmentList[] = [];
  filteredDepartments: DepartmentList[] = [];
  searchTerm: string = '';
  isLoading: boolean = true;


  constructor(private service: DepartmentService,public accountService:AccountService) { }
    ngOnInit(): void {
      this.loadDepartments();
    }

  loadDepartments(): void {
    this.service.getDepartments().subscribe({

      next: (data) => {

        this.departments = data;
        this.applyFilters();
        this.isLoading = false;
      },
      error: (err: any) => {console.error(err) }
    })
  }

  applyFilters(): void {
    this.filteredDepartments = this.departments.filter(department => {
      const matchesSearch = department.name.toLowerCase().includes(this.searchTerm.toLowerCase());
      return matchesSearch;
    })

  }
}
