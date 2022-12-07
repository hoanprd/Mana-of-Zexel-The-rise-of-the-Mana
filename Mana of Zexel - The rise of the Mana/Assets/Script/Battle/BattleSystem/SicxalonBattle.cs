using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SicxalonBattle : MonoBehaviour
{
    public Animator anisicxalon;
    public int yes_SicxalonAttack1 = 0;
    public int yes_SicxalonAttack2 = 0;
    public int yes_SicxalonSkillCharge = 0;
    public int yes_SicxalonSkill1 = 0;
    public int yes_SicxalonSkill2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_SicxalonAttack1 == 1)
        {
            anisicxalon.SetTrigger("be5attack1");
            yes_SicxalonAttack1 = 0;
        }
        if (yes_SicxalonAttack2 == 1)
        {
            anisicxalon.SetTrigger("be5attack2");
            yes_SicxalonAttack2 = 0;
        }

        if (yes_SicxalonSkillCharge == 1)
        {
            anisicxalon.SetTrigger("be5skillcharge");
            yes_SicxalonSkillCharge = 0;
        }
        if (yes_SicxalonSkill1 == 1)
        {
            anisicxalon.SetTrigger("be5skill1");
            yes_SicxalonSkill1 = 0;
        }
        if (yes_SicxalonSkill2 == 1)
        {
            anisicxalon.SetTrigger("be5skill2");
            yes_SicxalonSkill2 = 0;
        }
    }
}
