using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField username;

    // Start is called once before any Update methods are called
    void Start()
    {
        
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OnLesson2Click()
    {
        SceneManager.LoadScene(2);
    }

    public void OnLessonQuitClick()
    {
        SceneManager.LoadScene(0);
    }

    public void OnQuitClick()
    {
        // TODO: Add Unity Player Quit
        Application.Quit();
    }
}
