using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lesson2Manager : MonoBehaviour
{
    public TMP_Text RaceTeamText;

    // Start is called once before any Update methods are called
    void Start()
    {
        RaceTeamText.text = PlayerSettings.Instance?.RaceTeamName;   
    }

    public void OnLesson1Click()
    {
        SceneManager.LoadScene(1);
    }

    public void OnMenuClick()
    {
        SceneManager.LoadScene(0);
    }
}
