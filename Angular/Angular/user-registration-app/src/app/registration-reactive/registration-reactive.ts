import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-registration-reactive',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './registration-reactive.html',
  styleUrls: ['./registration-reactive.css']
})
export class RegistrationReactiveComponent {
  form: FormGroup;
  submittedData: any = null;

  countries = ['India', 'USA', 'UK', 'Australia'];

  constructor(private fb: FormBuilder) {
    this.form = this.fb.group({
      fullName: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      gender: ['', Validators.required],
      country: ['', Validators.required],
      agree: [false, Validators.requiredTrue]
    });
  }

  onSubmit() {
    if (this.form.valid) {
      this.submittedData = this.form.value;
      this.form.reset();
    }
  }
}