using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine 
{
   public PlayerState CurretState { get; private set; }

    public void Initialize(PlayerState startingState)
    {
        CurretState = startingState;
        CurretState.Enter();
    }

    public void ChangeState(PlayerState newState) 
    {
        CurretState.Exit();
        CurretState = newState;
        CurretState.Enter();
    }


}
