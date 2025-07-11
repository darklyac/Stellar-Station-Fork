using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content.Stellar.Shared.CosmicCult;

[Serializable, NetSerializable]
public sealed partial class EventCosmicSiphonDoAfter : SimpleDoAfterEvent;

[Serializable, NetSerializable]
public sealed partial class EventCosmicBlankDoAfter : SimpleDoAfterEvent;

[Serializable, NetSerializable]
public sealed partial class EventAbsorbRiftDoAfter : SimpleDoAfterEvent;

[Serializable, NetSerializable]
public sealed partial class EventPurgeRiftDoAfter : SimpleDoAfterEvent;

[Serializable, NetSerializable]
public sealed partial class StartFinaleDoAfterEvent : SimpleDoAfterEvent;

[Serializable, NetSerializable]
public sealed partial class CancelFinaleDoAfterEvent : SimpleDoAfterEvent;

[Serializable, NetSerializable]
public sealed partial class EventCosmicFragmentationDoAfter : SimpleDoAfterEvent;

[Serializable, NetSerializable]
public sealed partial class EventCosmicColossusIngressDoAfter : SimpleDoAfterEvent;
