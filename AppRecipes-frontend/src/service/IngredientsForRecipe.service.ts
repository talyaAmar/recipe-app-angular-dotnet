
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { IngredientsForRecipe } from "../interface/IngredientsForRecipe.interface";

@Injectable({providedIn: "root"})

export class IngredientsForRecipeService {
url:string="https://localhost:7040/api/IngredientsForRecipe"
constructor(private http: HttpClient) { }

get(code:number):Observable<IngredientsForRecipe[]>{
  return this.http.get<IngredientsForRecipe[]>(`${this.url}/${code}`);
}
add(ingredient:{[key:number]:string},code:number):Observable<IngredientsForRecipe[]>{
  return this.http.post<IngredientsForRecipe[]>(`${this.url}/${code}`, ingredient);
}

}