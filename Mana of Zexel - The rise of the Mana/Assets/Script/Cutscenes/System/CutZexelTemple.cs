using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutZexelTemple : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2, CutTrigger3;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus135 == 0)
        {
            CutTrigger2.SetActive(false);
        }
        if (CutscenesController.cus136 == 0)
        {
            CutTrigger3.SetActive(false);
        }

        if (CutscenesController.cus135 == 1)
        {
            Destroy(CutTrigger1);
        }
        if (CutscenesController.cus136 == 1)
        {
            Destroy(CutTrigger2);
        }
        if (CutscenesController.cus137 == 1)
        {
            Destroy(CutTrigger3);
        }
    }
}
