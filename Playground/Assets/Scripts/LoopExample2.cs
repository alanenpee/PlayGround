using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopExample2 : MonoBehaviour
{
    public GameObject[] objects;
    public ParticleSystem ps;
    public int number = 4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < number; j++)
                    {

                        Instantiate(objects[i], transform.position + (new Vector3(j, i, 0)), transform.rotation);
                    }
                }
            }
    }
}
