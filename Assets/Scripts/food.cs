using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 10);
    }

    
    void Update()
    {
        if (transform.position.y < -6)
        {
            print("you failed");
            Destroy(gameObject);
        }
    }
}
