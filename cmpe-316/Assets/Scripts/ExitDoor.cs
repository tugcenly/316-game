using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExitDoor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(Counter.timer < Counter.noteNumber)
            {
                //alert the user
                //4 notu da topla vs
            }
            else
            {
                Destroy(gameObject);
                //SceneManager.LoadScene("YouDied");
            }

        }
    }

}
