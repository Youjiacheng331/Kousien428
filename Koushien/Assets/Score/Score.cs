using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static void ApplyEffect(int ballType1, int ballType2, int totalPower)
    {
        // 色の組み合わせによる追加効果を処理
        if ((ballType1 == 0 && ballType2 == 1) || (ballType1 == 1 && ballType2 == 0))
        {
            // 赤・青の組み合わせ：敵の被ダメージ上昇
            IncreaseEnemyDamage(totalPower);
        }
        else if ((ballType1 == 1 && ballType2 == 3) || (ballType1 == 3 && ballType2 == 1))
        {
            // 青・緑の組み合わせ：プレイヤーの被ダメージ軽減
            ReducePlayerDamage(totalPower);
        }
        else if ((ballType1 == 0 && ballType2 == 3) || (ballType1 == 3 && ballType2 == 0))
        {
            // 赤・緑の組み合わせ：ダメージを受けるカウントを戻す
            ResetDamageCounter(totalPower);
        }
        else
        {
            // デフォルトの敵に与えるダメージ処理
            DealDamageToEnemy(totalPower);
        }
    }

    private static void IncreaseEnemyDamage(int totalPower)
    {
        // 30秒間敵に与えるダメージがX倍増える
        Debug.Log($"Increase enemy damage by {totalPower}x for 30 seconds");
        // 実際の効果処理をここに記述
    }

    private static void ReducePlayerDamage(int totalPower)
    {
        // 30秒間プレイヤーが受けるダメージをXダメージ減らす
        Debug.Log($"Reduce player damage by {totalPower} for 30 seconds");
        // 実際の効果処理をここに記述
    }

    private static void ResetDamageCounter(int totalPower)
    {
        // ダメージを受けるまでのカウントとゲージを(X * 3)秒戻す
        Debug.Log($"Reset damage counter by {totalPower * 3} seconds");
        // 実際の効果処理をここに記述
    }

    private static void DealDamageToEnemy(int totalPower)
    {
        // 敵に通常ダメージを与える
        Debug.Log($"Deal {totalPower} damage to enemy");
        // 実際の効果処理をここに記述
    }
}

