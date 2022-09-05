using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region State Variables
    public PlayerStateMachine stateMachine { get; private set; }





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
          
    }

    private void Start()
    {
        Anim = GetComponent<Animator>();
        RB = GetComponent<Rigidbody2D>();
        MovementCollider = GetComponent<BoxCollider2D>();


    }



    // ���⼭ State �� LogicUpdate ��ӵ�����  
    private void Update()
    {
        stateMachine.CurretState.LogicUpdate();
    }

    // ���⼭ State �� PhysicsUpdate ��� ������ 
    private void FixedUpdate()
    {
        stateMachine.CurretState.PhysicsUpdate();
    }


    #region other Fucntion

   

    private void AnimationTrigger() => stateMachine.CurretState.AnimationTrigger();
    private void AnimationFinishTrigger() => stateMachine.CurretState.AnimationFinishTrigger();
    #endregion

}
