using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{

    public Text t1;
    public static int timer = 0;
    public static int noteNumber = 4;
    

    void Start()
    {
        t1 = GetComponent<Text>();
    }


    void Update()
    {
        //timer = noteAppear.noteCount;

        t1.text = timer + "/" + noteNumber;

    }
}