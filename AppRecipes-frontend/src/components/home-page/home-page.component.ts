import { Component } from '@angular/core';
import { UserService } from '../../service/User.service';
import { RecipeService } from '../../service/Recipe.service';
import { Recipe } from '../../interface/Recipe.interface';
import { DeferBlockBehavior } from '@angular/core/testing';
import { Router, RouterLink } from '@angular/router';
import { UppercaseRecipePipe } from '../../app/pipes/uppercase-recipe.pipe';

@Component({
  selector: 'app-home-page',
  imports: [RouterLink,UppercaseRecipePipe],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.css'
})
export class HomePageComponent {
constructor(private recipeService:RecipeService,private router:Router){
}
recipe:Recipe[]=[]
ngOnInit(){
  this.recipeService.GetAll().subscribe({
    next:(recipe:Recipe[])=>{
      this.recipe=recipe;
      console.log(this.recipe);
    },
    error:(err)=>{
      console.error('שגיאה',err)
    }
  })
}


}
