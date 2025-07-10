import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CommonModule } from '@angular/common';
import { Book } from '../book.model';


@Component({
  selector: 'app-book-details',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './book-details.html',
})
export class BookDetailsComponent {
  book: Book | undefined;

  private books: Book[] = [
    { id: 1, title: 'Angular Basics', author: 'John Doe', price: 399, description: 'Learn Angular from scratch.' },
    { id: 2, title: 'TypeScript Mastery', author: 'Max Programmer', price: 499, description: 'Deep dive into TypeScript and type safety...' },
    { id: 3, title: 'RxJS Deep Dive', author: 'Reactive Ninja', price: 599, description: 'Reactive programming with RxJS.' }
  ];

  constructor(private route: ActivatedRoute) {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.book = this.books.find(book => book.id === id);
  }
}

