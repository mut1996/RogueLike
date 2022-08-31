using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// �ӽ��ڵ� PlayerStateMachine���� �ٲܲ��� 
/// Weapon Class, Manager �� ���� ���� ���� 
/// weapon ���� ���� ��ų�� �� � ���� type ���� ���� �޺� ��ǵ��� �޸��� 
/// Weapon Type �޾ƿͼ� bool �������� animation ���� 
/// Item �迭�ȿ� weapon, health, coin, 
/// invetory
///  �Ӽ��� 6���� ���� �����̻����� �ø��� �Ӽ� ��ų�� 
///  
/// 
/// ���� �ƿ� �����ϰ� ����� vs �̸������ ���� position �� �������� �����ϰ� �ѵ� ���� ������ ��� �����Ű��
/// stage �Ѿ���� �����ϰ� �氳�� �߰�.
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

    // ���� �Ӽ� ���� 
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
