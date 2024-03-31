using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStateMachine stateMachine;

    public PlayerIdleState idleState;
    public PlayerMoveState moveState;
    public PlayerGroundState groundState;

    public Rigidbody2D rb;

    [Header("Move info")]
    public float moveSpeed;
    private void Awake()
    {
        Debug.Log("hello");
        stateMachine = new PlayerStateMachine();
        idleState = new PlayerIdleState(stateMachine, this, "Idle");
        moveState = new PlayerMoveState(stateMachine, this, "Move");
    }
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("wowo");
        rb = GetComponent<Rigidbody2D>();
        stateMachine.Initialize(idleState);
        
    }

    // Update is called once per frame
    private void Update()
    {
        stateMachine.currentState.Update();
    }

    public void SetVelocity(float _xVelocity,float _yVelocity)
    {
        rb.velocity = new Vector2(_xVelocity,_yVelocity);
    }
}
