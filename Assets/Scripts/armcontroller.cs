using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armcontroller : MonoBehaviour
{
    public GameObject arm;
    public int publicspeed;
    public GameObject ch1,ch2,ar1,ar2;
    bool canMove = true;
    public GameObject pausemenuobj;
    private void Update()
    {
        if(arm.GetComponent<Transform>().eulerAngles.z>90 && arm.GetComponent<Transform>().eulerAngles.z < 270)
        {
            ch1.SetActive(false);
            ch2.SetActive(true);
            ar1.SetActive(false);
            ar2.SetActive(true);
        }
        else
        {
            ch1.SetActive(true);
            ch2.SetActive(false);
            ar1.SetActive(true);
            ar2.SetActive(false);
        }
        if (canMove)
        {
            /*
            if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.A)))
            {
                arm.transform.Rotate(new Vector3(0, 0, 1) * publicspeed * privatespeed * Time.deltaTime);
            }
            if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.D)))
            {
                arm.transform.Rotate(new Vector3(0, 0, -1) * publicspeed * privatespeed * Time.deltaTime);
            }
            */
            if (pausemenuobj.GetComponent<PauseMenu>().isGamePaused == false)
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                Vector2 direction = mousePosition - transform.position;
                float angle = Vector2.SignedAngle(Vector2.right, direction);
                transform.eulerAngles = new Vector3(0, 0, angle);
            }
        }

    }
    public void DisableControls()
    {
        canMove = false;

    }
}
