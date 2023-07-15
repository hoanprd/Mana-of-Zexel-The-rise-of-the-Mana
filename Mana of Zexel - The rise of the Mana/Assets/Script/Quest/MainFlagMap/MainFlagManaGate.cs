using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagManaGate : MainFlagGlobal
{
    public GameObject MainFlag1, MainFlag2;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = FindObjectOfType<MainFlagGlobal>();

        mfd.MainFlagDisplay(CutscenesController.cus51, CutscenesController.cus50, MainFlag1);
        mfd.MainFlagDisplay(CutscenesController.cus53, CutscenesController.cus52, MainFlag2);
    }
}
