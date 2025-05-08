using UnityEngine;

public class PlayerWalkState : State
{
    public PlayerWalkState(Animator animator) : base(animator) { }

    public override void Enter() => animator.Play("mover");
}
