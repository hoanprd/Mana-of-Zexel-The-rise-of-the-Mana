using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutManaCliff : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus94 == 0)
        {
            CutTrigger2.SetActive(false);
        }

        if (CutscenesController.cus94 == 1)
        {
            Destroy(CutTrigger1);
        }
        if (CutscenesController.cus110 == 1)
        {
            Destroy(CutTrigger2);
        }
    }
}
