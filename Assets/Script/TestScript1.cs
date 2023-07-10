using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript1 : MonoBehaviour
{
    public int testValue;
    protected int testValue2;
    [SerializeField] private int testValue1;

    public float floatValue;
    public string stringValue;
    public double doubleValue;
    public bool boolValue;

    private int currentState = 2;

    public Vector2 vector2;
    public Vector3 vector3value;
    public Vector4 vector4;
    public Rect rect;
    public Matrix4x4 matrix;
    public Color color;
    public AnimationCurve animationCurve;

    public GameObject gameObjectValue;
    public Camera transformValue;

    public Vector2[] vectorArray;
    public List<bool> boolList;

    public Dictionary<int, bool> table;

    public SerializedDictionary<int, string> newTable;

    [Flags]
    private enum StateEnum
    {
        Default = 0,
        Moving = 1,
        Jump = 2,
        Attack = 4
    }

    [SerializeField] private StateEnum currentStateEnum;

    public List<CustomClass> customClassList  = new List<CustomClass>();
    
    public CustomClass customClass;

    public CustomGenericClass<string> customGeneric;

    // Start is called before the first frame update
    void Start()
    {
        // customClassList.Add(new CustomDerivedClass());
        // customClassList[0].Method();
        newTable[2] = "Bye";
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) PrintTable();
    }

    private void PrintTable()
    {
        foreach (var key in newTable.keys)
        {
            Debug.Log(newTable[key]);
        }
    }
}
