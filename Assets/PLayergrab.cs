using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayergrab : MonoBehaviour
{
    public GameObject myhand;
    public GameObject kabel2;
    public Animator crip;
    bool canCrip = true;
    Ray ray;
    RaycastHit hit;
    PLayergrab Gr;
    // bool kabel, kriping, pasangkabel;
    // Start is called before the first frame update
    void Start()
    {
        Gr = GetComponent<PLayergrab>();
        Gr.enabled = false;
    }

    // Update is called once per frame  
    void Update()
    {

        
        
    }

    public void CripGo()
    {
        crip.Play("rotasi");
    }

    public void Grab()
    {
        kabel2.transform.SetParent(myhand.transform);
        kabel2.transform.localPosition = new Vector3(121f, -26f, 205f);
    }

    public void Choose()
    {

    }

    public void setActive(bool condition)
    {
        Gr.enabled = condition;
    }
}
