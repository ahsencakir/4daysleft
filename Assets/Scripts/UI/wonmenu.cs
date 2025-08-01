using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wonmenu : MonoBehaviour
{
    public void back_btn()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
