using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    Vector3 MousePos;

    public bool Catch;

    public
    GameObject Ball1, Ball2;

    public
    GameObject EnterObject;

    // Start is called before the first frame update
    void Start()
    {
        Catch = false;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;

        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        MousePos.z = 0.0f;

        transform.position = MousePos;



        if (Input.GetMouseButtonDown(0))
        {
           

            if (Catch == true && EnterObject != Ball1) 
            {
                Ball2 = EnterObject;
            }


            if (Catch == false)
            {
                Ball1 = EnterObject;
            }


        }
        if (Ball1 == null && Ball2 == null)
        {
            Catch = false;
        }

        if (Ball1 != null && Ball2 == null)
        {
            Catch = true;
        }

        if (Ball1 == null && Ball2 != null)
        {
            Catch = false;

            Ball2 = null;
        }

        if (Ball1 != null && Ball2 != null)
        {
            if ((Mathf.Abs(Ball1.GetComponent<Ball>().Pos.x - Ball2.GetComponent<Ball>().Pos.x) == 1 &&
                Ball1.GetComponent<Ball>().Pos.y == Ball2.GetComponent<Ball>().Pos.y) ||
                (Mathf.Abs(Ball1.GetComponent<Ball>().Pos.y - Ball2.GetComponent<Ball>().Pos.y) == 1 &&
                Ball1.GetComponent<Ball>().Pos.x == Ball2.GetComponent<Ball>().Pos.x)) 
            {
                Ball1.GetComponent<Ball>().BallAction(Ball2);
            }
            else
            {
                Ball1 = Ball2;
                Ball2 = null;
            }
        }

       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (EnterObject == null)
        {
            if (collision.gameObject.transform.CompareTag("Ball"))
            {
                EnterObject = collision.gameObject;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (EnterObject != null && EnterObject == collision.gameObject) 
        {
            EnterObject = null;
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (EnterObject == null)
        {
            if (collision.gameObject.transform.CompareTag("Ball"))
            {
                EnterObject = collision.gameObject;
            }
        }
    }


}
