using UnityEngine;

public class EnemyWalkLeftState : State
{
    public EnemyWalkLeftState(Animator animator) : base(animator) { }

    public override void Enter() => animator.Play("kenavanzar");
}
