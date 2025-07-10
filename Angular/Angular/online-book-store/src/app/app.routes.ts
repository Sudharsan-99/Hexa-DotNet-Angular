// src/app/app.routes.ts
import { Routes } from '@angular/router';
import { Home } from './home/home/home';
import { BookListComponent } from './books/book-list/book-list';
import { BookDetailsComponent } from './books/book-details/book-details';

export const routes: Routes = [
  { path: '', component: Home },
  { path: 'books', component: BookListComponent },
  { path: 'books/:id', component: BookDetailsComponent }
];
