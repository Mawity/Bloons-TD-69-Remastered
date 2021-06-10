using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySwitching : MonoBehaviour
{
    private int actualMonkey = 0;
    private int previousMonkey = 0;

    public int ActualMonkey
    {
        get
        {
            return actualMonkey;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SelectMonkey();
    }

    // Update is called once per frame
    void Update()
    {
        previousMonkey = actualMonkey;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            actualMonkey = 0;
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            actualMonkey = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            actualMonkey = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
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

    public PlayableCharacter GetActualMonkey()
    {
        int i = 0;
        foreach (Transform monkey in transform)
        {
            if (i == actualMonkey)
            {
                return monkey.gameObject;
            }
            i++;
        }

        return null;
    }
}
