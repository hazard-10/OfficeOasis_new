using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject leftCtrl;
    public GameObject rightCtrl;

    public GameObject cam;

    private bool displaySet = false;
    
    [SerializeField] GameObject wristDisplay;
    [SerializeField] GameObject itemDisplay;
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

    public GameObject getCam(){
        return cam;
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

        if (!displaySet && leftCtrl){
            setWristDisplay();
            setItemDisplay();
            displaySet = true;
        }
    }

    void setWristDisplay (){
        wristDisplay.GetComponent<FollowTarget>().target = leftCtrl;
        wristDisplay.GetComponent<FollowTarget>().StartFollowing(new Vector3(0.1f, 0f , 0f));
    }
    void setItemDisplay (){
        itemDisplay.GetComponent<FollowTarget>().target = leftCtrl;
        itemDisplay.GetComponent<FollowTarget>().StartFollowing(new Vector3(0.1f, 0.2f , 0f));
    }
}
