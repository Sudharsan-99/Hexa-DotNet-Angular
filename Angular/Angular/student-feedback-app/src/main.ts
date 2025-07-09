import { bootstrapApplication } from '@angular/platform-browser';
import { StudentFeedbackComponent } from './app/student-feedback/student-feedback';
import { provideAnimations } from '@angular/platform-browser/animations';

bootstrapApplication(StudentFeedbackComponent, {
  providers: [provideAnimations()]
});
