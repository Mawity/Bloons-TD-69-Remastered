using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        speed = 8;
    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");

        Vector2 pos = transform.position;

        pos.x += h * speed * Time.deltaTime;

        transform.position = pos;



    }
}
