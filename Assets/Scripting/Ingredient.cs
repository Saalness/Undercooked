using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Ingredient", menuName="Ingredient")]
public class Ingredient : ScriptableObject
{
    new public string name;
    public string description;

    public Sprite icon;

    public string type;
    public bool cooked;
}
