using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThiefBattle : MonoBehaviour
{
    public Animator anithief;
    public Transform Enemy;

    public int yes_thief;

    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
        yes_thief = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_thief == 1)
        {
            Invoke("delayE1", 0.01f);
            yes_thief = 0;
        }
    }

    void delayE1()
    {
        if (BSThief1.E1Hit == 1)
        {
            Enemy.position = new Vector2(Enemy.position.x - 5f, Enemy.position.y);
            anithief.SetTrigger("e1attack");
            Invoke("delayE1Done", 1f);
        }
        else if (BSThief1.E1Hit == 2)
        {
            Enemy.position = new Vector2(Enemy.position.x - 7f, Enemy.position.y + 2);
            anithief.SetTrigger("e1attack");
            Invoke("delayE1Done", 1f);
        }
        else if (BSThief1.E1Hit == 3)
        {
            Enemy.position = new Vector2(Enemy.position.x - 8f, Enemy.position.y - 2);
            anithief.SetTrigger("e1attack");
            Invoke("delayE1Done", 1f);
        }
    }

    void delayE1Done()
    {
        Enemy.position = new Vector2(4.19f, -0.45f);
    }
}
