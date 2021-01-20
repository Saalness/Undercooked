using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class display_ing : MonoBehaviour
{
    public Ingredient ingredient;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ingredient.name);
    }

    
}
