using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronGolemnBattle : MonoBehaviour
{
    public Animator anigolemn;
    public int yes_IronGolemnAttack = 0;
    public int yes_IronGolemnSkill = 0;

    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_IronGolemnAttack == 1)
        {
            anigolemn.SetTrigger("be4attack");
            yes_IronGolemnAttack = 0;
        }
        if (yes_IronGolemnSkill == 1)
        {
            anigolemn.SetTrigger("be4skill");
            yes_IronGolemnSkill = 0;
        }
    }
}
