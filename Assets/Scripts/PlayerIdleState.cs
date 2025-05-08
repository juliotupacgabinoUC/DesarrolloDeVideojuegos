using UnityEngine;

public class PlayerIdleState : State
{
    public PlayerIdleState(Animator animator) : base(animator) { }

    public override void Enter() => animator.Play("quieto");
}
