using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagInfernoDesert : MainFlagGlobal
{
    public GameObject MainFlag1, MainFlag2, MainFlag3, MainFlag4;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = FindObjectOfType<MainFlagGlobal>();

        if (CutscenesController.cus37 == 0 && CutscenesController.cus36 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus37, CutscenesController.cus36, MainFlag1);
        }
        //mfd.MainFlagDisplay(CutscenesController.cus37, CutscenesController.cus36, MainFlag1);

        if (CutscenesController.cus38 == 0 && CutscenesController.cus37 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus38, CutscenesController.cus37, MainFlag2);
        }
        //mfd.MainFlagDisplay(CutscenesController.cus38, CutscenesController.cus37, MainFlag2);

        if (CutscenesController.cus50 == 0 && CutscenesController.cus49 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus50, CutscenesController.cus49, MainFlag3);
        }
        //mfd.MainFlagDisplay(CutscenesController.cus50, CutscenesController.cus49, MainFlag3);

        if (CutscenesController.cus95 == 0 && CutscenesController.cus94 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus95, CutscenesController.cus94, MainFlag4);
        }
        //mfd.MainFlagDisplay(CutscenesController.cus95, CutscenesController.cus94, MainFlag4);

        if (CutscenesController.cus105 == 0 && CutscenesController.cus104 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus105, CutscenesController.cus104, MainFlag4);
        }
        //mfd.MainFlagDisplay(CutscenesController.cus105, CutscenesController.cus104, MainFlag4);

        if (CutscenesController.cus123 == 0 && CutscenesController.cus122 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus123, CutscenesController.cus122, MainFlag4);
        }
        //mfd.MainFlagDisplay(CutscenesController.cus123, CutscenesController.cus122, MainFlag4);

        if (CutscenesController.cus126 == 0 && CutscenesController.cus125 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus126, CutscenesController.cus125, MainFlag4);
        }
        //mfd.MainFlagDisplay(CutscenesController.cus126, CutscenesController.cus125, MainFlag4);

        if (CutscenesController.cus133 == 0 && CutscenesController.cus132 == 1)
        {
            mfd.MainFlagDisplay(CutscenesController.cus133, CutscenesController.cus132, MainFlag4);
        }
    }
}
