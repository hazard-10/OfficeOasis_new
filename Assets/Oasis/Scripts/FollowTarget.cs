using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    private bool beginFollow = false;
    private Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        if(beginFollow){
            transform.position = target.transform.position + offset;
        }
    }

    public void StartFollowing(Vector3 offs){
        beginFollow = true;
        offset = offs;
    }
}
