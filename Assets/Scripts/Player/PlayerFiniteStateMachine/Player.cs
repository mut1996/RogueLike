using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Player component statemachine
/// Idle, Dash, skill, Die, Move, Attack  ->  이번주 까지 
/// 적 Idle, Attack, Die -> 이번주 까지 
/// Invetory, Weapon, Inventory -> 다음주 까지 
/// </summary>

public class Player : MonoBehaviour
{
    #region State Variables
    public PlayerStateMachine stateMachine { get; private set; }

    public PlayerIdleState IdleState { get; private set; }




    [SerializeField]
    private PlayerData playerData;
    public PlayerData PlayerData { get => playerData; private set => playerData = value; }

    #endregion

    #region Compnents


    public Animator Anim { get; private set; }
    public Rigidbody2D RB { get; private set; }
    public BoxCollider2D MovementCollider { get; private set; }


    #endregion

    private Vector2 workSpace;


    private void Awake()
    {
        IdleState = new PlayerIdleState(this, stateMachine, playerData, "Idle");
    }

    private void Start()
    {
        Anim = GetComponent<Animator>();
        RB = GetComponent<Rigidbody2D>();
        MovementCollider = GetComponent<BoxCollider2D>();


    }



    // 여기서 State 들 LogicUpdate 계속돌려줌  
    private void Update()
    {
        stateMachine.CurretState.LogicUpdate();
    }

    // 여기서 State 들 PhysicsUpdate 계속 돌려줌 
    private void FixedUpdate()
    {
        stateMachine.CurretState.PhysicsUpdate();
    }


    #region other Fucntion

   

    private void AnimationTrigger() => stateMachine.CurretState.AnimationTrigger();
    private void AnimationFinishTrigger() => stateMachine.CurretState.AnimationFinishTrigger();
    #endregion

}
