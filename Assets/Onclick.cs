using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Onclick : MonoBehaviour
{
    public GameObject cameraobject;
    public GameObject maincamera;

    bool click = true;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && click == false)
        {
            //click = true;
            maincamera.transform.position = cameraobject.transform.position;
            Debug.Log(maincamera.transform.position);
            Debug.Log(cameraobject.transform.position);
        }
    }

    

}
