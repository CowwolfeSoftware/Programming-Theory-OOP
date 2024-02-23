using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lesson1Manager : MonoBehaviour
{
    public TMP_Text RaceTeamText;

    // Start is called once before any Update methods are called
    void Start()
    {
        RaceTeamText.text = PlayerSettings.Instance?.RaceTeamName;   
    }

    public void OnLesson2Click()
    {
        SceneManager.LoadScene(2);
    }

    public void OnMenuClick()
    {
        SceneManager.LoadScene(0);
    }
}
