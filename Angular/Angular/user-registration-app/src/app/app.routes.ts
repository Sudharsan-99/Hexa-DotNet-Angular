import { Routes } from '@angular/router';
import { RegistrationTemplateComponent } from './registration-template/registration-template';
import { RegistrationReactiveComponent } from './registration-reactive/registration-reactive';

export const routes: Routes = [
  { path: '', redirectTo: 'template', pathMatch: 'full' },
  { path: 'template', component: RegistrationTemplateComponent },
  { path: 'reactive', component: RegistrationReactiveComponent },
];
