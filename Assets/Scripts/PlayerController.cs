using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 임시코드 PlayerStateMachine으로 바꿀꺼임 
/// Weapon Class, Manager 를 만들어서 무기 관리 
/// weapon 에는 전기 스킬이 들 어가 있음 type 마다 공격 콤보 모션등이 달리짐 
/// Weapon Type 받아와서 bool 형식으로 animation 제어 
/// Item 배열안에 weapon, health, coin, 
/// invetory
///  속성은 6가지 일정 수준이상으로 올릴시 속성 스킬을 
///  
/// 
/// 맵은 아예 랜덤하게 만들기 vs 미리만들어 놓고 position 을 랜덤으로 스폰하게 한뒤 인접 공간에 통로 연결시키기
/// stage 넘어갈수록 복잡하고 방개수 추가.
/// 
/// </summary>



public class PlayerController : BaseController
{


    public override void Init()
    {
        Managers.
    }

    #region Stat
    public float attackPower;
    public float attackSpeed;
    public float attackRange;

    public int heart;
    public int defence;
    
    public int manaCrystal;
    public float manaCrystal_recoverySpeed;
    public float speed;

    // 착용 속성 개수 
    public int wearingProperties;

    #endregion

 


    private Animator animator;
    private SpriteRenderer sprite;
    private Rigidbody2D rigidbody;

    private void Start()
    {
       
        sprite = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
    }



    
    private void Move()
    {


        Vector2 dir = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dir.x = -1;
            sprite.flipX = true;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            dir.x = 1;
            sprite.flipX = false; 
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            dir.y = 1;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            dir.y = -1;
        }

        dir.Normalize();
        rigidbody.velocity = speed * dir ;

    }

    
}
