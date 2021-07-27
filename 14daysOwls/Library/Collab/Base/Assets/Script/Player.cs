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
    }
    
    public void move()
    {
        is_move = true;
        click_position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
        player_position = this.gameObject.transform.position;
        Vector3 tmpvec = click_position - player_position;
        direct_vector = new Vector2(tmpvec.x, tmpvec.y);
        direct_vector = direct_vector.normalized;

        this.gameObject.GetComponent<Rigidbody>().AddForce(direct_vector*moveforce);

    }

}
