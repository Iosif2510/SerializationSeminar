using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class JsonTestScript : MonoBehaviour
{
    private CustomNew newObject = new CustomNew(3, "Hello", 4, 5);
    private CustomDerived newChild = new CustomDerived(1, "World", 2, 3, true);

    private List<CustomNew> newList = new List<CustomNew>();
    private List<string> jsonList = new List<string>();

    // private JsonSerializerSettings jsonSettingAll = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
    private JsonSerializerSettings jsonSettingAuto = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
    
    // Start is called before the first frame update
    void Start()
    {
        jsonSettingAuto.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
        
        AddList();

        // foreach (var obj in newList)
        // {
        //     string str = JsonConvert.SerializeObject(obj);
        //     Debug.Log(str);
        //     jsonList.Add(str);
        // }
        
        // string newJsonList = JsonConvert.SerializeObject(newList, jsonSettingAll);
        string listJson = JsonConvert.SerializeObject(newList, jsonSettingAuto);
        // Debug.Log(newJsonList);
        Debug.Log(listJson);

        List<CustomNew> deserializedList = JsonConvert.DeserializeObject<List<CustomNew>>(listJson, jsonSettingAuto);
        //
        // Debug.Log((deserializedList[0] as CustomDerived)?.childValue);
        foreach (var obj in deserializedList)
        {
            Debug.Log(obj.PrintObject());
        }

        // string jsonText = JsonConvert.SerializeObject(newObject);
        // Debug.Log(jsonText);
        //
        // string childText = JsonConvert.SerializeObject(newChild);
        // Debug.Log(childText);
        //
        // CustomNew testObject = newChild;
        // childText = JsonConvert.SerializeObject(testObject);
        // Debug.Log(childText);

        // CustomNew otherObject = JsonConvert.DeserializeObject<CustomNew>(jsonText);
        // Debug.Log(otherObject.PrintObject());
    }

    private void AddList()
    {
        CustomDerived newChild1 = new CustomDerived(1, "World", 2, 3, true);
        CustomDerived2 newChild2 = new CustomDerived2(7, "Bye", 8, 9, "Second");
        CustomNew newObject3 = new CustomNew(3, "Hello", 4, 5);
        
        newList.Add(newChild1);
        newList.Add(newChild2);
        newList.Add(newObject3);
    }
}
