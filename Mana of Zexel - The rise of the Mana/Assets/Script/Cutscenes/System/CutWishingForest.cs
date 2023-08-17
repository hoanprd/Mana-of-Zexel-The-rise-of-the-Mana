using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutWishingForest : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2, CutTrigger3, CutTrigger4, ManaWater;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus13 == 0)
        {
            CutTrigger2.SetActive(false);
        }
        if (CutscenesController.cus15 == 0)
        {
            CutTrigger3.SetActive(false);
        }
        if (CutscenesController.cus81 == 0)
        {
            CutTrigger4.SetActive(false);
        }

        if (CutscenesController.cus13 == 1)
        {
            Destroy(CutTrigger1);
        }
        if (CutscenesController.cus15 == 1)
        {
            Destroy(CutTrigger2);
        }
        if (CutscenesController.cus81 == 1)
        {
            Destroy(CutTrigger3);
        }
        if (CutscenesController.cus124 == 1)
        {
            Destroy(CutTrigger4);
        }

        if (CutscenesController.cus81 == 0 || (CutscenesController.cus81 == 1 && CutscenesController.cus82 == 1))
        {
            Destroy(ManaWater);
        }
    }
}
