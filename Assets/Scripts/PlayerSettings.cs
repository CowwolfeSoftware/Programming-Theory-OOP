using System;
using System.IO;
using UnityEngine;


public class PlayerSettings : MonoBehaviour
{
    // ABSTRACTION
    [HideInInspector]
    public static PlayerSettings Instance {get; private set;}
    
    [HideInInspector]
    // ENCAPSULATION
    public string PlayerName
    {
        get { return _playerName; }
        set 
        { 
            if(value.Length > 8)
                _playerName = value[..8];
            else
                _playerName = value;
        }
    }
    private string _playerName;
    [HideInInspector]
    // ENCAPSULATION
    public string RaceTeamName
    {
        get { return _raceTeamName; }
        set 
        { 
            if(value.Length > 8)
                _raceTeamName = value[..8];
            else
                _raceTeamName = value;
        }
    }
    public string _raceTeamName;

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
