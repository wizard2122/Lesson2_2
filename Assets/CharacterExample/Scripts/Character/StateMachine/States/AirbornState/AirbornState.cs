using UnityEngine;

public class AirbornState : MovementState
{
    private readonly AirborneStateConfig _config;

    public AirbornState(IStateSwitcher stateSwitcher, Character character, StateMachineData data) : base(stateSwitcher, character, data)
        => _config = character.Config.AirborneStateConfig;

    public override void Enter()
    {
        base.Enter();

        View.StartAirborne();

        Data.Speed = _config.Speed;
    }

    public override void Exit()
    {
        base.Exit();

        View.StopAirborne();
    }

    public override void Update()
    {
        base.Update();

        Data.YVelocity -= GetGravityMultilpier() * Time.deltaTime;
    }

    protected virtual float GetGravityMultilpier() => _config.BaseGravity;
}
