using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{

    public float speed = 2f;
    public float timer = 4f;
    public ParticleSystem PS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            timer = 4f;
            speed = -speed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player")
        {
            gameObject.SetActive(false);
            Instantiate(PS, transform.position, transform.rotation);
        }
    }
}
