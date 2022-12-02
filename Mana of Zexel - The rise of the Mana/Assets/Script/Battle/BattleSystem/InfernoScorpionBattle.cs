using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfernoScorpionBattle : MonoBehaviour
{
    public Animator aniInfernoScorpion;
    public int yes_InfernoScorpion = 0;
    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_InfernoScorpion == 1)
        {
            aniInfernoScorpion.SetTrigger("e4attack");
            yes_InfernoScorpion = 0;
        }
    }
}
