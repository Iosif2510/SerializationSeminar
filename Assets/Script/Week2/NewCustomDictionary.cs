using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[Serializable]
public class NewCustomDictionary<T1, T2> : ISerializationCallbackReceiver
{
    public List<T1> keys = new List<T1>();
    public List<T2> values = new List<T2>();

    private Dictionary<T1, T2> insideDictionary = new Dictionary<T1, T2>();

    public T2 this[T1 key]
    {
        get => insideDictionary[key];
        set => insideDictionary[key] = value;
    }
    
    public void OnBeforeSerialize()
    {
#if UNITY_EDITOR
        if(!EditorApplication.isPlaying
           && !EditorApplication.isUpdating
           && !EditorApplication.isCompiling) return;
#endif
        keys.Clear();
        values.Clear();
        
        foreach (var keyValuePair in insideDictionary)
        {
            keys.Add(keyValuePair.Key);
            values.Add(keyValuePair.Value);
        }
    }

    public void OnAfterDeserialize()
    {
        insideDictionary.Clear();

        for (int i = 0; i < Math.Min(keys.Count, values.Count); i++)
        {
            insideDictionary.Add(keys[i], values[i]);
        }
    }
}
