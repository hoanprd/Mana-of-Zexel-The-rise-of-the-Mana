using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagWishingHill : MainFlagGlobal
{
    public GameObject MainFlag1;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = FindObjectOfType<MainFlagGlobal>();

        mfd.MainFlagDisplay(CutscenesController.cus3, CutscenesController.cus2, MainFlag1);
    }
}
