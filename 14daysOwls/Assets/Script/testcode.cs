using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testcode : MonoBehaviour
{
    private int maxhp = 3;
    private int maxmp = 3;
    private int hp = 3;
    private int mp = 3;

    public int HP{
        get { return hp; }
        set { hp += value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(10f * Time.deltaTime, 0, 0);

    }
    public void OnMouseDown()
    {
       

    }

}
