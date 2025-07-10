import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, NgForm } from '@angular/forms';
import { UserRegistration } from '../models/user-registration.model';

@Component({
  selector: 'app-registration-template',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './registration-template.html',
  styleUrls: ['./registration-template.css']
})
export class RegistrationTemplateComponent {
  user: UserRegistration = {
    fullName: '',
    email: '',
    gender: '',
    country: '',
    agree: false
  };

  submittedUser: UserRegistration | null = null;
  submitted = false; // 👈 this was missing

  countries = ['India', 'USA', 'UK', 'Australia'];

  submitForm(form: NgForm) {
    if (form.valid) {
      this.submittedUser = { ...this.user };
      this.submitted = true;
      form.resetForm(); // optional
    }
  }
}
