import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterOutlet, RouterLink } from '@angular/router';
import { MatSidenavModule } from '@angular/material/sidenav';
import {MatButtonModule} from '@angular/material/button';
import { models } from 'powerbi-client';
import { PowerBIEmbedModule } from 'powerbi-client-angular';
import { RouterModule } from '@angular/router';
import { MatCardModule } from '@angular/material/card';
import { MatIcon, MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-root',
  imports: 
  [ 
    CommonModule, 
    RouterOutlet, 
    RouterLink, 
    MatSidenavModule,
    MatButtonModule,
    MatCardModule,
    MatIconModule,
    MatIcon,
    PowerBIEmbedModule,
    RouterModule
  ], 
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  showFiller = false;
}