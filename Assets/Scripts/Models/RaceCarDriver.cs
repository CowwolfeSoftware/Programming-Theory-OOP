using System.Collections;
using System.Collections.Generic;
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

    public int GetTotalRaces()
    {
        return RacesLost + RacesWon;
    }
    
    public override string GetTask()
    {
        return "Race Car Driver";
    }
}
