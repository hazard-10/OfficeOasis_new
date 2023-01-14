using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintControllerLocation : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] string name;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = GameObject.Find(name).transform.position.ToString();
    }
}
