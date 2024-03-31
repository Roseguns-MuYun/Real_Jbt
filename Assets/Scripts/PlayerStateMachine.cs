using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine
{
    public PlayerState currentState;

    public void Initialize(PlayerState _startState) //³õÊ¼×´Ì¬
    {
        currentState = _startState;
        currentState.Enter();
    }
    
    public void ChangeState(PlayerState _newState) //×´Ì¬ÇÐ»»
    {
        currentState.Exit();
        currentState = _newState;
        currentState.Enter();
    }
}
