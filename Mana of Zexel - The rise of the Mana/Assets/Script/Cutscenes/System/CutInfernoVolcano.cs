using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInfernoVolcano : MonoBehaviour
{
    public GameObject[] VillageHome, VillageHomeBroken;
    public GameObject CutTrigger1, CutTrigger2;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus60 == 0)
        {
            CutTrigger2.SetActive(false);
        }

        if (CutscenesController.cus60 == 1)
        {
            Destroy(CutTrigger1);
        }
        if (CutscenesController.cus61 == 1)
        {
            Destroy(CutTrigger2);
        }

        if (CutscenesController.cus113 == 0 && CutscenesController.cus111 == 1)
        {
            for (int i = 0; i < VillageHome.Length; i++)
            {
                VillageHome[i].SetActive(false);
            }

            for (int i = 0; i < VillageHomeBroken.Length; i++)
            {
                VillageHomeBroken[i].SetActive(true);
            }
        }
    }
}
