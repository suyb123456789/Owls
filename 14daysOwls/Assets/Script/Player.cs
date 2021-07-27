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
        // ���콺 �Է� + �̵����� �ƴҶ��� �̵�
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
            Debug.Log("�浹");
        }
        if (other.gameObject.tag == "Enemy")
        {
            Attack(other);
        }
    }

    public void Attack(Collision other)
    {
        //player �ӵ�����
        Vector3 vec1 = this.GetComponent<Rigidbody>().velocity;

        if (Vector3.Magnitude(vec1) > speed)
        {
            Debug.Log("�浹");

            //Enemy��ũ��Ʈ ��������
            other.gameObject.GetComponent<Enemy>().Monster_Damaged(atk);
        }
    }

    public void Damaged(int monster_attack)
    {
        //������ ���ݷ� -> �÷��̾��� hp ����
        //ui���� �÷��̾� HP UI UPDATE
        //�ִϸ��̼� ���
        //����
        hp -= monster_attack;
        UIManager.instance.UI_PlayerState.updateHp();

        if(hp <= 0)
        {
            Death_player();
        }
    }

    public void Death_player()//�÷��̾� ����
    {
        //�ִϸ��̼�
        //���� �޽���
        //����

    }

    public void player_Dash()//���
    {
        Speed_Dash_Before = this.GetComponent<Rigidbody>().velocity * 0.3f;
        makeDirectionVector();
        this.GetComponent<Rigidbody>().velocity = direct_vector * 20;
        Invoke("wait", 0.1f);
    }

    public void Hiting()//�������
    {
        
    }
  
    void wait()
    {
        this.GetComponent<Rigidbody>().velocity = Speed_Dash_Before;

    }
}
