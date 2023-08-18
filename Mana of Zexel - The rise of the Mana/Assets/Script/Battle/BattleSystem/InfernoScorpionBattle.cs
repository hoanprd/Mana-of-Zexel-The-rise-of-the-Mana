using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfernoScorpionBattle : MonoBehaviour
{
    public Animator aniInfernoScorpion;
    public Transform Enemy;
    public Canvas _canvas;

    public int yes_InfernoScorpion = 0;

    // Update is called once per frame
    void Update()
    {
        if (yes_InfernoScorpion == 1)
        {
            Invoke("delayE4", 0.01f);
            yes_InfernoScorpion = 0;
        }
    }

    void delayE4()
    {
        if (BSInfernoScorpion1.E4Hit == 1)
        {
            _canvas.sortingOrder = 1;
            Enemy.position = new Vector2(Enemy.position.x - 3f, Enemy.position.y);
            aniInfernoScorpion.SetTrigger("e4attack");
            Invoke("delayE4Done", 1f);
        }
        else if (BSInfernoScorpion1.E4Hit == 2)
        {
            _canvas.sortingOrder = 1;
            Enemy.position = new Vector2(Enemy.position.x - 5f, Enemy.position.y + 1);
            aniInfernoScorpion.SetTrigger("e4attack");
            Invoke("delayE4Done", 1f);
        }
        else if (BSInfernoScorpion1.E4Hit == 3)
        {
            _canvas.sortingOrder = 1;
            Enemy.position = new Vector2(Enemy.position.x - 6f, Enemy.position.y - 3);
            aniInfernoScorpion.SetTrigger("e4attack");
            Invoke("delayE4Done", 1f);
        }
    }

    void delayE4Done()
    {
        Enemy.position = new Vector2(3.89f, -0.4f);
        _canvas.sortingOrder = 3;
    }
}
