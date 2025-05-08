using UnityEngine;

public class EnemyPunchState : State
{
    public EnemyPunchState(Animator animator) : base(animator) { }

    public override void Enter() => animator.Play("kengolpe");
}