using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damy : MonoBehaviour
{
    //攻撃までの残り時間
    public float attackCountdown;
    //攻撃時間の設定する変数
    public float attackTime;

    public int EnemyHP;
    public int PlayerHP;

    // Start is called before the first frame update
    void Start()
    {
        attackCountdown = attackTime;
        EnemyHP = 100;
        PlayerHP = 100;

    }

    // Update is called once per frame
    void Update()
    {
        //カウントダウンを進める
        if(attackCountdown > 0)
        {
            attackCountdown -= Time.deltaTime;
        }
        else
        {
            //攻撃処理
            Attack();
            //カウントダウンリセット
            attackCountdown = attackTime;
        }

    }

    void Attack()
    {
        //攻撃処理が行われるであろう場所
        Debug.Log(gameObject.name + "が攻撃しました");
        PlayerHP = PlayerHP - 1;


    }

}
