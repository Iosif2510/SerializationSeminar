using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

[Serializable]
public class MixedDrink : IAddable
{
    [Serializable]
    public class MutableKeyValuePair<TKey, TValue>
    {
        public TKey key;
        public TValue value;
    }

    public List<MutableKeyValuePair<IAddable, float>> addableList;


    public float Amount
    {
        get
        {
            float amount = 0;
            foreach (var addable in addableList)
            {
                amount += addable.value;
            }

            return amount;
        }
    }
    
    public float Density
    {
        get
        {
            float totalAmount = 0;
            float totalMass = 0;
            
            foreach (var addable in addableList)
            {
                totalAmount += addable.value;
                totalMass = addable.value * addable.key.Density;
            }

            return totalMass / totalAmount;
        }
    }
}
