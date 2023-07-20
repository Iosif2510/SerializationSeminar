using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

public class SaveManager : MonoBehaviour
{
    public Character character;

    private string saveDir;

    private void Awake()
    {
        saveDir = $"{Application.persistentDataPath}/saveFile.json";
    }

    public void Save()
    {
        SaveData saveData = new SaveData(DateTime.Now, character.name, character.hp, character.transform.position.x,
            character.transform.position.y);
        string saveJson = JsonConvert.SerializeObject(saveData);
        var file = File.CreateText(saveDir);
        file.Close();

        StreamWriter sw = new StreamWriter(saveDir);
        sw.Write(saveJson);
        sw.Flush();
        sw.Close();
        
        Debug.Log(saveJson);
    }

    public void Load()
    {
        string saveJson = File.ReadAllText(saveDir);
        SaveData saveData = JsonConvert.DeserializeObject<SaveData>(saveJson);

        character.name = saveData.characterName;
        character.hp = saveData.currentHP;
        character.transform.position = new Vector3(saveData.xPos, saveData.yPos, 0);
    }
}
