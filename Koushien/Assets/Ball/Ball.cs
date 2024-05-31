using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int BallPower;

    public int BallType;

    public bool Absorption;

    bool Touch;

    Vector3 OldPos;

    GameObject NextBall;

    public Vector2 Pos;

    // Start is called before the first frame update
    void Start()
    {
        Touch = false;

        BallPower = 1;

        Absorption = false;

        OldPos = transform.position;

        BallType = Random.Range(0, 4);

        switch (BallType)
        {
            case 0:
                //ê‘
                GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
                break;
            case 1:
                //ê¬
                GetComponent<SpriteRenderer>().color = new Color(0.0f, 0.0f, 1.0f, 1.0f);
                break;
            case 2:
                //â©
                GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 0.0f, 1.0f);
                break;
            case 3:
                //óŒ
                GetComponent<SpriteRenderer>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
                break;
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }

   public void BallAction(GameObject NextBall)
    {
        //Ballà⁄ìÆ
        transform.position = Vector3.MoveTowards(transform.position, NextBall.transform.position, 0.005f);

        float dis = Vector3.Distance(transform.position, NextBall.transform.position);

        if (dis <= 0.005f) {

            //çUåÇÇ©ãzé˚Ç©
            if (BallType == NextBall.GetComponent<Ball>().BallType)
            {
                //ãzé˚
                NextBall.GetComponent<Ball>().BallPower += BallPower;
                Vector3 scl = NextBall.transform.localScale;
                scl.x *= 1.1f;
                scl.y *= 1.1f;

                NextBall.transform.localScale = scl;


                //è¡ñ≈
                Destroy(this.gameObject);

            }
            else
            {
                //çUåÇ


                //ballè¡ñ≈
                Destroy(this.gameObject);
                Destroy(NextBall);
            }
        }
    }

   

    
}
