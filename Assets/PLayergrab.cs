using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayergrab : MonoBehaviour
{
    public GameObject myhand;
    public GameObject kabel2;
    public GameObject pilihan;
    public GameObject Socket;
    public GameObject tester;
   
    public Animator crip;
    bool canCrip = true;
    bool active = false;
    bool soket = false;

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

    public void Chose()
    {
        if (active == false)
        {
            pilihan.gameObject.SetActive(true);
        }
        else
        {
            pilihan.gameObject.SetActive(false);
        }
    }

    public void second()
    {
        if (soket == false)
        {
            Socket.gameObject.SetActive(true);
        }
        DontDestroyOnLoad(this.gameObject);
    }


    public void setActive(bool condition)
    {
        Gr.enabled = condition;
    }

    public void ethernet()
    {
        tester.gameObject.SetActive(true);
    }
}
