using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInsideVolcanoCave : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2, CutTrigger3, ManaCoreFireZexel, ManaCoreFireBroken, ManaCoreFireVayne;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus73 == 0)
        {
            ManaCoreFireZexel.SetActive(true);
            ManaCoreFireBroken.SetActive(false);
            ManaCoreFireVayne.SetActive(false);
        }
        else if (CutscenesController.cus73 == 1 && CutscenesController.cus76 == 0)
        {
            ManaCoreFireZexel.SetActive(false);
            ManaCoreFireBroken.SetActive(true);
            ManaCoreFireVayne.SetActive(false);
        }
        else
        {
            ManaCoreFireZexel.SetActive(false);
            ManaCoreFireBroken.SetActive(false);
            ManaCoreFireVayne.SetActive(true);
        }

        if (CutscenesController.cus73 == 0)
        {
            CutTrigger2.SetActive(false);
        }
        if (CutscenesController.cus76 == 0)
        {
            CutTrigger3.SetActive(false);
        }

        if (CutscenesController.cus73 == 1)
        {
            Destroy(CutTrigger1);
        }
        if (CutscenesController.cus76 == 1)
        {
            Destroy(CutTrigger2);
        }
        if (CutscenesController.cus89 == 1)
        {
            Destroy(CutTrigger3);
        }
    }
}
