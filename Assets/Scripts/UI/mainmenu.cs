using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public GameObject mainmenuscene, levelselectscene;
    public void Play_btn()
    {
        levelselectscene.SetActive(true);
        mainmenuscene.SetActive(false);
    }
    public void exitbtn()
    {
        Application.Quit();
    }
}
