using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public enum CustomEnum
{
    Zero,
    One,
    Two
}

public class CustomNew
{
    public int intValue1;
    public string stringValue1;
    [JsonProperty("protectedValue")] protected int intValue2;
    [JsonProperty] protected int intValue3;

    public CustomEnum customEnum = CustomEnum.Two;

    public CustomNew(int v1, string s1, int v2, int v3)
    {
        intValue1 = v1;
        stringValue1 = s1;
        intValue2 = v2;
        intValue3 = v3;
    }

    public virtual string PrintObject()
    {
        return $"intValue1: {intValue1}, stringValue1: {stringValue1}, intValue2: {intValue2}, intValue3: {intValue3}, customEnum: {customEnum}";
    }
}

public class CustomDerived : CustomNew
{
    public bool childValue;

    public CustomDerived(int v1, string s1, int v2, int v3, bool b1) : base(v1, s1, v2, v3)
    {
        childValue = b1;
    }

    public override string PrintObject()
    {
        return $"intValue1: {intValue1}, stringValue1: {stringValue1}, intValue2: {intValue2}, intValue3: {intValue3}, childValue: {childValue}, customEnum: {customEnum}";
    }
}

public class CustomDerived2 : CustomNew
{
    public string childValue;

    public CustomDerived2(int v1, string s1, int v2, int v3, string s2) : base(v1, s1, v2, v3)
    {
        childValue = s2;
    }
    
    public override string PrintObject()
    {
        return $"intValue1: {intValue1}, stringValue1: {stringValue1}, intValue2: {intValue2}, intValue3: {intValue3}, childValue: {childValue}, customEnum: {customEnum}";
    }
}
