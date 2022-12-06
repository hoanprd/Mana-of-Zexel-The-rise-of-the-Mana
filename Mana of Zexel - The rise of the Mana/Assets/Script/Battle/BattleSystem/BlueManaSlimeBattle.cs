using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueManaSlimeBattle : MonoBehaviour
{
    public Animator anibluemanaslime;
    public int yes_BlueManaSlime = 0;
    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_BlueManaSlime == 1)
        {
            anibluemanaslime.SetTrigger("e9attack");
            yes_BlueManaSlime = 0;
        }
    }
}
