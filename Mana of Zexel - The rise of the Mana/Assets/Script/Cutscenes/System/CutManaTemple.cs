using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutManaTemple : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2, CutTrigger3, CutTrigger4;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus55 == 0)
        {
            CutTrigger2.SetActive(false);
        }
        if (CutscenesController.cus91 == 0)
        {
            CutTrigger3.SetActive(false);
        }
        if (CutscenesController.cus134 == 0)
        {
            CutTrigger4.SetActive(false);
        }

        if (CutscenesController.cus55 == 1)
        {
            Destroy(CutTrigger1);
        }
        if (CutscenesController.cus91 == 1)
        {
            Destroy(CutTrigger2);
        }
        if (CutscenesController.cus134 == 1)
        {
            Destroy(CutTrigger3);
        }
        if (CutscenesController.cus141 == 1)
        {
            Destroy(CutTrigger4);
        }
    }
}
