using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBehavior : MonoBehaviour
{

    Ray ray;
    RaycastHit hit;
    PLayergrab pl;
    [SerializeField]
    Transform pointer;
    // Start is called before the first frame update
    void Start()
    {
        pl = GameObject.Find("Player").GetComponent<PLayergrab>();   
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))
        {
            if (hit.collider.tag == "Kabel")
            {
                Debug.Log("Kena kabel");
                pl.Grab();
              //  SceneManager.LoadScene("scena2stanza");
            }
            if(hit.collider.tag == "AlatKrip")
            {
                Debug.Log("Kena Alat Krip");
                pl.CripGo();
            }
            if(hit.collider.tag  == "socket")
            {

            }    
        }
    }
}
