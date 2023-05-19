using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutManaCliff : MonoBehaviour
{
    public GameObject CutTrigger1;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus99 == 1)
        {
            Destroy(CutTrigger1);
        }
    }
}
