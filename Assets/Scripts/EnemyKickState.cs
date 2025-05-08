using UnityEngine;

public class EnemyKickState : State
{
    public EnemyKickState(Animator animator) : base(animator) { }

    public override void Enter() => animator.Play("kenpatada");
}
