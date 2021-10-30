using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 rotation;
    public float sensitivity = .5f;
    public Transform spawnPoint;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * vertical * speed * Time.deltaTime);
        Mouse();
        Spawn();
    }

    private void Mouse()
    {
        rotation.x += Input.GetAxis("Mouse X") * sensitivity;
        //rotation.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(0, rotation.x, 0);
    }

    private void Spawn()
    {
        if (transform.position.y < -5f)
        {
            transform.position = spawnPoint.position;
        }
    }
}

