using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagManaTemple : MainFlagGlobal
{
    public GameObject MainFlag1;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = FindObjectOfType<MainFlagGlobal>();

        mfd.MainFlagDisplay(CutscenesController.cus55, CutscenesController.cus54, MainFlag1);
    }
}
