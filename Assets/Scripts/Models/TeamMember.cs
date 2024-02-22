using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TeamMember : MonoBehaviour
{
    [HideInInspector]
    public string RacingTeam;

    public abstract string GetTask();
}
