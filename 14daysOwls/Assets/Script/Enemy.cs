using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int monster_hp;
    public float monster_speed;
    public int monster_attak;

    void Update()
    {
        
    }

    void MonsterMove()
    {


    }

    public void Monster_Attack()
    {
        //palyer�� �浹
        //����(?)�ִϸ��̼�(���͸��� ���?)
        //����
        //hp����

    }

    public void Monster_Damaged(int ATK)
    {
        //player���� ���ݴ��ϰų� �浹
        //hp����(0�Ǹ� ���)
        //�ִϸ��̼�
        //����(?)
        monster_hp -= ATK;
        
        if(monster_hp <= 0)
        {
            MonsterDeath();
        }

    }

    public void MonsterDeath()
    {
        //hp 0�Ǹ� ���
        //�ִϸ��̼�
        //������(?)��ħ(���� ������ ��ĥ�� ����Ʈ)
        //����
        
    }
}
