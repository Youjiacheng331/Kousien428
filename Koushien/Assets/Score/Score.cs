using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static void ApplyEffect(int ballType1, int ballType2, int totalPower)
    {
        // �F�̑g�ݍ��킹�ɂ��ǉ����ʂ�����
        if ((ballType1 == 0 && ballType2 == 1) || (ballType1 == 1 && ballType2 == 0))
        {
            // �ԁE�̑g�ݍ��킹�F�G�̔�_���[�W�㏸
            IncreaseEnemyDamage(totalPower);
        }
        else if ((ballType1 == 1 && ballType2 == 3) || (ballType1 == 3 && ballType2 == 1))
        {
            // �E�΂̑g�ݍ��킹�F�v���C���[�̔�_���[�W�y��
            ReducePlayerDamage(totalPower);
        }
        else if ((ballType1 == 0 && ballType2 == 3) || (ballType1 == 3 && ballType2 == 0))
        {
            // �ԁE�΂̑g�ݍ��킹�F�_���[�W���󂯂�J�E���g��߂�
            ResetDamageCounter(totalPower);
        }
        else
        {
            // �f�t�H���g�̓G�ɗ^����_���[�W����
            DealDamageToEnemy(totalPower);
        }
    }

    private static void IncreaseEnemyDamage(int totalPower)
    {
        // 30�b�ԓG�ɗ^����_���[�W��X�{������
        Debug.Log($"Increase enemy damage by {totalPower}x for 30 seconds");
        // ���ۂ̌��ʏ����������ɋL�q
    }

    private static void ReducePlayerDamage(int totalPower)
    {
        // 30�b�ԃv���C���[���󂯂�_���[�W��X�_���[�W���炷
        Debug.Log($"Reduce player damage by {totalPower} for 30 seconds");
        // ���ۂ̌��ʏ����������ɋL�q
    }

    private static void ResetDamageCounter(int totalPower)
    {
        // �_���[�W���󂯂�܂ł̃J�E���g�ƃQ�[�W��(X * 3)�b�߂�
        Debug.Log($"Reset damage counter by {totalPower * 3} seconds");
        // ���ۂ̌��ʏ����������ɋL�q
    }

    private static void DealDamageToEnemy(int totalPower)
    {
        // �G�ɒʏ�_���[�W��^����
        Debug.Log($"Deal {totalPower} damage to enemy");
        // ���ۂ̌��ʏ����������ɋL�q
    }
}

