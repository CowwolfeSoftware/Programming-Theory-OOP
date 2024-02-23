using System.Text;

// INHERITANCE
public class TeamMemberObject : TeamMember
{
    // POLYMORPHISM
    public override string GetTask()
    {
        StringBuilder desc = new();
        desc.AppendLine("Team Member (Base Class)");
        desc.AppendLine("  Race Team: " + RacingTeam);
        desc.AppendLine("TeamMember is a base class that must be inherited.  It has limited features such as Team Name and Getting member's task, i.e. 'Mechanic'.");
        desc.AppendLine();
        desc.AppendLine("TestMember is the lowest base class; everything derives from this.");

        return desc.ToString();
    }

    public override string GetTitle()
    {
        return "TeamMember";
    }
}