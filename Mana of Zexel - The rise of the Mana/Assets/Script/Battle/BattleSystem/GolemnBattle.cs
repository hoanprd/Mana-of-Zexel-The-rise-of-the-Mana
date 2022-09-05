using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemnBattle : MonoBehaviour
{
    public Animator anigolemn;
    public int yes_golemn=0;
    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_golemn == 1)
        {
            anigolemn.SetTrigger("e3attack");
            yes_golemn = 0;
        }
    }
}
