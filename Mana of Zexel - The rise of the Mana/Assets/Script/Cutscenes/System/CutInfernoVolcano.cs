using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInfernoVolcano : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus60 == 0)
        {
            CutTrigger2.SetActive(false);
        }

        if (CutscenesController.cus60 == 1)
        {
            Destroy(CutTrigger1);
        }
        else if (CutscenesController.cus61 == 1)
        {
            Destroy(CutTrigger2);
        }
    }
}
