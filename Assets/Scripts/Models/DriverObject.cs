using System.Text;


public class DriverObject : Driver
{    
    public override string GetTask()
    {
        StringBuilder desc = new();
        desc.AppendLine("Driver (Base Class)");
        desc.AppendLine("  Race Team: " + RacingTeam);
        desc.AppendLine("All driver types should derive from this class.");
        desc.AppendLine("Driver is a base class that must be inherited, it is derived from TeamMember.  It has limited features and includes features from TeamMember.");
        desc.AppendLine();
        desc.AppendLine("Driver is derived from TeamMember");

        return desc.ToString();
    }

    public override string GetTitle()
    {
        return "Driver";
    }

}