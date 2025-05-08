using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private StateMachine stateMachine;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        stateMachine = new StateMachine();

        // Estado inicial
        stateMachine.ChangeState(new PlayerIdleState(animator));
    }

    void Update()
    {
        // Actualiza el estado actual (por si algún estado tiene lógica propia en Update)
        stateMachine.Update();

        float horizontal = Input.GetAxisRaw("Horizontal");

        // Movimiento hacia izquierda o derecha
        if (horizontal != 0)
        {
            transform.Translate(Vector2.right * horizontal * Time.deltaTime * 3f); // velocidad = 3
            stateMachine.ChangeState(new PlayerWalkState(animator));
        }
        else if (Input.GetKeyDown(KeyCode.A)) // Golpe
        {
            stateMachine.ChangeState(new PlayerPunchState(animator));
        }
        else if (Input.GetKeyDown(KeyCode.S)) // Patada
        {
            stateMachine.ChangeState(new PlayerKickState(animator));
        }
        else
        {
            stateMachine.ChangeState(new PlayerIdleState(animator));
        }
    }
}

