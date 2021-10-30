using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    //public string[] characterName;
    public GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {

        //Instantiate(objects[0], transform.position, transform.rotation); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objects[Random.Range(0,3)], transform.position, transform.rotation);
        }
    }
}
