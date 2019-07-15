using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeobject : MonoBehaviour
{
    public GameObject cameraobject;
    public GameObject maincamera;

    bool click = true;

    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            maincamera.transform.position = cameraobject.transform.position;
            Debug.Log(maincamera.transform.position);
            Debug.Log(cameraobject.transform.position);
        }
    }
}
