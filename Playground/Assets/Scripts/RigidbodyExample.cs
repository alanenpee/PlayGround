using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 1500f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
