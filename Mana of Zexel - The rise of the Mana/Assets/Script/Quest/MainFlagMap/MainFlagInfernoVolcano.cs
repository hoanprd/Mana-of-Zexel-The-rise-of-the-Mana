using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagInfernoVolcano : MainFlagGlobal
{
    public GameObject MainFlag1, MainFlag2, MainFlag3, MainFlag4;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = FindObjectOfType<MainFlagGlobal>();

        if (CutscenesController.cus60 == 0 && CutscenesController.cus59 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus60, CutscenesController.cus59, MainFlag1);
        }

        if (CutscenesController.cus61 == 0 && CutscenesController.cus60 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus61, CutscenesController.cus60, MainFlag2);
        }

        if (CutscenesController.cus72 == 0 && CutscenesController.cus71 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus72, CutscenesController.cus71, MainFlag3);
        }

        if (CutscenesController.cus79 == 0 && CutscenesController.cus78 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus79, CutscenesController.cus78, MainFlag4);
        }

        if (CutscenesController.cus71 == 0 && CutscenesController.cus70 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus71, CutscenesController.cus70, MainFlag2);
        }

        if (CutscenesController.cus77 == 0 && CutscenesController.cus76 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus77, CutscenesController.cus76, MainFlag2);
        }
    }
}
