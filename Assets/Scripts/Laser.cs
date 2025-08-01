using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UIElements;

public class Laser : MonoBehaviour
{
    public GameObject armcontrollerobj;
    private Transform barrel;
    public Transform rightbarrel, leftbarrel;
    private RaycastHit2D hit;
    private float distance = 15f;
    private LineRenderer line;
    public GameObject scriptexe;
    private void Start()
    {
        line = GetComponent<LineRenderer>();
    }
    private void Update()
    {
        if (armcontrollerobj.GetComponent<armcontroller>().arm.GetComponent<Transform>().eulerAngles.z > 90 && armcontrollerobj.GetComponent<armcontroller>().arm.GetComponent<Transform>().eulerAngles.z < 270)
        {
            barrel = rightbarrel;
        }
        else
        {
            barrel = leftbarrel;
        }
        hit = Physics2D.Raycast(barrel.position, barrel.right,distance);
        line.SetPosition(0, barrel.position);
        line.SetPosition(1, hit.point);
  
       if(Vector3.Distance(barrel.position, hit.point)<=0.2f)
        {
            scriptexe.GetComponent<silah>().canshoot = false;
        }
        else
        {
            scriptexe.GetComponent<silah>().canshoot = true;
        }
    }
}
