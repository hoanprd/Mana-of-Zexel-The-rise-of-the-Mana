using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutZexelTown : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2, CutTrigger3;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus26 == 0)
        {
            CutTrigger3.SetActive(false);
        }

        if (CutscenesController.cus26 == 1)
        {
            Destroy(CutTrigger1);
            Destroy(CutTrigger2);
        }
        else if (CutscenesController.cus34 == 1)
        {
            Destroy(CutTrigger3);
        }
    }
}
