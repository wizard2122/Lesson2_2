using System;
using UnityEngine;

[Serializable]
public class AirborneStateConfig 
{
    [SerializeField] private JumpStateConfig _jumpingStateConfig;
    [field: SerializeField, Range(0, 10)] public float Speed { get; private set; }

    public JumpStateConfig JumpingStateConfig => _jumpingStateConfig;

    public float BaseGravity
        => 2f * _jumpingStateConfig.MaxHeight / (_jumpingStateConfig.TimeToReachMaxHeight * _jumpingStateConfig.TimeToReachMaxHeight);
}
