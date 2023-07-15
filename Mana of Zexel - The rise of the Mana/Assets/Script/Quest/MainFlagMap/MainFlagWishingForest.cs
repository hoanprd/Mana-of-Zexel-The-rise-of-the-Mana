using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagWishingForest : MainFlagGlobal
{
    public GameObject MainFlag1, MainFlag2, MainFlag3;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = FindObjectOfType<MainFlagGlobal>();

        mfd.MainFlagDisplay(CutscenesController.cus12, CutscenesController.cus10, MainFlag1);
        mfd.MainFlagDisplay(CutscenesController.cus15, CutscenesController.cus14, MainFlag2);
        mfd.MainFlagDisplay(CutscenesController.cus82, CutscenesController.cus80, MainFlag3);
    }
}
