import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map, Observable } from "rxjs";

@Injectable({providedIn: "root"})

export class ImageService {

    url:string="https://localhost:7040/api/Images/image";
    constructor(private http: HttpClient) { }
    
    add(img: File): Observable<string> {
        const formData = new FormData();
        formData.append("file", img); 
    
        return this.http.post<{ imageUrl: string }>(this.url, formData).pipe(
          map(response => response.imageUrl) 
        );
      }
}