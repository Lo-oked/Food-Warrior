using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slicer : MonoBehaviour
{
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        var worldpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldpos.z = 0;
        //transform.position = worldpos;
        rb.MovePosition(worldpos);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        print(":");
        Destroy(collision.gameObject);
    }
}
