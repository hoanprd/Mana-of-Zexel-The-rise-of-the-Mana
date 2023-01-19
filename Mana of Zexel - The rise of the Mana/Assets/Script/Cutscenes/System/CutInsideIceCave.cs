using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInsideIceCave : MonoBehaviour
{
    public GameObject CutTrigger1, ManaCoreIceZexel, ManaCoreIceVayne;

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

        if (CutscenesController.cus65 == 1)
        {
            Destroy(CutTrigger1);
        }
    }
}
