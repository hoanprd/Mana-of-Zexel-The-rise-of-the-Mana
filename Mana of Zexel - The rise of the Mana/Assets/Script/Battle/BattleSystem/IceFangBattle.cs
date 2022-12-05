using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceFangBattle : MonoBehaviour
{
    public Animator aniicefang;
    public int yes_IceFang = 0;

    // Update is called once per frame
    void Update()
    {
        if (yes_IceFang == 1)
        {
            aniicefang.SetTrigger("e8attack");
            yes_IceFang = 0;
        }
    }
}
