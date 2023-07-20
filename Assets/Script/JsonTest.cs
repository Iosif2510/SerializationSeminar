using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using System.IO;

public class JsonTest : MonoBehaviour
{
    private JsonSerializerSettings jsonSetting = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
    
    private CustomClass customClass = new CustomClass(3, "Hello", 5);
    private CustomDerivedClass childClass = new CustomDerivedClass(3, "Hello", 5, 2);
    
    // Start is called before the first frame update
    void Start()
    {
        string jsonText = JsonConvert.SerializeObject(customClass, jsonSetting);
        Debug.Log(jsonText);

        CustomClass newClass = childClass;
        string derivedJson = JsonConvert.SerializeObject(newClass, jsonSetting);
        Debug.Log(derivedJson);

        string dir = $"{Application.streamingAssetsPath}/newfile.json";
        var file = File.CreateText(dir);
        file.Close();
        StreamWriter sw = new StreamWriter(dir);
        sw.Write(derivedJson);
        sw.Flush();
        sw.Close();

        CustomClass loadedClass = JsonConvert.DeserializeObject<CustomDerivedClass>(derivedJson, jsonSetting);
        Debug.Log($"{loadedClass.value1}, {loadedClass.value2}, {(loadedClass as CustomDerivedClass)?.childValue}");
    }
    
}
