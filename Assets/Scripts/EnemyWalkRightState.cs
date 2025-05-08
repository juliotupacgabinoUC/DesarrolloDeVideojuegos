using UnityEngine;

public class EnemyWalkRightState : State
{
    public EnemyWalkRightState(Animator animator) : base(animator) { }

    public override void Enter() => animator.Play("kenretroceder");
}
