using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damy : MonoBehaviour
{
    //�U���܂ł̎c�莞��
    public float attackCountdown;
    //�U�����Ԃ̐ݒ肷��ϐ�
    public float attackTime;
    public float timeper;//���Ԃ̊����iUI�Ɏg�p�j
    //�G�l�~�[��
    public float E_HPper;//HP�����iUI�Ɏg���܂��j
    private int EnemyMaxHP = 100;//
    public int EnemyHP;
    //�v���C���[��
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

        UpdateHP();

    }

    void Attack()
    {
        //�U���������s����ł��낤�ꏊ
        Debug.Log(gameObject.name + "���U�����܂���");
        PlayerHP = PlayerHP - 5;
        EnemyHP = EnemyHP - 5;

    }

    private void UpdateHP()
    {
        P_HPper = (float)PlayerHP / PlayerMaxHP;
        E_HPper = (float)EnemyHP / EnemyMaxHP;
        timeper = attackCountdown /attackTime ;
    }

}
