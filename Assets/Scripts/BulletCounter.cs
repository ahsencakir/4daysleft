using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BulletCounter : MonoBehaviour
{
    private GameObject badguy;
    private float timer;
    private GameObject lostmenuobj;
    public GameObject gun;
    private void Start()
    {
        badguy = GameObject.FindGameObjectWithTag("badguy");
        lostmenuobj = GameObject.FindGameObjectWithTag("lostmenu");

    }
    private void Update()
    {
        
        if (gun.GetComponent<silah>().bulletcount>=6)
        {
            timer = timer + Time.deltaTime;
            if (badguy.GetComponent<badguy>().hasWin == false && timer >= 5)
            {
                lostmenuobj.GetComponent<lostmenu>().lostobj.SetActive(true);
                lostmenuobj.GetComponent<lostmenu>().youshootys.SetActive(false);
                lostmenuobj.GetComponent<lostmenu>().outofbullets.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}