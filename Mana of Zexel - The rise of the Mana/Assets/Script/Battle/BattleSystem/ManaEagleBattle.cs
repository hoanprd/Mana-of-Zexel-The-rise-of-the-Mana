using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaEagleBattle : MonoBehaviour
{
    public Animator animanaeagle;
    public Transform Enemy;
    public Canvas _canvas;

    public int yes_ManaEagle = 0;

    // Update is called once per frame
    void Update()
    {
        if (yes_ManaEagle == 1)
        {
            Invoke("delayE10", 0.01f);
            yes_ManaEagle = 0;
        }
    }

    void delayE10()
    {
        if (BSManaEagle1.E10Hit == 1)
        {
            _canvas.sortingOrder = 1;
            Enemy.position = new Vector2(Enemy.position.x - 3f, Enemy.position.y);
            animanaeagle.SetTrigger("e10attack");
            Invoke("delayE10Done", 1f);
        }
        else if (BSManaEagle1.E10Hit == 2)
        {
            _canvas.sortingOrder = 1;
            Enemy.position = new Vector2(Enemy.position.x - 5f, Enemy.position.y + 1);
            animanaeagle.SetTrigger("e10attack");
            Invoke("delayE10Done", 1f);
        }
        else if (BSManaEagle1.E10Hit == 3)
        {
            _canvas.sortingOrder = 1;
            Enemy.position = new Vector2(Enemy.position.x - 6f, Enemy.position.y - 3);
            animanaeagle.SetTrigger("e10attack");
            Invoke("delayE10Done", 1f);
        }
    }

    void delayE10Done()
    {
        Enemy.position = new Vector2(3.89f, -0.4f);
        _canvas.sortingOrder = 3;
    }
}
