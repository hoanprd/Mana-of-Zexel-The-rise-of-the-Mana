using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInsideIceCave : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2, CutTrigger3, CutTrigger4, ManaCoreIceZexel, ManaCoreIceVayne;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus81 == 0)
        {
            ManaCoreIceZexel.SetActive(true);
            ManaCoreIceVayne.SetActive(false);
        }
        else
        {
            ManaCoreIceZexel.SetActive(false);
            ManaCoreIceVayne.SetActive(true);
        }

        if (CutscenesController.cus69 == 0)
        {
            CutTrigger2.SetActive(false);
        }
        if (CutscenesController.cus81 == 0)
        {
            CutTrigger3.SetActive(false);
        }
        if (CutscenesController.cus82 == 0)
        {
            CutTrigger4.SetActive(false);
        }

        if (CutscenesController.cus69 == 1)
        {
            Destroy(CutTrigger1);
        }
        if (CutscenesController.cus81 == 1)
        {
            Destroy(CutTrigger2);
        }
        if (CutscenesController.cus82 == 1)
        {
            Destroy(CutTrigger3);
        }
    }
}
