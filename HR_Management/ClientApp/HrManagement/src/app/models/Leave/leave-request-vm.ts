export type LeaveRequestStatus = 'Pending' | 'Approved' | 'Rejected';
export class LeaveRequestVM {
  id: number = 0;
  employeeId: number = 0;
  leaveTypeId: number = 0;
  startDate: string | null = null;
  endDate: string | null = null;
  reason: string | null = null;
  status: LeaveRequestStatus = 'Pending';
  employeeName: string | null = null;
  leaveTypeName: string | null = null;
  createdAt:string|null=null

}
