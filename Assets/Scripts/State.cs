using UnityEngine;

public abstract class State
{
    protected Animator animator;

    public State(Animator animator)
    {
        this.animator = animator;
    }

    public virtual void Enter() { }
    public virtual void Update() { }
    public virtual void Exit() { }
}
