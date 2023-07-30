using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public abstract class IngredientData : IAddable
{
    public string ingredientName;
    
    [JsonProperty, SerializeField] protected float density;
    
    public float Density
    {
        get => density;
        set => density = value;
    }
    
    public abstract string IngredientType { get; }
}
