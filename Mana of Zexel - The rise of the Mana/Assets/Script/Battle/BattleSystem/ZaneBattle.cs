using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZaneBattle : MonoBehaviour
{
    public Animator anizane;
    public Canvas _canvas;

    public int yes_ZaneAttack = 0;
    public int yes_ZaneSkill = 0;

    // Update is called once per frame
    void Update()
    {
        if (yes_ZaneAttack == 1)
        {
            _canvas.sortingOrder = 1;
            anizane.SetTrigger("be6attack");
            yes_ZaneAttack = 0;
            Invoke("delayBE6Done", 1f);
        }
        if (yes_ZaneSkill == 1)
        {
            _canvas.sortingOrder = 1;
            anizane.SetTrigger("be6skill");
            yes_ZaneSkill = 0;
            Invoke("delayBE6Done", 1f);
        }
    }

    void delayBE6Done()
    {
        _canvas.sortingOrder = 3;
    }
}
