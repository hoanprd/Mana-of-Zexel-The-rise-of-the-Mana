using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFangBattle : MonoBehaviour
{
    public Animator anifirefang;
    public int yes_FireFang = 0;

    // Update is called once per frame
    void Update()
    {
        if (yes_FireFang == 1)
        {
            anifirefang.SetTrigger("e7attack");
            yes_FireFang = 0;
        }
    }
}
