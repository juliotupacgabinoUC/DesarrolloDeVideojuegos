using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private StateMachine stateMachine;
    private Animator animator;
    private float timer;

    void Start()
    {
        animator = GetComponent<Animator>();
        stateMachine = new StateMachine();
        stateMachine.ChangeState(new EnemyIdleState(animator));
        timer = 0f;
    }

    void Update()
    {
        timer += Time.deltaTime;
        stateMachine.Update();

        // Lógica simple para cambiar estados cada 2 segundos
        if (timer > 2f)
        {
            int action = Random.Range(0, 5);
            switch (action)
            {
                case 0: stateMachine.ChangeState(new EnemyIdleState(animator)); break;
                case 1: stateMachine.ChangeState(new EnemyWalkLeftState(animator)); break;
                case 2: stateMachine.ChangeState(new EnemyWalkRightState(animator)); break;
                case 3: stateMachine.ChangeState(new EnemyPunchState(animator)); break;
                case 4: stateMachine.ChangeState(new EnemyKickState(animator)); break;
            }
            timer = 0f;
        }
    }
}

