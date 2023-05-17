using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGames : MonoBehaviour
{
    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    public void LB()
    {
        if (rigid.position.x < 11)
        {
            transform.Translate(6, 0, 0);
        }
    }

    public void RB()
    {
        if (rigid.position.x > -11)
        {
            transform.Translate(-6, 0, 0);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            if (rigid.position.x < 11)
            {
                transform.Translate(6, 0, 0);
            }
            
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            if (rigid.position.x > -11)
            {
                transform.Translate(-6, 0, 0);
            }

        }

    }

}
