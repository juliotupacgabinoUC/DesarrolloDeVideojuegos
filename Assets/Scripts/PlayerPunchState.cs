using UnityEngine;

public class PlayerPunchState : State
{
    private GameObject hitbox;

    public PlayerPunchState(Animator animator) : base(animator)
    {
        hitbox = GameObject.Find("Player/Hitbox"); // Ajusta ruta si necesario
    }

    public override void Enter()
    {
        animator.Play("Punch");
        if (hitbox != null)
            hitbox.SetActive(true);
    }

    public override void Exit()
    {
        if (hitbox != null)
            hitbox.SetActive(false);
    }
}
