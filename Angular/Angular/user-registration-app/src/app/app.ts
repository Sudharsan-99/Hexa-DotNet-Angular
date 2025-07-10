import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterModule],
  template: `
    <nav>
      <a routerLink="/template">Template Form</a> |
      <a routerLink="/reactive">Reactive Form</a>
    </nav>
    <router-outlet></router-outlet>
  `
})
export class AppComponent {}
