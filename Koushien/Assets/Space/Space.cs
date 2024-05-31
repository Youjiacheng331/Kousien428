using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    [SerializeField]
    Vector2 Position;

    [SerializeField]
    GameObject BallObject;

    GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball == null)
        {
            RespawnBall();
        }
    }

    void RespawnBall()
    {
        Ball = Instantiate(BallObject, transform.position, Quaternion.identity);
        Ball.GetComponent<Ball>().Pos = Position;
    }

    

}
