using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;

public class DriverObject : Driver
{
    public GameObject TeamMemberPanel;
    public GameObject DriverPanel;
    
    public override string GetTask()
    {
        StringBuilder desc = new();
        desc.AppendLine("Driver (Base Class)");
        desc.AppendLine("All driver types should derive from this class.");
        desc.AppendLine();
        desc.AppendLine("Driver is derived from TeamMember");

        return desc.ToString();
    }

    public override string GetTitle()
    {
        return "Driver";
    }

    // void OnMouseOver()
    // {
    //      ShowDriverPanel();
    // }

    // void Start()
    // {
    //     TeamMemberPanel?.SetActive(false);
    //     DriverPanel?.SetActive(false); 
    // }

    // void ShowDriverPanel()
    // {
    //     TeamMemberPanel.SetActive(false);
    //     DriverPanel.SetActive(true); 
    // }
}