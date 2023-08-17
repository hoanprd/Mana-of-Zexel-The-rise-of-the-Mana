using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutAltaInferno : MonoBehaviour
{
    public GameObject CutTrigger1, LiveGround, DeadGround;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus84 == 0)
        {
            LiveGround.SetActive(false);
            DeadGround.SetActive(true);
        }
        else if (CutscenesController.cus84 == 1)
        {
            LiveGround.SetActive(true);
            DeadGround.SetActive(false);
        }


        if (CutscenesController.cus84 == 1)
        {
            Destroy(CutTrigger1);
        }
    }
}
