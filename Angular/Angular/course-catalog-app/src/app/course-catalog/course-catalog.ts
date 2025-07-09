import { Component } from '@angular/core';
import { NgFor, NgIf, UpperCasePipe, LowerCasePipe, DatePipe, CurrencyPipe, SlicePipe } from '@angular/common';
import { Course } from './course.model';

@Component({
  selector: 'app-course-catalog',
  standalone: true,
  imports: [
    NgFor,
    NgIf,
    UpperCasePipe,
    LowerCasePipe,
    DatePipe,
    CurrencyPipe,
    SlicePipe
  ],
  templateUrl: './course-catalog.html',
  styleUrls: ['./course-catalog.css']
})
export class CourseCatalogComponent {
  courses: Course[] = [
    {
      id: 1,
      title: 'Angular for Beginners',
      instructor: 'John Doe',
      startDate: new Date('2025-08-01'),
      price: 149.99,
      description: 'A beginner-friendly introduction to Angular framework and its ecosystem.'
    },
    {
      id: 2,
      title: 'Advanced TypeScript',
      instructor: 'Jane Smith',
      startDate: new Date('2025-09-15'),
      price: 199.99,
      description: 'Dive deep into TypeScript features, including generics, decorators, and more.'
    }
  ];
}
