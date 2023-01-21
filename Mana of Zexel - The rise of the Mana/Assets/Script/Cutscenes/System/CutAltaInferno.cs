using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutAltaInferno : MonoBehaviour
{
    public GameObject CutTrigger1, CutTrigger2, LiveGround, DeadGround;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus79 == 0)
        {
            LiveGround.SetActive(false);
            DeadGround.SetActive(true);
        }

        if (CutscenesController.cus79 == 1)
        {
            LiveGround.SetActive(true);
            DeadGround.SetActive(false);
        }

        if (CutscenesController.cus79 == 0)
        {
            CutTrigger2.SetActive(false);
        }

        if (CutscenesController.cus79 == 1)
        {
            Destroy(CutTrigger1);
        }
    }
}
