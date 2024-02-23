using System.Text;

public class TestDriver : Driver
{
    // POLYMORPHISM
    public override void Awake()
    {
        CanDriveAutomatic = true;
        CanDriveManual = true;
        AddMilesDriven(800);
        base.Awake();
    }

    // POLYMORPHISM
    public override string GetTask()
    {
        StringBuilder desc = new();
        desc.AppendLine("Test Car Driver.");
        desc.AppendLine("  Race Team: " + RacingTeam);
        desc.AppendLine("  Can Drive Manual: " + CanDriveManual);
        desc.AppendLine("  Can Drive Automatic: " + CanDriveAutomatic);
        desc.AppendLine("  Miles Driven: " + MilesDriven);
        desc.AppendLine();
        desc.AppendLine("Test Car Driver derives from Driver");

        return desc.ToString();
    }

    public override string GetTitle()
    {
        return "TestDriver";
    }
}
