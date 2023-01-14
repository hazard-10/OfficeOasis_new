using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject leftCtrl;
    private GameObject rightCtrl;
    void Start()
    {
        while (leftCtrl == null )
        {
            leftCtrl = GameObject.Find("InteractionModeManager (1)/LeftHand");
        }
        while (leftCtrl == null )
        {
            rightCtrl = GameObject.Find("InteractionModeManager (1)/RightHand");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setWristDisplay (){
        
    }
}
