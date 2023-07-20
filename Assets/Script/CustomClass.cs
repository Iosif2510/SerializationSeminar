using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using OpenCover.Framework.Model;
using UnityEngine;

[Serializable]
public class CustomClass
{
    public int value1;
    [JsonIgnore] public string value2;
    [JsonProperty] protected int privateValue;

    public CustomClass(int value1, string value2, int privateValue)
    {
        this.value1 = value1;
        this.value2 = value2;
        this.privateValue = privateValue;
    }

    public virtual void Method()
    {
        Debug.Log("Hello!");
    }
}

[Serializable]
public class CustomDerivedClass : CustomClass
{
    [JsonProperty] public int childValue;
    public CustomDerivedClass(int value1, string value2, int privateValue, int childValue) : base(value1, value2, privateValue)
    {
        this.childValue = childValue;
    }
    
    public override void Method()
    {
        Debug.Log("Hi!");
    }
}

[Serializable]
public class CustomGenericClass<T>
{
    public T insideValue;

    public int intValue;
}
