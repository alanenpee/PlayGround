using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Rendering.Universal;

public class UnderWaterDetection : MonoBehaviour
{
    public PostProcessVolume post;
    public GameObject player;
    public GameObject water;
    public bool isUnderWater;



    private void Update()
    {
        if(player.transform.position.y <= water.transform.position.y)
        {
            isUnderWater = true;
        }

        else
        {
            isUnderWater = false;
            post.enabled = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Water" && isUnderWater)
        {
            post.enabled = true;
        }
    }
}
