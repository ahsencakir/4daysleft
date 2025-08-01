using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoothimself : MonoBehaviour
{
    private GameObject lostmenuobj;
    private void Awake()
    {
        Time.timeScale = 1;
    }
    private void Start()
    {
        lostmenuobj = GameObject.FindGameObjectWithTag("lostmenu");

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mermi")
        {
            FindObjectOfType<armcontroller>().DisableControls();
            lostmenuobj.GetComponent<lostmenu>().lostobj.SetActive(true);
            lostmenuobj.GetComponent<lostmenu>().youshootys.SetActive(true);
            lostmenuobj.GetComponent<lostmenu>().outofbullets.SetActive(false);
            Time.timeScale = 0;
        }
    }
}
