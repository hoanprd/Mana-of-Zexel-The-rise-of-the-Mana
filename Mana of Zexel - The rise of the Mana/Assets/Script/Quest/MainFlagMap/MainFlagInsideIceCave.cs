using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagInsideIceCave : MainFlagGlobal
{
    public GameObject MainFlag1;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = FindObjectOfType<MainFlagGlobal>();

        mfd.MainFlagDisplay(CutscenesController.cus69, CutscenesController.cus68, MainFlag1);
        mfd.MainFlagDisplay(CutscenesController.cus86, CutscenesController.cus85, MainFlag1);
        if (ContainerController.ManaCoreIceVayne > 0)
        {
            mfd.MainFlagDisplay(CutscenesController.cus87, CutscenesController.cus86, MainFlag1);
        }
        mfd.MainFlagDisplay(CutscenesController.cus90, CutscenesController.cus88, MainFlag1);
    }
}
