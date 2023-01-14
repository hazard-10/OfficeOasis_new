using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wave.Native;
using Wave.Essence;
using UnityEngine.UI;

public class Draggable : MonoBehaviour
{
    // Start is called before the first frame update

    //public float cameraDistance =  1; 

    //public float maxGrabDistance = 2;
    public GameObject cube; 
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
        
    }

    void OnCollisionEnter(Collision collision)
    {
        text.text = "call";
        if (WXRDevice.ButtonPress(WVR_DeviceType.WVR_DeviceType_Controller_Right, WVR_InputId.WVR_InputId_Alias1_Trigger)){
            cube.SetActive(false);
            text.text = "left";

        }
        else if(WXRDevice.ButtonPress(WVR_DeviceType.WVR_DeviceType_Controller_Left, WVR_InputId.WVR_InputId_Alias1_Trigger)){
            cube.SetActive(false);
            text.text = "right";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
