using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleDelay : MonoBehaviour
{
    private float timer;
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= 1)
        {
            Destroy(gameObject);
        }

    }
    
}
