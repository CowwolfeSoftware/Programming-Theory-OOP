using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class TeamMemberObject : TeamMember
{
    public GameObject TeamMemberPanel;
    public GameObject DriverPanel;
    public override string GetTask()
    {
        return "N/A";
    }

    void Start()
    {
        TeamMemberPanel.SetActive(false);
        DriverPanel.SetActive(false); 
    }

    void OnMouseOver()
    {
         ShowTeamMemberPanel();
    }

    void ShowTeamMemberPanel()
    {
        TeamMemberPanel.SetActive(true);
        DriverPanel.SetActive(false); 
    }
}