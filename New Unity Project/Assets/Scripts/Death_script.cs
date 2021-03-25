using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_script : MonoBehaviour
{
    public static bool PlayerIsDeath = false;
    
    void Update()
    {
        if(PlayerIsDeath == true)
        {
            Pause_script.Pause();
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("obstacle"))
        {
            PlayerIsDeath = true;
        }
    }
    
}
