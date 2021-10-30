using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectScript : MonoBehaviour
{
    public TextMeshProUGUI collectText;
    public static int collectCount = 0;

    // Update is called once per frame
    void Update()
    {
        collectText.text = "Shrooms Collected: " + collectCount.ToString();
    }
}
