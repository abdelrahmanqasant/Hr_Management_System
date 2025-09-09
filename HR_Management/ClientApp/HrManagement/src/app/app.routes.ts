import { Routes } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { ChangepasswordComponent } from './changepassword/changepassword.component';
import { AddCompanyComponent } from './Company/add-company/add-company.component';
import { CompanyListComponent } from './Company/company-list/company-list.component';
import { AddDepartmentComponent } from './Department/add-department/add-department.component';
import { DepartmentListComponent } from './Department/department-list/department-list.component';
import { EmployeeListComponent } from './Employee/employee-list/employee-list.component';
import { AddEmployeeComponent } from './Employee/add-employee/add-employee.component';
import { EditCompanyComponent } from './Company/edit-company/edit-company.component';

import { EditDepartmentComponent } from './Department/edit-department/edit-department.component';
import { EditEmployeeComponent } from './Employee/edit-employee/edit-employee.component';
import { AuthGuard } from './services/auth-guard';
import { LeaveRequestComponent } from './Leave/leave-request/leave-request.component';



export const routes: Routes = [
  { path: 'register', component: RegisterComponent },
  { path: 'login', component: LoginComponent },
  { path: 'ChangePassword', component: ChangepasswordComponent },
  { path: 'Companies', component: CompanyListComponent ,canActivate:[AuthGuard]},
  { path: 'Companies/add', component: AddCompanyComponent, canActivate: [AuthGuard] },
  { path: 'companies/edit/:id', component: EditCompanyComponent, canActivate: [AuthGuard] },
  { path: 'departments', component: DepartmentListComponent, canActivate: [AuthGuard] },
  { path: 'departments/add', component: AddDepartmentComponent, canActivate: [AuthGuard] }, 
  { path: 'departments/edit/:id', component: EditDepartmentComponent, canActivate: [AuthGuard] }, 
  { path: 'employees', component: EmployeeListComponent, canActivate: [AuthGuard] },
  { path: 'employees/add', component: AddEmployeeComponent, canActivate: [AuthGuard] },
  { path: 'employees/edit/:id', component: EditEmployeeComponent, canActivate: [AuthGuard] },
  { path: 'leaves', component: LeaveRequestComponent, canActivate: [AuthGuard] },
  { path: '', redirectTo: '/login', pathMatch: 'full' }
];
