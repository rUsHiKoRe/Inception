using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject Plane;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody>().angularVelocity = new Vector3(-0.5f,0,0);
        this.transform.LookAt(Plane.transform);
    }

    // Update is called once per frame
    void Update()
    {
        //up : y axis
        //forward:z axis
        
        
    }
}
