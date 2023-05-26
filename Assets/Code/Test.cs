using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    
    public Transform s;
    public float speed;
    Rigidbody2D rigid;
    Image image1;
    public GameObject g1;
    Image image2;
    public GameObject g2;
    Image image3;
    public GameObject g3;
    Image image4;
    public GameObject g4;
    bool meet = false;
    Vector2 ori;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        image1 = g1.GetComponent<Image>();
        image2 = g2.GetComponent<Image>();
        image3 = g3.GetComponent<Image>();
        image4 = g4.GetComponent<Image>();

    }
    public void attack()
    {
        ori = transform.position;
        Color gg1 = image1.color;
        gg1.a = 1f;
        image1.color = gg1;
        Color gg2 = image2.color;
        gg2.a = 1f;
        image2.color = gg2;
        Color gg3 = image3.color;
        gg3.a = 1f;
        image3.color = gg3;
        Color gg4 = image4.color;
        gg4.a = 1f;
        image4.color = gg4;


        
        Debug.Log(rigid.position);
        if (!meet)
        {
            StartCoroutine(gogo());
        }
        IEnumerator gogo()
        {
            float kDistance = ((Vector2)transform.position - (Vector2)s.position).sqrMagnitude;

            while (kDistance > float.Epsilon + 0.1f)
            {
                Vector2 newposition = Vector2.MoveTowards(rigid.position, s.position, speed * Time.fixedDeltaTime);
                rigid.MovePosition(newposition);
                kDistance = ((Vector2)transform.position - (Vector2)s.position).sqrMagnitude;
                yield return null;
            }
            rigid.velocity = Vector2.zero;
        }


    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "River")
        {
            Color gg1 = image1.color;
            gg1.a = 0f;
            image1.color = gg1;
            Color gg2 = image2.color;
            gg2.a = 0f;
            image2.color = gg2;
            Color gg3 = image3.color;
            gg3.a = 0f;
            image3.color = gg3;
            Color gg4 = image4.color;
            gg4.a = 0f;
            image4.color = gg4;
            StartCoroutine(backOrigin());
        }
        IEnumerator backOrigin()
        {
            float kDistance = ((Vector2)transform.position - ori).sqrMagnitude;

            while (kDistance > float.Epsilon + 0.1f)
            {
                Vector2 newposition = Vector2.MoveTowards(rigid.position, ori, speed * Time.fixedDeltaTime);
                rigid.MovePosition(newposition);
                kDistance = ((Vector2)transform.position - ori).sqrMagnitude;
                yield return null;
            }
            Debug.Log(rigid.position);
            rigid.velocity = Vector2.zero;
        }

    }
}
