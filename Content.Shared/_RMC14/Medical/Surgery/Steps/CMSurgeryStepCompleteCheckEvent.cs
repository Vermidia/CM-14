﻿namespace Content.Shared._RMC14.Medical.Surgery.Steps;

[ByRefEvent]
public record struct CMSurgeryStepCompleteCheckEvent(EntityUid Body, EntityUid Part, bool Cancelled = false);
