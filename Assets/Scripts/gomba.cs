using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomba : MonoBehaviour
{
    float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float v = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }
}
