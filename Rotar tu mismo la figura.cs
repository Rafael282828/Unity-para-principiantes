using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    float deltaRotation = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        
        
    }
    void Rotate ()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(new Vector3(0f, -deltaRotation, 0f) * Time.deltaTime);
        else if (Input.GetKey(KeyCode.D))
            transform.Rotate(new Vector3(0f, deltaRotation, 0f) * Time.deltaTime);
    }
}
