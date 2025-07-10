import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { Book } from '../book.model';

@Component({
  selector: 'app-book-list',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './book-list.html',
})
export class BookListComponent {
  books: Book[] = [
    { id: 1, title: 'Angular Basics', author: 'John Doe', price: 399, description: 'Learn Angular from scratch.' },
    { id: 2, title: 'TypeScript Mastery', author: 'Max Programmer', price: 499, description: 'Deep dive into TypeScript and type safety...' },
    { id: 3, title: 'RxJS Deep Dive', author: 'Reactive Ninja', price: 599, description: 'Reactive programming with RxJS.' }
  ];
}

