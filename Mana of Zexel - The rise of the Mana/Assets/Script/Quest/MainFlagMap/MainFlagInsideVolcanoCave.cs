using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagInsideVolcanoCave : MainFlagGlobal
{
    public GameObject MainFlag1;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = new MainFlagGlobal();

        mfd.MainFlagDisplay(CutscenesController.cus73, CutscenesController.cus72, MainFlag1);
        mfd.MainFlagDisplay(CutscenesController.cus76, CutscenesController.cus75, MainFlag1);
        mfd.MainFlagDisplay(CutscenesController.cus89, CutscenesController.cus88, MainFlag1);
    }
}
