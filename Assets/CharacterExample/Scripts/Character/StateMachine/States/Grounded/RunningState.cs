public class RunningState : GroundedState
{
    private RunningStateConfig _config;

    public RunningState(IStateSwitcher stateSwitcher, Character character, StateMachineData data) : base(stateSwitcher, character, data)
    {
        _config = character.Config.RunningStateConfig;
    }

    public override void Enter()
    {
        base.Enter();

        View.StartRunning();
        Data.Speed = _config.Speed;
    }

    public override void Exit()
    {
        base.Exit();

        View.StopRunning();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }
}
