using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    public Transform spawnBox;
    public GameObject box;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
            Instantiate(box, transform.position, transform.rotation);
        print("Button Pressed!");
    }


}
