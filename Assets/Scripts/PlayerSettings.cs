using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerSettings : MonoBehaviour
{
    [HideInInspector]
    public static PlayerSettings Instance {get; private set;}
    
    [HideInInspector]
    public string PlayerName;

    [HideInInspector]
    public string RaceTeamName;

    // Awake is called once when object is created.
    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadSettings();
    }

    [Serializable]
    class PlayerSaveData
    {
        public string Name;
        public string RaceTeam;
    }

    public void LoadSettings()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerSaveData data = JsonUtility.FromJson<PlayerSaveData>(json);
            PlayerName = data.Name;
            RaceTeamName = data.RaceTeam;
        }
    }

    public void SaveSettings()
    {
        PlayerSaveData data = new()
        {
            Name = PlayerName,
            RaceTeam = RaceTeamName,
        };

        var json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

}
