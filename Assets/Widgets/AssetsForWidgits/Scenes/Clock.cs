using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Clock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string time = System.DateTimeOffset.Now.ToString("hh:mm:ss tt");

        GetComponentInChildren<Text>().text = time;
    }
}
