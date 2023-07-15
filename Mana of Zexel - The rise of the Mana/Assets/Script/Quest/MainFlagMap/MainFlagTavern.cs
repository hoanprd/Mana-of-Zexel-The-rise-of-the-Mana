using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagTavern : MainFlagGlobal
{
    public GameObject MainFlag1, MainFlag2, MainFlag3;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = FindObjectOfType<MainFlagGlobal>();

        mfd.MainFlagDisplay(CutscenesController.cus5, CutscenesController.cus4, MainFlag1);
        mfd.MainFlagDisplay(CutscenesController.cus6, CutscenesController.cus5, MainFlag2);
        mfd.MainFlagDisplay(CutscenesController.cus19, CutscenesController.cus18, MainFlag3);
    }
}
