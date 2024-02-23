using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Driver : TeamMember
{
    [HideInInspector]
    public int MilesDriven {get; private set;}
    [HideInInspector]
    public bool CanDriveManual;
    [HideInInspector]
    public bool CanDriveAutomatic;

    public void AddMilesDriven(int miles)
    {
        MilesDriven += miles;
    }
}
