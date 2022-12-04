using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaGuardianBattle : MonoBehaviour
{
    public Animator animanaguardian;
    public int yes_ManaGuardianAttack = 0;
    public int yes_ManaGuardianSkillCharge = 0;
    public int yes_ManaGuardianSkill = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_ManaGuardianAttack == 1)
        {
            animanaguardian.SetTrigger("be1attack");
            yes_ManaGuardianAttack = 0;
        }
        if (yes_ManaGuardianSkillCharge == 1)
        {
            animanaguardian.SetTrigger("be1skillcharge");
            yes_ManaGuardianSkillCharge = 0;
        }
        if (yes_ManaGuardianSkill == 1)
        {
            animanaguardian.SetTrigger("be1skill");
            yes_ManaGuardianSkill = 0;
        }
    }
}
