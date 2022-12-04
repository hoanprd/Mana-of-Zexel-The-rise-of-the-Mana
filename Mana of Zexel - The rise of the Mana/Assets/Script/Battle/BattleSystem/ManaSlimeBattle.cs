using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaSlimeBattle : MonoBehaviour
{
    public Animator animanaslime;
    public int yes_ManaSlime = 0;
    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_ManaSlime == 1)
        {
            animanaslime.SetTrigger("e5attack");
            yes_ManaSlime = 0;
        }
    }
}
