using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float speed;

    public int BallPower;

    public int BallType;

    public bool Absorption;

    bool Touch;

    Vector3 OldPos;

    GameObject NextBall;

    public Vector2 Pos;

    public
    GameObject Space;

    [SerializeField]
    Sprite[] BallSprite;

    [SerializeField]
    TextMeshProUGUI Text;

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

        BallType = Random.Range(0, 3);

        switch (BallType)
        {
            case 0:
                //ê‘
                GetComponent<SpriteRenderer>().sprite = BallSprite[0];
                break;
            case 1:
                //ê¬
                GetComponent<SpriteRenderer>().sprite = BallSprite[1];
                break;
            
            case 2:
                //óŒ
                GetComponent<SpriteRenderer>().sprite = BallSprite[2];
                break;
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        Text.transform.position = Camera.main.WorldToScreenPoint(transform.position);

        Text.text = BallPower.ToString();
    }

   public void BallAction(GameObject NextBall)
    {
        //Ballà⁄ìÆ
        transform.position = Vector3.MoveTowards(transform.position, NextBall.transform.position, speed);

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
                NextBall.GetComponent<Ball>().Select(false);


                //è¡ñ≈
                Select(false);
                Destroy(this.gameObject);

            }
            else
            {
                //çUåÇ

                //int TotalPower;

                //TotalPower = BallPower + NextBall.GetComponent<Ball>().BallPower;

                GetComponent<Score>().ApplyEffect(BallType, NextBall.GetComponent<Ball>().BallType, BallPower, NextBall.GetComponent<Ball>().BallPower);



                //ballè¡ñ≈
                NextBall.GetComponent<Ball>().Select(false);
                Select(false);
                Destroy(this.gameObject);
                Destroy(NextBall);
            }
        }
    }

   

    
}
