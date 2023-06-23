using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor2 : MonoBehaviour
{
    private bool IsAtDoor = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
       // if (IsAtDoor == true) // ve key i aldýysa
        if(Input.GetKey(KeyCode.E)){
            Destroy(gameObject);

        }
    }

    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            IsAtDoor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        IsAtDoor = false;
        

    }
    */
}
