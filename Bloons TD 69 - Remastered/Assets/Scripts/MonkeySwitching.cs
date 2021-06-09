using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySwitching : MonoBehaviour
{
    private int actualMonkey = 0;
    private int previousMonkey = 0;


    // Start is called before the first frame update
    void Start()
    {
        SelectMonkey();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            previousMonkey = actualMonkey;
            actualMonkey = 0;
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            previousMonkey = actualMonkey;
            actualMonkey = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            previousMonkey = actualMonkey;
            actualMonkey = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            previousMonkey = actualMonkey;
            actualMonkey = 3;
        }

        if(previousMonkey != actualMonkey)
        {
            SelectMonkey();
        }
    }


    void SelectMonkey()
    {
        int i = 0;
        foreach(Transform monkey in transform)
        {
            if (i == actualMonkey)
            {
                monkey.gameObject.SetActive(true);
            }
            else
            {
                monkey.gameObject.SetActive(false);
            }

            i++;
        }
    }
}
