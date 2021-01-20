/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Image image;
    private Ingredient ingredient2;
    public Ingredient ingredient
    {
        get{ return ingredient2; }
        set{ ingredient2 = value;
                      if(ingredient2 == null)
                {
                    image.enabled = false;
                } else
                {
                    image.sprite = ingredient2.Icon;
                    image.enabled = true;
                }
                    }
     
    }
        
    

    private void OnValidate()
    {
        if (image = null)
            image = GetComponent<image>();
    }
}
*/
