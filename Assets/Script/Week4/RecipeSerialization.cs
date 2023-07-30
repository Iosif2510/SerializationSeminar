using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class RecipeSerialization : MonoBehaviour
{
    public Recipe recipe;

    private void Start()
    {
        Debug.Log(JsonConvert.SerializeObject(recipe));
    }
}
