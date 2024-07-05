using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    GameObject Parameter;

    bool BoostFlag;

    int Boost;

    float time;

    private void Start()
    {
        Parameter = GameObject.Find("EnemyImage");

        Boost = 1;

        BoostFlag = false;

        time = 0;
    }


    private void Update()
    {
        if (BoostFlag == true)
        {
            time += Time.deltaTime;

            if (time > 30.0f)
            {
                BoostFlag = false;

                time = 0.0f;

                Boost = 1;
            }
        }
        
    }

    public void ApplyEffect(int ballType1, int ballType2, int ballPower1, int ballPower2)
    {
        //
        if (((ballType1 == 0 && ballType2 == 1) || (ballType1 == 1 && ballType2 == 0))
            && ballPower1 == ballPower2)
        {
            //赤・青
            IncreaseEnemyDamage(ballPower2);
        }
        else if (((ballType1 == 1 && ballType2 == 2) || (ballType1 == 2 && ballType2 == 1))
            && ballPower1 == ballPower2)
        {
            //青・緑
            ReducePlayerDamage(ballPower2);
        }
        else if (((ballType1 == 0 && ballType2 == 2) || (ballType1 == 2 && ballType2 == 0))
            && ballPower1 == ballPower2) 
        {
            //赤・緑
            ResetDamageCounter(ballPower2);
        }
        else
        {
            //
            DealDamageToEnemy(ballPower1 + ballPower2);
        }
    }

    private void IncreaseEnemyDamage(int totalPower)
    {
        BoostFlag = true;

        Boost = totalPower;

        DealDamageToEnemy(totalPower * 2);

        //
        Debug.Log($"Increase enemy damage by {totalPower}x for 30 seconds");
        //
    }

    private void ReducePlayerDamage(int totalPower)
    {
        Parameter.GetComponent<Damy>().GuardFlag = true;

        Parameter.GetComponent<Damy>().Guard = totalPower;

        DealDamageToEnemy(totalPower * 2);
        //
        Debug.Log($"Reduce player damage by {totalPower} for 30 seconds");
        //
    }

    private void ResetDamageCounter(int totalPower)
    {
        Parameter.GetComponent<Damy>().attackCountdown += (float)(totalPower * 3);

        if (Parameter.GetComponent<Damy>().attackCountdown > 10.0f)
        {
            Parameter.GetComponent<Damy>().attackCountdown = 10.0f;
        }

        DealDamageToEnemy(totalPower * 2);
        //
        Debug.Log($"Reset damage counter by {totalPower * 3} seconds");
        //
    }

    private void DealDamageToEnemy(int totalPower)
    {
        Parameter.GetComponent<Damy>().EnemyHP -= ((totalPower) * Boost);


        // 
        Debug.Log($"Deal {totalPower} damage to enemy");
        //
    }
}
