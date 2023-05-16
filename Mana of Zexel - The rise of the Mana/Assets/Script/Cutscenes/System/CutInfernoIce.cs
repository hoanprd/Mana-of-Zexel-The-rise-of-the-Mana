using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInfernoIce : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2, CutTrigger3;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus65 == 0)
        {
            CutTrigger2.SetActive(false);
        }
        if (CutscenesController.cus77 == 0)
        {
            CutTrigger3.SetActive(false);
        }

        if (CutscenesController.cus65 == 1)
        {
            Destroy(CutTrigger1);
        }
        if (CutscenesController.cus66 == 1)
        {
            Destroy(CutTrigger2);
        }
        if (CutscenesController.cus78 == 1)
        {
            Destroy(CutTrigger3);
        }
    }
}
