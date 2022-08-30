using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// �ӽ��ڵ� PlayerStateMachine���� �ٲܲ��� 
/// Weapon Class, Manager �� ���� ���� ���� 
/// Item �迭�ȿ� weapon, health, coin, 
/// invetory
///  �Ӽ��� 6���� ���� �����̻����� �ø��� �Ӽ� ��ų�� 
///  
/// 
/// ���� �ƿ� �����ϰ� ����� vs �̸������ ���� position �� �������� �����ϰ� �ѵ� ���� ������ ��� �����Ű��
/// stage �Ѿ���� �����ϰ� �氳�� �߰�.
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

    // ���� �Ӽ� ���� 
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


    // ���� Ŭ���ϸ� ���ʺ��� ������ Ŭ���ϸ� �����ʺ�
    // �׸��� ���� �������� �ƴϸ� ���� ���� ����.
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
