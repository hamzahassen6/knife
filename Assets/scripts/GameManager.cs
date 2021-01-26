using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject knife;
    public static Transform defaultpos;



    // Start is called before the first frame update
    void Start()
    {
        Instantiate(knife, defaultpos);
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

   








}
