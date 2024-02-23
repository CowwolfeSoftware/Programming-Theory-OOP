using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField raceTeamInput;

    // Start is called once before any Update methods are called
    void Start()
    {
        usernameInput.text = PlayerSettings.Instance.PlayerName;
        raceTeamInput.text = PlayerSettings.Instance.RaceTeamName;

        usernameInput.onEndEdit.AddListener(OnEndEditName);
        raceTeamInput.onEndEdit.AddListener(OnEndEditRaceTeam);

    }

    private void OnEndEditRaceTeam(string raceTeam)
    {
        PlayerSettings.Instance.RaceTeamName = raceTeam;
    }

    private void OnEndEditName(string name)
    {
        PlayerSettings.Instance.PlayerName = name;
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OnLessonQuitClick()
    {
        SceneManager.LoadScene(0);
    }

    public void OnQuitClick()
    {
        PlayerSettings.Instance.SaveSettings();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif

    }
}
