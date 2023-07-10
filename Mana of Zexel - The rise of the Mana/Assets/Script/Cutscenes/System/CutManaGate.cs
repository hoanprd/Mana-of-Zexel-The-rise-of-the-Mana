using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutManaGate : MonoBehaviour
{
    public GameObject ManaDimensionPortal, CutTrigger1;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus51 == 1)
        {
            ManaDimensionPortal.SetActive(true);
        }
        else
        {
            ManaDimensionPortal.SetActive(false);
        }

        if (CutscenesController.cus51 == 1)
        {
            Destroy(CutTrigger1);
        }
    }
}
