import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core"; 
import { Observable } from "rxjs"
import { Ingredients } from "../interface/Ingredients.interface";


@Injectable ({providedIn: 'root'})

export class IngredientsService{
url:string="https://localhost:7040/api/Ingredients"


constructor(private http:HttpClient){}

get():Observable<Ingredients[]>{
   return this.http.get<Ingredients[]>(this.url);
}

post(ingredients:Ingredients):Observable<Ingredients>{
return this.http.post<Ingredients>(this.url,ingredients);
}

}