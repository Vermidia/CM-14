
namespace Content.Server._RMC14.Abilities;

[RegisterComponent]
public sealed partial class ApplyStatusToAreaOnActivateComponent : Component
{
    [DataField]
    public string Key = default!;

    [DataField]
    public string Component = String.Empty;

    [DataField]
    public float Time = 1.0f; //In Seconds

    [DataField]
    public float Range = 1;
}
