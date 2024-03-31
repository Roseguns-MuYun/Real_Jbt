using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    public PlayerStateMachine stateMachine;
    public Player player;
    public string animBoolName;

    public Rigidbody2D rb;
    public float xInput;
    public PlayerState(PlayerStateMachine _stateMachine, Player _player,string _animName)
    {
        this.stateMachine = _stateMachine;
        this.player = _player;
        this.animBoolName = _animName;
    }
    public virtual void Enter()
    {
        rb = player.rb;
    }
    public virtual void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
    }
    public virtual void Exit()
    {

    }
}
