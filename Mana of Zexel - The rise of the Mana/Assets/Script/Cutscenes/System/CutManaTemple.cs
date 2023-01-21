using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutManaTemple : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus51 == 0)
        {
            CutTrigger2.SetActive(false);
        }

        if (CutscenesController.cus51 == 1)
        {
            Destroy(CutTrigger1);
        }

        if (CutscenesController.cus86 == 1)
        {
            Destroy(CutTrigger2);
        }
    }
}
