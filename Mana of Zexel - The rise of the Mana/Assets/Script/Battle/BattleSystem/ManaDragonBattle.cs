using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaDragonBattle : MonoBehaviour
{
    public Animator animanadragon;
    public Canvas _canvas;

    public int yes_ManaDragonAttack1 = 0;
    public int yes_ManaDragonAttack2 = 0;
    public int yes_ManaDragonSkillCharge = 0;
    public int yes_ManaDragonSkill = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_ManaDragonAttack1 == 1)
        {
            _canvas.sortingOrder = 1;
            animanadragon.SetTrigger("be3attack1");
            yes_ManaDragonAttack1 = 0;
            Invoke("delayBE3Done", 1f);
        }
        if (yes_ManaDragonAttack2 == 1)
        {
            _canvas.sortingOrder = 1;
            animanadragon.SetTrigger("be3attack2");
            yes_ManaDragonAttack2 = 0;
            Invoke("delayBE3Done", 1f);
        }

        if (yes_ManaDragonSkillCharge == 1)
        {
            animanadragon.SetTrigger("be3skillcharge");
            yes_ManaDragonSkillCharge = 0;
        }
        if (yes_ManaDragonSkill == 1)
        {
            _canvas.sortingOrder = 1;
            animanadragon.SetTrigger("be3skill");
            yes_ManaDragonSkill = 0;
            Invoke("delayBE3Done", 2f);
        }
    }

    void delayBE3Done()
    {
        _canvas.sortingOrder = 3;
    }
}
