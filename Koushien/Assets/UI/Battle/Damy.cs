using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damy : MonoBehaviour
{
    public FadeManager fadeManager;

    //攻撃までの残り時間
    public float attackCountdown;
    //攻撃時間の設定する変数
    public float attackTime;
    public float timeper;//時間の割合（UIに使用）
    //エネミー側（エネミーが出来るまでの仮）
    public float E_HPper;//HP割合（UIに使います）
    private int EnemyMaxHP = 100;//
    public int EnemyHP;
    public int EnemyAT=10;
    //プレイヤー側
    public float P_HPper;
    private int PlayerMaxHP = 100;
    public int PlayerHP;


    // Start is called before the first frame update
    void Start()
    {
        attackCountdown = attackTime;
        EnemyHP = EnemyMaxHP;
        PlayerHP = PlayerMaxHP;

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

        UpdateHP();
        if (PlayerHP <= 0)
        {
            fadeManager.FadeToScene("GameOver",false);
        }
        if (EnemyHP <= 0)
        {
            fadeManager.FadeToScene("StageClear",false);
        }
    }

    void Attack()
    {
        //攻撃処理が行われるであろう場所
        Debug.Log(gameObject.name + "が攻撃しました");
        PlayerHP = PlayerHP - EnemyAT;
        
        //EnemyHP = EnemyHP - 5;

    }

    private void UpdateHP()
    {
        P_HPper = (float)PlayerHP / PlayerMaxHP;
        E_HPper = (float)EnemyHP / EnemyMaxHP;
        timeper = attackCountdown /attackTime ;
    }

}
