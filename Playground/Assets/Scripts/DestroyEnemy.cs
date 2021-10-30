using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public ParticleSystem hitEffect;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sphere")
        {
            Instantiate(hitEffect, transform.position, transform.rotation);
            gameObject.SetActive(false);
            print("Destroyed!");
        }
    }

}
