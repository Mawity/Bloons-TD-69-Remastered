using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public PlayableCharacter character;


    // Start is called before the first frame update
    public void Start()
    {
     
    }

    // Update is called once per frame
    public void Update()
    {

        float h = Input.GetAxis("Horizontal");

        Vector2 pos = transform.position;

        pos.x += h * character.Speed * Time.deltaTime;

        transform.position = pos;



    }
}
