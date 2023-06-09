using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    Rigidbody2D rigid;
    SpriteRenderer spriter;
    public Vector2 inputVec;
    public float speed;
    public float speed1;
    public int index;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 nextVec = new Vector2(inputVec.x * speed * Time.fixedDeltaTime, inputVec.y * speed1 * Time.fixedDeltaTime);
        rigid.MovePosition(rigid.position + nextVec);
    }

    private void LateUpdate()
    {
        if(inputVec.x != 0)
        {
            spriter.flipX = inputVec.x < 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (index == 0 && collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Game3");
        }
        else if (index == 1 && collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Game5");
        }
        else if (index == 2 && collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Game7");
        }
        else if (index == 3 && collision.gameObject.tag == "Castle")
        {
            SceneManager.LoadScene("Game9");
        }
        else if (index == 4 && collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Game10");
        }
    }
}