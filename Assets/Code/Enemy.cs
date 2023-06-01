using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemy : MonoBehaviour
{
    public float speed;
    public Rigidbody2D target;
    public int index = 0;

    bool isLive = true;

    Rigidbody2D rigid;
    SpriteRenderer spriter;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
    }

    
    void FixedUpdate()
    {
        if (!isLive)
            return;
        if (index == 0)
        {
            Vector2 dirVec = new Vector2(target.position.x - rigid.position.x, 0);
            Vector2 nextVec = dirVec.normalized * speed * Time.fixedDeltaTime;
            rigid.MovePosition(rigid.position + nextVec);
            rigid.velocity = Vector2.zero;
        }
        else if (index == 1)
        {
            Vector2 dirVec = new Vector2(rigid.position.x - target.position.x, 0);
            Vector2 nextVec = dirVec.normalized * speed * Time.fixedDeltaTime;
            rigid.MovePosition(rigid.position + nextVec);
            rigid.velocity = Vector2.zero;
        }
    }

    private void LateUpdate()
    {
        if (!isLive)
            return;
        if (index == 0)
        {
            spriter.flipX = target.position.x < rigid.position.x;
        }
        if (index == 1)
        {
            spriter.flipX = target.position.x > rigid.position.x;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (index == 1 && collider.gameObject.tag == "River")
        {
            speed = (float)0.4;
        }

    }
}
