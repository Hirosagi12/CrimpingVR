using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lampobject : MonoBehaviour
{
    public GameObject[] lamp1;
    public GameObject[] lamp2;

    public ColorBlock colorblock;

    private float Countdown;
    public float waktu = 1;

    public bool nyala;
    int i = 0;

    void Start()
    {
        Countdown = waktu;

        colorblock = lamp1[0].GetComponent<Button>().colors;
        colorblock.normalColor = Color.white;

    }

    // Update is called once per frame
    void Update()
    {
        lampunyala();
    }

    public void turnon()
    {
        nyala = true;
    }

    public void lampunyala()
    {
        if (nyala && i < lamp1.Length) {
            Countdown -= Time.deltaTime;

            if (Countdown <= 0)
            {
                lamp1[i].GetComponent<Button>().colors= colorblock;
                lamp2[i].GetComponent<Button>().colors = colorblock;

                i++;

                Countdown = waktu;
            }

        }
    }
}
