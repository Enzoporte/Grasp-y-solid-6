//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    
    public class RecipeTimerClient : TimerClient
    {
        Recipe Recipe;
        public RecipeTimerClient(Recipe recipe)
        {
            this.Recipe = recipe;
        }
        public void TimeOut()
        {
            Recipe.Cooked = true;
        }
    }
}