using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Onclick : MonoBehaviour
{
    public GameObject Canvas;

    public void OpenCanvas()
    {
        if(Canvas !=null)
        {
            Canvas.SetActive(true);
        }
    }

}
