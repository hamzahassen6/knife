using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwing : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public float speed;
    public GameObject knife;
    public static bool collided=false;
    // Start is called before the first frame update
    void Start()
    {
        rb = knife.GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = new Vector2(0,10) * speed * Time.deltaTime;
        }
        collided = false;

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "circle")
        {
            Debug.Log(col.name);
            collided = true;
            rb.velocity= new Vector2(0, 10) * 0.25f * (Time.deltaTime +1f);
            knife.GetComponent<throwing>().enabled = false;
            
        }

    }
        

}
