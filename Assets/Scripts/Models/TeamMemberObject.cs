using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor.Search;
using UnityEngine;

public class TeamMemberObject : TeamMember
{
    public override string GetTask()
    {
        StringBuilder desc = new();
        desc.AppendLine("Team Member (Base Class)");
        desc.AppendLine();
        desc.AppendLine("TestMember is the lowest base class; everything derives from this.");

        return desc.ToString();
    }

    public override string GetTitle()
    {
        return "TeamMember";
    }
}