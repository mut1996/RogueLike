using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

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
