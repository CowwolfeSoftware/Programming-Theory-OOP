using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DriverObject : Driver
{
    public GameObject TeamMemberPanel;
    public GameObject DriverPanel;
    
    public override string GetTask()
    {
        return "N/A";
    }

    void OnMouseOver()
    {
         ShowDriverPanel();
    }

    void Start()
    {
        TeamMemberPanel.SetActive(false);
        DriverPanel.SetActive(false); 
    }

    void ShowDriverPanel()
    {
        TeamMemberPanel.SetActive(false);
        DriverPanel.SetActive(true); 
    }
}