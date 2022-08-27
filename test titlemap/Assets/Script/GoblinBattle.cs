using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinBattle : MonoBehaviour
{
    public Animator anigoblin;
    public int yes_goblin=0;
    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_goblin == 1)
        {
            anigoblin.SetTrigger("e2attack");
            yes_goblin = 0;
        }
    }
}
