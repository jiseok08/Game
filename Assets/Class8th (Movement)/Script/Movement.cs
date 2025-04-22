using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(1,1,1);
        Debug.Log(transform.position);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.position.y++;
            Debug.Log(transform.position);
        }
    }
}
