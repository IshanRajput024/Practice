using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
       if(Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 14, 0);
        }

        if (Input.GetKeyDown("d"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(15, 0, 0);
        }
        if (Input.GetKeyDown("a"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-15, 0, 0);
        }
    }
}
