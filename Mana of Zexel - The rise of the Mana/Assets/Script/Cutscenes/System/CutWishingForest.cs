using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutWishingForest : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2, ManaWater;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus13 == 0)
        {
            CutTrigger2.SetActive(false);
        }

        if (CutscenesController.cus13 == 1)
        {
            Destroy(CutTrigger1);
        }
        else if (CutscenesController.cus15 == 1)
        {
            Destroy(CutTrigger2);
        }

        if (CutscenesController.cus81 == 0 || (CutscenesController.cus81 == 1 && CutscenesController.cus82 == 1))
        {
            Destroy(ManaWater);
        }
    }
}
