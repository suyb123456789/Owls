using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int hp;
    public int mp;
    public int atk;

    public float mp_recovery_time;

    public Vector3 click_position;
    public Vector3 player_position;
    public Vector2 direct_vector;

    public float moveforce;
    public bool is_move;

    public bool is_click;

    public float speed = 3f;

    public Vector3 Speed_Dash_Before;
    

    private void Start()
    {
        hp = 3;
        mp = 1;
        atk = 1;
        moveforce = 100f;
        is_move = false;
    }
    private void Update()
    {
        // 마우스 입력 + 이동중이 아닐때만 이동
        if (Input.GetMouseButtonDown(0)&&!is_move)
        {
            move();
        }
        if (Input.GetMouseButton(1))
        {
            player_Dash();
        }
    }
    
    public void move()
    {
        is_move = true;
        makeDirectionVector();
        this.gameObject.GetComponent<Rigidbody>().AddForce(direct_vector*moveforce);

    }
    public void makeDirectionVector()
    {
        click_position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
        player_position = this.gameObject.transform.position;
        Vector3 tmpvec = click_position - player_position;
        direct_vector = new Vector2(tmpvec.x, tmpvec.y);
        direct_vector = direct_vector.normalized;
    }

    public void OnColisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("충돌");
        }
        if (other.gameObject.tag == "Enemy")
        {
            Attack(other);
        }
    }

    public void Attack(Collision other)
    {
        //player 속도벡터
        Vector3 vec1 = this.GetComponent<Rigidbody>().velocity;

        if (Vector3.Magnitude(vec1) > speed)
        {
            Debug.Log("충돌");

            //Enemy스크립트 가져오기
            other.gameObject.GetComponent<Enemy>().Monster_Damaged(atk);
        }
    }

    public void Damaged(int monster_attack)
    {
        //몬스터의 공격력 -> 플레이어의 hp 감소
        //ui에서 플레이어 HP UI UPDATE
        //애니메이션 출력
        //사운드
        hp -= monster_attack;
        UIManager.instance.UI_PlayerState.updateHp();

        if(hp <= 0)
        {
            Death_player();
        }
    }

    public void Death_player()//플레이어 죽음
    {
        //애니메이션
        //죽음 메시지
        //사운드

    }

    public void player_Dash()//대시
    {
        Speed_Dash_Before = this.GetComponent<Rigidbody>().velocity * 0.3f;
        makeDirectionVector();
        this.GetComponent<Rigidbody>().velocity = direct_vector * 20;
        Invoke("wait", 0.1f);
    }

    public void Hiting()//내려찍기
    {
        
    }
  
    void wait()
    {
        this.GetComponent<Rigidbody>().velocity = Speed_Dash_Before;

    }
}
