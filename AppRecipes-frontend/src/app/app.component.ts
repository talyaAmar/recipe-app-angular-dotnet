import { Component } from '@angular/core';
import { NavComponent } from '../components/nav/nav.component';
import { NavigationCancel, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,NavComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'myp';
}
