using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject leftCtrl;
    public GameObject rightCtrl;

    private bool wristSet = false;
    
    [SerializeField] GameObject wristDisplay;
    void Start()
    {
        // while (leftCtrl == null )
        // {
            leftCtrl = GameObject.Find("LeftPointer");
        // }
        // while (leftCtrl == null )
        // {
            rightCtrl = GameObject.Find("RightPointer");
        // }
    }

    // Update is called once per frame
    void Update()
    {
        if (leftCtrl == null )
        {
            leftCtrl = GameObject.Find("LeftPointer");
        }
        if (rightCtrl == null )
        {
            rightCtrl = GameObject.Find("RightPointer");
        }

        if (!wristSet && leftCtrl){
            setWristDisplay();
            wristSet = true;
        }
    }

    void setWristDisplay (){
        wristDisplay.GetComponent<FollowTarget>().target = leftCtrl;
        wristDisplay.GetComponent<FollowTarget>().StartFollowing();
    }
}
