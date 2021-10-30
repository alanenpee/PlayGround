using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateScript : MonoBehaviour
{
    public GameObject mySphere;
    public float perShotDelay;
    private float timeStamp;
    public bool singleShot, burstShot;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        singleShot = true;
        burstShot = false;
        text.text = "Mode : Single";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            singleShot = true;
            burstShot = false;
            text.text = "Mode : Single";
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            singleShot = false;
            burstShot = true;
            text.text = "Mode : Automatic";
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && singleShot && Time.time > timeStamp)
        {
            Instantiate(mySphere, transform.position, transform.rotation);
            timeStamp = Time.time + perShotDelay + 0.5f;
        }

        else if (Input.GetKey(KeyCode.Mouse0) && burstShot && Time.time > timeStamp)
        {
            timeStamp = Time.time + perShotDelay;
            Instantiate(mySphere, transform.position, transform.rotation);
        }

    }
}
