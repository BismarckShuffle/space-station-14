﻿using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Actions;

[RegisterComponent, NetworkedComponent]
public sealed partial class WorldTargetActionComponent : BaseTargetActionComponent
{
    public override BaseActionEvent? BaseEvent => Event;

    /// <summary>
    ///     The local-event to raise when this action is performed.
    /// </summary>
    [DataField("event")]
    [NonSerialized]
    public WorldTargetActionEvent? Event;
}

[Serializable, NetSerializable]
public sealed class WorldTargetActionComponentState : BaseActionComponentState
{
    public WorldTargetActionComponentState(WorldTargetActionComponent component) : base(component)
    {
    }
}
