using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 임시코드 PlayerStateMachine으로 바꿀꺼임 
/// Weapon Class, Manager 를 만들어서 무기 관리 
/// Item 배열안에 weapon, health, coin, 
/// invetory
///  속성은 6가지 일정 수준이상으로 올릴시 속성 스킬을 
///  
/// 
/// 맵은 아예 랜덤하게 만들기 vs 미리만들어 놓고 position 을 랜덤으로 스폰하게 한뒤 인접 공간에 통로 연결시키기
/// stage 넘어갈수록 복잡하고 방개수 추가.
/// 
/// </summary>

public class PlayerController : MonoBehaviour
{

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
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
        AnimationCotroll();
    }


    // 왼쪽 클릭하면 왼쪽보고 오른쪽 클릭하면 오른쪽봄
    // 그리고 왼쪽 오른쪽이 아니면 보는 방향 유지.
    private void Move()
    {
        Vector2 dir = Vector2.zero;

        if (Input.GetKey(KeyCode.A))
        {
            dir.x = -1;
            sprite.flipX = true;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            dir.x = 1;
            sprite.flipX = false; 
        }

        if (Input.GetKey(KeyCode.W))
        {
            dir.y = 1;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            dir.y = -1;
        }

        dir.Normalize();
        rigidbody.velocity = speed * dir ;

    }

    private void AnimationCotroll() 
    {
        if (Mathf.Abs(rigidbody.velocity.magnitude) >= 0.01f)
        {
            animator.SetBool("move", true);
            animator.SetBool("idle", false);

        }
        else
        {
            animator.SetBool("move", false);
            animator.SetBool("idle", true);

        }
    }




}
