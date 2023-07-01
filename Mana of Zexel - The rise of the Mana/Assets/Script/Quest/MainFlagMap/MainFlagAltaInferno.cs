using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagAltaInferno : MainFlagGlobal
{
    public GameObject MainFlag1;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = new MainFlagGlobal();

        mfd.MainFlagDisplay(CutscenesController.cus84, CutscenesController.cus83, MainFlag1);
    }
}
