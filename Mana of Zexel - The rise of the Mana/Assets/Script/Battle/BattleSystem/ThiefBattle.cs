using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThiefBattle : MonoBehaviour
{
    public Animator anithief;
    public int yes_thief=0;
    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_thief == 1)
        {
            anithief.SetTrigger("e1attack");
            yes_thief = 0;
        }
    }
}
