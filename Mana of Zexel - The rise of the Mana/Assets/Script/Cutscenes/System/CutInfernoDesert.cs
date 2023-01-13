using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInfernoDesert : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus37 == 0)
        {
            CutTrigger2.SetActive(false);
        }

        if (CutscenesController.cus37 == 1)
        {
            Destroy(CutTrigger1);
        }
        else if (CutscenesController.cus38 == 1)
        {
            Destroy(CutTrigger2);
        }
    }
}
