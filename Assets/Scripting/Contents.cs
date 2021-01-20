/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;



public class Contents : MonoBehaviour, ICombo
{
   // public ItemSlot[] itemSlots;
    [FormerlySerializedAs("items")]
    [SerializeField] List<Ingredient> startingItems;
    [SerializeField] Transform itemsParent;
    [SerializeField] ItemSlot[] itemSlot;

    public ItemSlot[] ItemSlot { get => itemSlot; set => itemSlot = value; }

    // Start is called before the first frame update
    private void Start()
    {
        for(int i = 0; i <itemSlot.Length;i++)
        {

        }
    }

    // Update is called once per frame
    private void onValidate()
    {
        if (itemsParent != null)
            itemSlot = itemsParent.GetComponentsInChildren<itemSlots>();

        
    }

    public bool AddIng(Ingredient ingredient)
    {
        for(int i=0;i < itemSlot.Length; i++)
        {
            if(itemSlot[i].Ingredient == null)
            {
                itemSlot[i].Ingredient = ingredient;
                return true;
            }
        }
        return false;
    }

    public bool RemoveIng(Ingredient ingredient)
    {
        for (int i = 0; i < itemSlot.Length; i++)
        {
            if (itemSlot[i].Ingredient == ingredient)
            {
                itemSlot[i].Ingredient = null;
                return true;
            }
        }
        return false;
    }

    public bool IsFull()
    {
        for(int i = 0; i< itemSlot.Length; i++)
        {
            if(itemSlot[i].Ingredient == null)
            {
                return false;
            }
        }
        return true;
    }

    public bool ContainsIng(Ingredient ingredient)
    {
        for (int i = 0; i < itemSlot.Length; i++)
        {
            if (itemSlot[i].Ingredient == ingredient)
            {
                return true;
            }
        }
        return false;
    }

    public int IngCount(Ingredient ingredient)
    {
        int num = 0;
        for (int i = 0; i < itemSlot.Length; i++)
        {
            if (itemSlot[i].Ingredient == ingredient)
            {
                num++;
            }
        }
        return num;
    }
}
*/
