import { Component, OnInit } from '@angular/core';
import { LeaveRequestVM } from '../../models/Leave/leave-request-vm';
import { LeaveService } from '../../services/leave.service';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-leave-request',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterLink],
  templateUrl: './leave-request.component.html',
  styleUrl: './leave-request.component.css'
})
export class LeaveRequestComponent implements OnInit{
  leaves: LeaveRequestVM[] = [];
  constructor(private leaveService: LeaveService) { }
  loadLeaves() {
    this.leaveService.getRequests().subscribe({
      next: (data => {
        this.leaves = data;
      }),
      error: (err: any) => {console.error(err) }
    })
  }
  deleteLeave(id: number) {
    if (confirm("Are You Sure That You Want To Delete This Leave?")) {
      this.leaveService.deleteRequest(id).subscribe(()=>this.loadLeaves())
    }
  }
  changeStatus(id: number, status: string) {
    this.leaveService.updateStatus(id, status as any).subscribe(
      () =>this.loadLeaves()
    )
  }

  
  ngOnInit(): void {
    this.loadLeaves();
    }

}
