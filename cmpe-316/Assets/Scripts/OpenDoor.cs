using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenDoor : MonoBehaviour
{
    private bool IsAtDoor = false;

    [SerializeField] private TextMeshProUGUI CodeText;
    string codeTextValue = "";
    public string safeCode;
    public GameObject CodePanel;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        CodeText.text = codeTextValue;
        if(codeTextValue == safeCode)
        {
            CodePanel.SetActive(false);
            Destroy(CodePanel); 
            Destroy(gameObject);
            
            
        }

        if(codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }

        if(IsAtDoor == true)
        {
            CodePanel.SetActive(true);

        }
    }

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
        CodePanel.SetActive(false);

    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;

    }
}

