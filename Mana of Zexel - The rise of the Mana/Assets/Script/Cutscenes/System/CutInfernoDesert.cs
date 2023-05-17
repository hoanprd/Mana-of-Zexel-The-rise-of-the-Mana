using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInfernoDesert : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2, CutTrigger3, CutTrigger4, CutTrigger5, CutTrigger6, InfernoDesertLake;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus127 == 1)
        {
            InfernoDesertLake.SetActive(true);
        }

        if (CutscenesController.cus37 == 0)
        {
            CutTrigger2.SetActive(false);
        }
        if (CutscenesController.cus38 == 0)
        {
            CutTrigger3.SetActive(false);
        }
        if (CutscenesController.cus90 == 0)
        {
            CutTrigger4.SetActive(false);
        }
        if (CutscenesController.cus100 == 0)
        {
            CutTrigger5.SetActive(false);
        }
        if (CutscenesController.cus108 == 0)
        {
            CutTrigger6.SetActive(false);
        }

        if (CutscenesController.cus37 == 1)
        {
            Destroy(CutTrigger1);
        }
        if (CutscenesController.cus38 == 1)
        {
            Destroy(CutTrigger2);
        }
        if (CutscenesController.cus90 == 1)
        {
            Destroy(CutTrigger3);
        }
        if (CutscenesController.cus100 == 1)
        {
            Destroy(CutTrigger4);
        }
        if (CutscenesController.cus108 == 1)
        {
            Destroy(CutTrigger5);
        }
        if (CutscenesController.cus114 == 1)
        {
            Destroy(CutTrigger6);
        }
    }
}
