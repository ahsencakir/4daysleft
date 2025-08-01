using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colortransition : MonoBehaviour
{
    public SpriteRenderer objcol;
    public Color[] colors;
    private int currentcolor = 0;
    private int targetcolor = 1;
    private float targetpoint;
    private void Update()
    {
        targetpoint = targetpoint + Time.deltaTime;
        objcol.color = Color.Lerp(colors[currentcolor], colors[targetcolor], targetpoint);
        if (targetpoint >= 1f)
        {
            targetpoint = 0f;
            currentcolor = targetcolor;
            targetcolor++;
            if (targetcolor == colors.Length)
            {
                targetcolor = 0;
            }
        }
    }
}
