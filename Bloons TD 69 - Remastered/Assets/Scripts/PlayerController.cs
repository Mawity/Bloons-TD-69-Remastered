using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayableCharacter activeMonkey;


    // Start is called before the first frame update
    public void Start()
    {
        GameObject original = GameObject.Find("MainObj");
        GameObject monkeyTeam = original.transform.GetChild(0).gameObject;
        GameObject tempActiveMonkey = monkeyTeam.transform.GetChild(monkeyTeam.GetComponent<MonkeySwitching>().ActualMonkey).gameObject;
        
        if(tempActiveMonkey != null)
        {
            activeMonkey = tempActiveMonkey.GetComponent<PlayableCharacter>();
        }
    }

    // Update is called once per frame
    public void Update()
    {
        Move();



    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 pos = transform.position;
        pos.x += h * activeMonkey.Speed * Time.deltaTime;
        transform.position = pos;
    }
}
