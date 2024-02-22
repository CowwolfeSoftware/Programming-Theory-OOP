using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerSettings : MonoBehaviour
{
    [HideInInspector]
    public static PlayerSettings Instance {get; private set;}
    
    [HideInInspector]
    public string PlayerName;

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

    class PlayerSaveData
    {
        public string Name {get; set;}
    }
    public void LoadSettings()
    {
        PlayerSaveData data = new();

        PlayerName = data.Name;
    }

    public void SaveSettings()
    {

    }

}
