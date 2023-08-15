using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagInfernoIce : MainFlagGlobal
{
    public GameObject MainFlag1, MainFlag2, MainFlag3;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = FindObjectOfType<MainFlagGlobal>();

        if (CutscenesController.cus66 == 0 && CutscenesController.cus65 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus66, CutscenesController.cus65, MainFlag1);
        }
        
        if (CutscenesController.cus67 == 0 && CutscenesController.cus66 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus67, CutscenesController.cus66, MainFlag1);
        }

        if (CutscenesController.cus70 == 0 && CutscenesController.cus69 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus70, CutscenesController.cus69, MainFlag1);
        }

        if (CutscenesController.cus68 == 0 && CutscenesController.cus67 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus68, CutscenesController.cus67, MainFlag2);
        }

        if (CutscenesController.cus78 == 0 && CutscenesController.cus77 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus78, CutscenesController.cus77, MainFlag1);
        }

        if (CutscenesController.cus79 == 0 && CutscenesController.cus78 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus79, CutscenesController.cus78, MainFlag3);
        }
    }
}
