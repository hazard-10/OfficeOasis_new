using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    private bool beginFollow = false;

    // Update is called once per frame
    void Update()
    {
        if(beginFollow){
            transform.position = target.transform.position + new Vector3(0.1f, 0 , 0);
        }
    }

    public void StartFollowing(){
        beginFollow = true;
    }
}
