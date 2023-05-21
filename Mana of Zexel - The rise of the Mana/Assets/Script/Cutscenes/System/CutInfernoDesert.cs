using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInfernoDesert : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2, CutTrigger3, CutTrigger4, CutTrigger5, CutTrigger6, CutTrigger7, InfernoDesertLake, MainFlag;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus127 == 1)
        {
            InfernoDesertLake.SetActive(true);
        }
        if (CutscenesController.cus127 == 0 && CutscenesController.cus126 == 1)
        {
            MainFlag.SetActive(true);
        }

        if (CutscenesController.cus37 == 0)
        {
            CutTrigger2.SetActive(false);
        }
        if (CutscenesController.cus38 == 0)
        {
            CutTrigger3.SetActive(false);
        }
        if (CutscenesController.cus95 == 0)
        {
            CutTrigger4.SetActive(false);
        }
        if (CutscenesController.cus105 == 0)
        {
            CutTrigger5.SetActive(false);
        }
        if (CutscenesController.cus123 == 0)
        {
            CutTrigger6.SetActive(false);
        }
        if (CutscenesController.cus126 == 0)
        {
            CutTrigger7.SetActive(false);
        }

        if (CutscenesController.cus37 == 1)
        {
            Destroy(CutTrigger1);
        }
        if (CutscenesController.cus38 == 1)
        {
            Destroy(CutTrigger2);
        }
        if (CutscenesController.cus95 == 1)
        {
            Destroy(CutTrigger3);
        }
        if (CutscenesController.cus105 == 1)
        {
            Destroy(CutTrigger4);
        }
        if (CutscenesController.cus123 == 1)
        {
            Destroy(CutTrigger5);
        }
        if (CutscenesController.cus126 == 1)
        {
            Destroy(CutTrigger6);
        }
        if (CutscenesController.cus133 == 1)
        {
            Destroy(CutTrigger7);
        }
    }
}
