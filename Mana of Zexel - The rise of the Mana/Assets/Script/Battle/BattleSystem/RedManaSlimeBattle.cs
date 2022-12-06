using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedManaSlimeBattle : MonoBehaviour
{
    public Animator aniredmanaslime;
    public int yes_RedManaSlime = 0;

    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_RedManaSlime == 1)
        {
            aniredmanaslime.SetTrigger("e7attack");
            yes_RedManaSlime = 0;
        }
    }
}
