using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NoteAppear : MonoBehaviour
{
    [SerializeField]
    private Image noteImage;
    public Text noteText ;
    
    void Start()
    {
        noteText.enabled = false;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            noteImage.enabled = true;
            noteText.enabled = true;

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")){
            noteImage.enabled = false;
            noteText.enabled = false;
        }
    }
}
