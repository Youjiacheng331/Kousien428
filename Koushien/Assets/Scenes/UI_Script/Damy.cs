using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damy : MonoBehaviour
{
    //�U���܂ł̎c�莞��
    public float attackCountdown;
    //�U�����Ԃ̐ݒ肷��ϐ�
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
        //�J�E���g�_�E����i�߂�
        if(attackCountdown > 0)
        {
            attackCountdown -= Time.deltaTime;
        }
        else
        {
            //�U������
            Attack();
            //�J�E���g�_�E�����Z�b�g
            attackCountdown = attackTime;
        }

    }

    void Attack()
    {
        //�U���������s����ł��낤�ꏊ
        Debug.Log(gameObject.name + "���U�����܂���");
        PlayerHP = PlayerHP - 1;


    }

}
