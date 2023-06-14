using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZaneBattle : MonoBehaviour
{
    public Animator anizane;
    public int yes_ZaneAttack = 0;
    public int yes_ZaneSkill = 0;

    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_ZaneAttack == 1)
        {
            anizane.SetTrigger("be6attack");
            yes_ZaneAttack = 0;
        }
        if (yes_ZaneSkill == 1)
        {
            anizane.SetTrigger("be6skill");
            yes_ZaneSkill = 0;
        }
    }
}
