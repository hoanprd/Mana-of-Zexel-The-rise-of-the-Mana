using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInsideIceCave : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2, CutTrigger3, CutTrigger4, CutTrigger5, CutTrigger6, ManaCoreIceZexel, ManaCoreIceEmpty, ManaCoreIceVayne, VillagerMissing;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus86 == 0)
        {
            ManaCoreIceZexel.SetActive(true);
            ManaCoreIceVayne.SetActive(false);
        }
        else if (CutscenesController.cus87 == 0 && CutscenesController.cus86 == 1)
        {
            ManaCoreIceZexel.SetActive(false);
            ManaCoreIceEmpty.SetActive(true);
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
        if (CutscenesController.cus86 == 0)
        {
            CutTrigger3.SetActive(false);
        }
        if (CutscenesController.cus87 == 0)
        {
            CutTrigger4.SetActive(false);
        }
        if (CutscenesController.cus90 == 0)
        {
            CutTrigger5.SetActive(false);
        }
        if (CutscenesController.cus119 == 0)
        {
            CutTrigger6.SetActive(false);
        }

        if (CutscenesController.cus69 == 1)
        {
            Destroy(CutTrigger1);
        }
        if (CutscenesController.cus86 == 1)
        {
            Destroy(CutTrigger2);
        }
        if (CutscenesController.cus87 == 1)
        {
            Destroy(CutTrigger3);
        }
        if (CutscenesController.cus90 == 1)
        {
            Destroy(CutTrigger4);
        }
        if (CutscenesController.cus119 == 1)
        {
            Destroy(CutTrigger5);
        }
        if (CutscenesController.cus120 == 1)
        {
            Destroy(CutTrigger6);
        }

        if (CutscenesController.cus119 == 1 && CutscenesController.cus121 == 0)
        {
            VillagerMissing.SetActive(true);
        }
        else
        {
            Destroy(VillagerMissing);
        }
    }
}
