using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwing : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public float speed;
    public GameObject knife;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = new Vector2(0,10) * speed * Time.deltaTime;
        }


    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.name == "circle")
        {
            Destroy(gameObject);
            Instantiate(knife, GameManager.defaultpos);
        } 
         
    }

}
