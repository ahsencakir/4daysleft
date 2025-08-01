using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class badguy : MonoBehaviour
{
    //[SerializeField] float gecikme = 0.5f;
    
    public bool hasWin = false;
    public GameObject wonmenu;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mermi" && hasWin == false)
        {
            hasWin = true;
            FindObjectOfType<armcontroller>().DisableControls();

            //Invoke("ReloadScene", gecikme);
            wonmenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
    /*
    void ReloadScene()
    {

        SceneManager.LoadScene(0);
    */
}
