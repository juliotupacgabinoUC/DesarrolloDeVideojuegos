using UnityEngine;

public class EnemyIdleState : State
{
    public EnemyIdleState(Animator animator) : base(animator) { }

    public override void Enter() => animator.Play("kenquieto");
}
