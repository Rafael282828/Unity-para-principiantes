using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float deltaMovement = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        Movement();
        
        
    }
 
    void Movement()
    {
        if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * deltaMovement * Time.deltaTime);
        else if (Input.GetKey(KeyCode.S)| Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * deltaMovement * Time.deltaTime);
        else if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * deltaMovement * Time.deltaTime);
        else if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * deltaMovement * Time.deltaTime);




    }
}
