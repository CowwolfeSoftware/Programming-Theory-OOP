using System.Text;
using UnityEngine;

// INHERITANCE
public class RaceCarDriver : Driver
{
    // ABSTRACTION
    [HideInInspector]
    public int RacesWon {get; private set;}
    // ABSTRACTION
    [HideInInspector]
    public int RacesLost {get; private set;}

    // ABSTRACTION
    [HideInInspector]
    public string DriverName 
    {
        get { return PlayerSettings.Instance.PlayerName; }
    }

    // POLYMORPHISM
    public override void Awake()
    {
        RacesWon = 10;
        RacesLost = 2;
        CanDriveAutomatic = true;
        CanDriveManual = false;
        AddMilesDriven(5200);
        base.Awake();
    }

    public int GetTotalRaces()
    {
        return RacesLost + RacesWon;
    }
    
    // POLYMORPHISM
    public override string GetTask()
    {
        StringBuilder desc = new();
        desc.AppendLine("Race Car Driver:");
        desc.AppendLine("  Race Team: " + RacingTeam);
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
