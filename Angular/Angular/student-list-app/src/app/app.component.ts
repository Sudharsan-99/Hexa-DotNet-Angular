import { Component } from '@angular/core';
import { StudentListComponent } from './student-list/student-list.component'; // note the ".component"

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [StudentListComponent],
  template: `<app-student-list></app-student-list>`,
})
export class AppComponent {}
