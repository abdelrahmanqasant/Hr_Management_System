import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { CompanyService } from '../../services/company.service';
import { CompanyList } from '../../models/Company/company-list';
import { AccountService } from '../../services/account.service';

@Component({
  selector: 'app-company-list',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterLink],
  templateUrl: './company-list.component.html',
  styleUrls: ['./company-list.component.css']
})
export class CompanyListComponent implements OnInit {

  companies: CompanyList[] = [];
  filteredCompanies: CompanyList[] = [];

  industries: string[] = [];
  selectedIndustry: string = 'All';
  searchTerm: string = '';

  isLoading: boolean = true;

  constructor(private companyService: CompanyService,public accountService:AccountService) { }

  ngOnInit(): void {
    this.loadCompanies();
  }

  loadCompanies(): void {
    this.companyService.getCompanies().subscribe({
      next: (data) => {
        this.companies = data;

        // 🟢 dynamic industries
        const uniqueIndustries = Array.from(new Set(data.map(c => c.industry)));
        this.industries = ['All', ...uniqueIndustries];

        this.applyFilters();
        this.isLoading = false;
      },
      error: (err) => {
        console.error(err);
        this.isLoading = false;
      }
    });
  }

  applyFilters(): void {
    this.filteredCompanies = this.companies.filter(company => {
      const matchesSearch = company.name.toLowerCase().includes(this.searchTerm.toLowerCase());
      const matchesIndustry = this.selectedIndustry === 'All' || company.industry === this.selectedIndustry;
      return matchesSearch && matchesIndustry;
    });
  }
}
