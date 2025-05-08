using UnityEngine;

public class PlayerKickState : State
{
    public PlayerKickState(Animator animator) : base(animator) { }

    public override void Enter() => animator.Play("patada");
}
