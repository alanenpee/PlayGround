using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject mySphere;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButton("Jump"))
        {
            Instantiate(mySphere, transform.position, transform.rotation);
        }

        else if (Input.GetButtonDown("Jump"))
        {
            Instantiate(mySphere, transform.position, transform.rotation);
        }

    }
}
