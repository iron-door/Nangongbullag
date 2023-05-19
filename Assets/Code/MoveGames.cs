using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGames : MonoBehaviour
{
    RectTransform trans;
    Vector3 LeftVec = new Vector3(300,0,0);
    Vector3 RightVec = new Vector3(-300, 0, 0);
    private void Awake()
    {
        trans = GetComponent<RectTransform>();
    }
    
    public void LB()
    {
        if (trans.localPosition.x < 599)
        {
            transform.localPosition += LeftVec;
        }
    }

    public void RB()
    {
        if (trans.localPosition.x > -599)
        {
            transform.localPosition += RightVec;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            if (trans.localPosition.x < 599)
            {
                transform.localPosition += LeftVec;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            if (trans.localPosition.x > -599)
            {
                transform.localPosition += RightVec;
            }

        }

    }

}
