using TMPro;
using UnityEngine;

public abstract class TeamMember : MonoBehaviour
{
    public TMP_Text DescriptionText;
    public TMP_Text Title;

    [HideInInspector]
    public string RacingTeam;

    public abstract string GetTask();
    public abstract string GetTitle();

    public virtual void Awake()
    {
        RacingTeam = PlayerSettings.Instance.RaceTeamName;
    }

    public void ShowDescription()
    {
        if(DescriptionText != null)
            DescriptionText.text = GetTask();
        if(Title != null)
            Title.text = GetTitle();
    }

    void OnMouseOver()
    {
        ShowDescription();
    }


}
