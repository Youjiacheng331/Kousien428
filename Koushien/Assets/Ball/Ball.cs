using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int BallPower;

    public int BallType;

    public bool Absorption;

    Vector3 OldPos;

    GameObject NextBall;

    // Start is called before the first frame update
    void Start()
    {
        BallPower = 1;

        Absorption = false;

        OldPos = transform.position;

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

    public void CheckAbsorption()
    {
        transform.parent = null;

        if (Absorption == true)
        {
            NextBall.GetComponent<Ball>().BallPowerUp(BallPower);

            Destroy(this.gameObject);
        }
        else
        {
            transform.position = OldPos;
        }
    }

    public void BallPowerUp(int power)
    {
        if (power == BallPower)
        {
            BallPower *= 2;
        }
        else
        {
            BallPower += power;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (collision.gameObject.GetComponent<Ball>().BallType == BallType)
            {
                Absorption = true;

                NextBall = collision.gameObject;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (collision.gameObject.GetComponent<Ball>().BallType == BallType)
            {
                Absorption = false;

                NextBall = null;
            }
        }
    }
}
