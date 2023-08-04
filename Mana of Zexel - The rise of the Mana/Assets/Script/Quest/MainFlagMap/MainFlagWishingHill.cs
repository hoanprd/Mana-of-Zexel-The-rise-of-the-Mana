using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainFlagWishingHill : MainFlagGlobal
{
    public GameObject MainFlag1;

    // Start is called before the first frame update
    void Start()
    {
        if (MenuController.BugStartGameFix == true)
        {
            MenuController.BugStartGameFix = false;
            SceneManager.LoadScene("Wishing hill");
        }

        MainFlagGlobal mfd = FindObjectOfType<MainFlagGlobal>();

        mfd.MainFlagDisplay(CutscenesController.cus3, CutscenesController.cus2, MainFlag1);
    }
}
