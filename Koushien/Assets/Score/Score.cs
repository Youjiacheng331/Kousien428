using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public void ApplyEffect(int ballType1, int ballType2, int totalPower)
    {
        //
        if ((ballType1 == 0 && ballType2 == 1) || (ballType1 == 1 && ballType2 == 0))
        {
            //
            IncreaseEnemyDamage(totalPower);
        }
        else if ((ballType1 == 1 && ballType2 == 3) || (ballType1 == 3 && ballType2 == 1))
        {
            //
            ReducePlayerDamage(totalPower);
        }
        else if ((ballType1 == 0 && ballType2 == 3) || (ballType1 == 3 && ballType2 == 0))
        {
            //
            ResetDamageCounter(totalPower);
        }
        else
        {
            //
            DealDamageToEnemy(totalPower);
        }
    }

    private static void IncreaseEnemyDamage(int totalPower)
    {
        //
        Debug.Log($"Increase enemy damage by {totalPower}x for 30 seconds");
        //
    }

    private static void ReducePlayerDamage(int totalPower)
    {
        //
        Debug.Log($"Reduce player damage by {totalPower} for 30 seconds");
        //
    }

    private static void ResetDamageCounter(int totalPower)
    {
        //
        Debug.Log($"Reset damage counter by {totalPower * 3} seconds");
        //
    }

    private static void DealDamageToEnemy(int totalPower)
    {
        // 
        Debug.Log($"Deal {totalPower} damage to enemy");
        //
    }
}
