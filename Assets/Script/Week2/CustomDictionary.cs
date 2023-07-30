using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[Serializable]
public class SerializedDictionary<T1, T2> : ISerializationCallbackReceiver
{
    [SerializeField] public List<T1> keys = new List<T1>();
    [SerializeField] public List<T2> values = new List<T2>();

    private Dictionary<T1, T2> myDictionary = new Dictionary<T1, T2>();

    public T2 this[T1 key]
    {
        get => myDictionary[key];
        set => myDictionary[key] = value;
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

        foreach (var keyValuePair in myDictionary)
        {
            keys.Add(keyValuePair.Key);
            values.Add(keyValuePair.Value);
        }
    }

    public void OnAfterDeserialize()
    {
        myDictionary = new Dictionary<T1, T2>();

        for (int i = 0; i != Math.Min(keys.Count, values.Count); i++)
            myDictionary.Add(keys[i], values[i]);
    }
}
