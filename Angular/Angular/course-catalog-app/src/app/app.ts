import { Component } from '@angular/core';
import { CourseCatalogComponent } from './course-catalog/course-catalog';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CourseCatalogComponent],
  template: `<app-course-catalog></app-course-catalog>`
})
export class AppComponent {}
