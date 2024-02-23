using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class RaceCarDriver : Driver
{
    [HideInInspector]
    public int RacesWon {get; private set;}
    [HideInInspector]
    public int RacesLost {get; private set;}

    [HideInInspector]
    public string DriverName 
    {
        get { return PlayerSettings.Instance.PlayerName; }
    }

    void Awake()
    {
        RacesWon = 10;
        RacesLost = 2;
        CanDriveAutomatic = true;
        CanDriveManual = false;
        AddMilesDriven(5200);
    }

    public int GetTotalRaces()
    {
        return RacesLost + RacesWon;
    }
    
    public override string GetTask()
    {
        StringBuilder desc = new();
        desc.AppendLine("Race Car Driver:");
        desc.AppendLine("  Races Won: " + RacesWon);
        desc.AppendLine("  Races Lost: " + RacesLost);
        desc.AppendLine("  Total Races: " + GetTotalRaces());
        desc.AppendLine("  Can Drive Manual: " + CanDriveManual);
        desc.AppendLine("  Can Drive Automatic: " + CanDriveAutomatic);
        desc.AppendLine("  Miles Driven: " + MilesDriven);
        desc.AppendLine("  Driver Name " + DriverName);
        desc.AppendLine();
        desc.AppendLine("Race Car Driver derives from Driver");

        return desc.ToString();
    }

    public override string GetTitle()
    {
        return "RaceCarDriver";
    }
}
