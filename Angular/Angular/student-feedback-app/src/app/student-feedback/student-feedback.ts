import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { StudentFeedback } from './student-feedback.model';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-student-feedback',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: 'student-feedback.html',  
  styleUrls: ['student-feedback.css']
})
export class StudentFeedbackComponent {
  feedback: StudentFeedback = {
    studentName: '',
    courseName: '',
    rating: 1,
    comments: ''
  };

  courses: string[] = ['Angular', 'React', 'Vue', 'Node.js'];
}

