using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaEagleBattle : MonoBehaviour
{
    public Animator animanaeagle;
    public int yes_ManaEagle = 0;

    // Update is called once per frame
    void Update()
    {
        if (yes_ManaEagle == 1)
        {
            animanaeagle.SetTrigger("e10attack");
            yes_ManaEagle = 0;
        }
    }
}
