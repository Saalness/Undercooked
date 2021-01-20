

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Recipe", menuName = "Recipe")]
public class Recipe : ScriptableObject
{
    public List<Ingredient> Ingredients;
    public List<Ingredient> Dish;
}
    /*
    public bool CanCook(ICombo combo)
    {
        
            if(combo.IngCount() < Amount)
            {
                return false;
            }
        return true;
    }
    public void Cook(ICombo combo)
    {
        if(CanCook(combo))
        {
            
                for (int i=0; i < Amount; i++)
                {
                    combo.RemoveIng(Ingredient);
                }
           
            
                for(int i = 0; i <Amount; i++)
                {
                    combo.AddIng(Ingredient);
                }
            

            
        }
    }

   
}
*/


