using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelselect : MonoBehaviour
{
    public GameObject mainmenu,levelselectscene;
    public void level1_btn()
    {
        SceneManager.LoadScene("level1");
    }
    public void level2_btn()
    {
        SceneManager.LoadScene("level2");
    }
    public void level3_btn()
    {
        SceneManager.LoadScene("level3");
    }
    public void level4_btn()
    {
        SceneManager.LoadScene("level4");
    }
    public void level5_btn()
    {
        SceneManager.LoadScene("level5");
    }
    public void level6_btn()
    {
        SceneManager.LoadScene("level6");
    }
    public void back_btn()
    {
        mainmenu.SetActive(true);
        levelselectscene.SetActive(false);
    }
}
