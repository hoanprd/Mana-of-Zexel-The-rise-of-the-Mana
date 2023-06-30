using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagGlobal : MonoBehaviour
{
    public void MainFlagDisplay(int a, int b, GameObject flag)
    {
        if (a == 0 && b == 1)
        {
            flag.SetActive(true);
        }
        else
        {
            flag.SetActive(false);
        }
    }
}
