﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
     public Rigidbody2D rb ;
     public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
       // rb.transform.Rotate(new Vector3(0, 0, 2) * speed * Time.deltaTime);
        rb.AddTorque(  speed );
    }
}
