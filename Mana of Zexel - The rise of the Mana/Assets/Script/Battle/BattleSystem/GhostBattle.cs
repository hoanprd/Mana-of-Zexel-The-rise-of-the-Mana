using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBattle : MonoBehaviour
{
    public Animator anighost;
    public int yes_Ghost = 0;

    // Update is called once per frame
    void Update()
    {
        if (yes_Ghost == 1)
        {
            anighost.SetTrigger("e10attack");
            yes_Ghost = 0;
        }
    }
}
