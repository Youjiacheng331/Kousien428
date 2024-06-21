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

    public
    GameObject Space;

    public void SetSpace(GameObject obj)
    {
        Space = obj;
    }

    public void Select(bool click)
    {
        if (click == true) 
        {
            Space.GetComponent<SpriteRenderer>().color = Color.magenta;
        }
        else
        {
            Space.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

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
                //��
                GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
                break;
            case 1:
                //��
                GetComponent<SpriteRenderer>().color = new Color(0.0f, 0.0f, 1.0f, 1.0f);
                break;
            case 2:
                //��
                GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 0.0f, 1.0f);
                break;
            case 3:
                //��
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
        //Ball�ړ�
        transform.position = Vector3.MoveTowards(transform.position, NextBall.transform.position, 0.01f);

        float dis = Vector3.Distance(transform.position, NextBall.transform.position);

        if (dis <= 0.005f) {

            //�U�����z����
            if (BallType == NextBall.GetComponent<Ball>().BallType)
            {
                //�z��
                NextBall.GetComponent<Ball>().BallPower += BallPower;
                Vector3 scl = NextBall.transform.localScale;
                scl.x *= 1.1f;
                scl.y *= 1.1f;

                NextBall.transform.localScale = scl;
                NextBall.GetComponent<Ball>().Select(false);


                //����
                Select(false);
                Destroy(this.gameObject);

            }
            else
            {
                //�U��

                int TotalPower;

                TotalPower = BallPower + NextBall.GetComponent<Ball>().BallPower;

                GetComponent<Score>().ApplyEffect(BallType, NextBall.GetComponent<Ball>().BallType, TotalPower);



                //ball����
                NextBall.GetComponent<Ball>().Select(false);
                Select(false);
                Destroy(this.gameObject);
                Destroy(NextBall);
            }
        }
    }

   

    
}
