using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject knife;
    public Transform circle;

    public static Vector3 defaultpos = new Vector3 (0,-4,0);



    // Start is called before the first frame update
    void Start()
    {
        Instantiate(knife, defaultpos,Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (throwing.collided== true)
        {
            Debug.Log("collided");
            knife.transform.SetParent(circle);
            
            Instantiate(knife, defaultpos, Quaternion.identity);
        }
        
    }

   








}
