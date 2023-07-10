using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Matrix4x4 = UnityEngine.Matrix4x4;

public class TestScript : MonoBehaviour
{
    public enum EnumType
    {
        Enum1,
        Enum2,
        Enum3
    }
    
    public int intValue;
    public string strValue;
    private int _intValue2;

    [SerializeField] private List<int> intList;
    [SerializeField] private EnumType enumValue;

    [SerializeField] private Color color1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // // Update is called once per frame
    // void Update()
    // {
    //     
    // }
}
