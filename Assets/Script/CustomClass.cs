using System;
using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using UnityEngine;

[Serializable]
public class CustomClass
{
    public int value1;
    public string value2;

    public virtual void Method()
    {
        Debug.Log("Hello!");
    }
}

[Serializable]
public class CustomDerivedClass : CustomClass
{
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
