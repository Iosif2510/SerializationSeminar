using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class VectorSerialization : MonoBehaviour
{
    public Vector3 newVector;

    private JsonSerializerSettings _settings;

    private CustomClass _customClass;
    private CustomDerivedClass _customDerived;

    private List<CustomClass> _customList;
    
    private void Start()
    {
        _settings = new JsonSerializerSettings();
        _settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        _settings.TypeNameHandling = TypeNameHandling.Auto;
        
        // Debug.Log(JsonConvert.SerializeObject(newVector, _settings));

        _customList = new List<CustomClass>();
        _customList.Add(new CustomDerivedClass(1, "Hello", 3, 4));

        string serialized = JsonConvert.SerializeObject(_customList);
        Debug.Log(serialized);
            
        _customList = JsonConvert.DeserializeObject<List<CustomClass>>(serialized);
        _customList[0].Method();
    }
}
