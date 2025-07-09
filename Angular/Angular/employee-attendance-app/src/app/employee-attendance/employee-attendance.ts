import { Component } from '@angular/core';
import { NgFor, NgIf, NgClass, NgStyle } from '@angular/common';
import { Employee } from './employee.model';

@Component({
  selector: 'app-employee-attendance',
  standalone: true,
  imports: [NgFor, NgIf, NgClass, NgStyle],
  templateUrl: './employee-attendance.html',
  styleUrls: ['./employee-attendance.css'],
})
export class EmployeeAttendanceComponent {
  employees: Employee[] = [
    { name: 'Alice', department: 'IT', isPresent: true, workFromHome: false },
    { name: 'Bob', department: 'Sales', isPresent: true, workFromHome: true },
    { name: 'Charlie', department: 'HR', isPresent: false, workFromHome: false }
  ];

  getDepartmentColor(dept: string): string {
    switch (dept) {
      case 'IT': return 'blue';
      case 'HR': return 'purple';
      case 'Sales': return 'orange';
      default: return 'black';
    }
  }
}
