using System.Collections;
using System.Collections.Generic;

public class Mechanic : TeamMember
{
    public bool EngineSpecialist;

    public bool ElectricalSpecialist;
    public bool AlignmentSpecialist;
    public bool BodySpecialist;

    public override string GetTask()
    {
        return "Mechanic: ";
    }
}
