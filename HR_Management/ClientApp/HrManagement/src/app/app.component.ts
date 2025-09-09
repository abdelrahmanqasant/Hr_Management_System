
import { HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';
import { AccountService } from './services/account.service';
import { Router } from '@angular/router';

import { MatCardModule } from '@angular/material/card';
import { MatTableModule } from '@angular/material/table';
import { MatIconModule } from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatChipsModule } from '@angular/material/chips';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ReactiveFormsModule, RouterOutlet, RouterLink, RouterLinkActive, CommonModule, FormsModule, HttpClientModule],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'HrManagement';
  isLoggedIn :boolean= false;
  constructor(public accountService: AccountService,private router:Router ) {

  }
  onLogOutClicked() {
    this.accountService.getLogout().subscribe({
      next: (resopnse: string) => {
        this.accountService.currentUserName = null;
        localStorage.removeItem("token");
        localStorage.removeItem("refreshToken");
        this.router.navigate(['/login']);
      },
      error: () => { },
      complete: () => { }
    })
  }
}
