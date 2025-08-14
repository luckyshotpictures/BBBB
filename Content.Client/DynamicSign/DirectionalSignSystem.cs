using Robust.Shared.GameStates;
using Robust.Shared.GameObjects;
using Content.Shared.Signs;
using Content.Shared.UserInterface;
using Robust.Shared.Log;
using Robust.Shared.Player;
using System.Linq;

namespace Content.Server.Signs;

public sealed class DirectionalSignDynamicSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<DirectionalSignComponent, ComponentInit>(OnInit);
        SubscribeLocalEvent<DirectionalSignComponent, DirectionalSignSetMessage>(OnSignUpdate);
        //Log for successfully updating the sign
        SubscribeLocalEvent<DirectionalSignComponent, DirectionalSignOpenUiEvent>(OnUiOpened);
        // Log for UI open event
        SubscribeLocalEvent<DirectionalSignComponent, DirectionalSignAttemptSetMessage>(OnAttemptSetMessage);
        // Log for attempted sign change
    }
    private void OnInit(EntityUid uid, DirectionalSignComponent component, ComponentInit args)
    {

    }
