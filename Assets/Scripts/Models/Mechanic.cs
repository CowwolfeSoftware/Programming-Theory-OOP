using System.Text;

public class Mechanic : TeamMember
{
    public bool EngineSpecialist;
    public bool ElectricalSpecialist;
    public bool AlignmentSpecialist;
    public bool BodySpecialist;

    public override string GetTask()
    {
        StringBuilder desc = new();
        desc.AppendLine("Mechanic:");
        desc.AppendLine("  Race Team: " + RacingTeam);
        desc.AppendLine("  Is Engine Specialist: " + EngineSpecialist);
        desc.AppendLine("  Is Electrical Specialist: " + ElectricalSpecialist);
        desc.AppendLine("  Is Alignment Specialist: " + AlignmentSpecialist);
        desc.AppendLine("  Is Body Specialist: " + BodySpecialist);
        desc.AppendLine();
        desc.AppendLine("Mechanic derives from TeamMember");

        return desc.ToString();
    }

    public override string GetTitle()
    {
        return "Mechanic";
    }
}
