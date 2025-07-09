import { Component } from '@angular/core';
import { EmployeeAttendanceComponent } from './employee-attendance/employee-attendance';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [EmployeeAttendanceComponent],
  template: `<app-employee-attendance></app-employee-attendance>`,
})
export class AppComponent {}
