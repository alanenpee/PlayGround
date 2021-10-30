using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopExample : MonoBehaviour
{
    public GameObject[] objects;
    public int number = 4;
    public ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < number; j++)
                {

                    Instantiate(objects[i], transform.position + (new Vector3(i, j, 0)), transform.rotation);
                }
            }
        }
    }
}
