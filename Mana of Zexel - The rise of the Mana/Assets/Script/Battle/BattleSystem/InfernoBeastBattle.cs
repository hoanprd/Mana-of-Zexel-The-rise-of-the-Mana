using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfernoBeastBattle : MonoBehaviour
{
    public Animator aniinfernobeast;
    public Canvas _canvas;

    public int yes_InfernoBeastAttack1 = 0;
    public int yes_InfernoBeastAttack2 = 0;
    public int yes_InfernoBeastSkillCharge = 0;
    public int yes_InfernoBeastSkill = 0;

    // Update is called once per frame
    void Update()
    {
        if (yes_InfernoBeastAttack1 == 1)
        {
            _canvas.sortingOrder = 1;
            aniinfernobeast.SetTrigger("be2attack1");
            yes_InfernoBeastAttack1 = 0;
            Invoke("delayBE2Done", 1f);
        }
        if (yes_InfernoBeastAttack2 == 1)
        {
            _canvas.sortingOrder = 1;
            aniinfernobeast.SetTrigger("be2attack2");
            yes_InfernoBeastAttack2 = 0;
            Invoke("delayBE2Done", 1f);
        }

        if (yes_InfernoBeastSkillCharge == 1)
        {
            aniinfernobeast.SetTrigger("be2skillcharge");
            yes_InfernoBeastSkillCharge = 0;
        }
        if (yes_InfernoBeastSkill == 1)
        {
            _canvas.sortingOrder = 1;
            aniinfernobeast.SetTrigger("be2skill");
            yes_InfernoBeastSkill = 0;
            Invoke("delayBE2Done", 1f);
        }
    }

    void delayBE2Done()
    {
        _canvas.sortingOrder = 3;
    }
}
