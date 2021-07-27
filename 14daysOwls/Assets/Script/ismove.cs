using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ismove : MonoBehaviour
{
    public Player player;
    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("Flatform"))
        {
            this.GetComponentInParent<Player>().is_move = false;
        }
    }
 
    
}
