using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
//public float x = 0.05f;
//public float y = 0.05f;
//public float z = 0.05f;


    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.05f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.05f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
             transform.Translate(0f, 0f, 0.05f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -0.05f);
        }
        if (Input.GetKey(KeyCode.G))
        {
            transform.Rotate(0f, -1f, 0f);
        }
        if (Input.GetKey(KeyCode.H))
        {
            transform.Rotate(0f, 1f, 0f);
        }
        if (Input.GetKey(KeyCode.T))
        {
            transform.Rotate(-1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.B))
        {
            transform.Rotate(1f, 0f, 0f);
        }
        

        


    }
}
