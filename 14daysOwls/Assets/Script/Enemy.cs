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
        //palyer와 충돌
        //무기(?)애니메이션(몬스터마다 어떻게?)
        //사운드
        //hp감소

    }

    public void Monster_Damaged(int ATK)
    {
        //player에게 공격당하거나 충돌
        //hp감소(0되면 사망)
        //애니메이션
        //사운드(?)
        monster_hp -= ATK;
        
        if(monster_hp <= 0)
        {
            MonsterDeath();
        }

    }

    public void MonsterDeath()
    {
        //hp 0되면 사망
        //애니메이션
        //아이템(?)떨침(무슨 아이템 떨칠지 리스트)
        //사운드
        
    }
}
