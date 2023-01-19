using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInsideVolcanoCave : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus73 == 0)
        {
            CutTrigger2.SetActive(false);
        }

        if (CutscenesController.cus73 == 1)
        {
            Destroy(CutTrigger1);
        }
    }
}
