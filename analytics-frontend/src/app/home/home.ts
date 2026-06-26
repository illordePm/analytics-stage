import { Component } from '@angular/core';
import { PowerBIEmbedModule } from 'powerbi-client-angular'; 
import { models } from 'powerbi-client';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [PowerBIEmbedModule],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {
  reportConfig = {
    type: 'dashboard',
    id: 'a6e50990-b9ef-4441-b8d8-d4cccd2d8736',
    // Per il TokenType.Aad l'embedUrl richiede anche l'indicazione del groupId (es: 'me')
    embedUrl: 'https://app.powerbi.com/dashboardEmbed?dashboardId=a6e50990-b9ef-4441-b8d8-d4cccd2d8736&groupId=me', 
    accessToken: undefined,
    tokenType: models.TokenType.Aad, // <--- FONDAMENTALE: Cambiato in Aad
    hostname: 'https://app.powerbi.com'
  };
}