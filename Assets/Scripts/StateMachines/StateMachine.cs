using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public abstract class StateMachine 
{
    protected IState currentState; 
    public void ChangeState(IState newState)
    {
        currentState?.Exit(); 
        currentState = newState;
        currentState?.Enter(); 
    }

    public void HandleInput()
    {
        currentState?.HandlerInput(); 
    }

    public void Update()
    {
        currentState?.Update(); 
    }

    public void PhysicsUpdate()
    {
        currentState?.PhysicsUpdate(); 
    }
}