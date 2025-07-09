import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Student } from './student.model';

@Component({
  selector: 'app-student-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent {
  students: Student[] = [
    { name: 'Alice', marks: 85, active: true },
    { name: 'Bob', marks: 45, active: false },
    { name: 'Charlie', marks: 70, active: true },
    { name: 'Daisy', marks: 30, active: true },
  ];
}
