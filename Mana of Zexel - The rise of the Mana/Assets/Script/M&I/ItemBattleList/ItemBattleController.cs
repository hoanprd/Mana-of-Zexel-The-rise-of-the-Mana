using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBattleController : MonoBehaviour
{
    public GameObject IHP, IMP, IEP, IB, IHHP, IHMP, IUB, IRL;

    // Update is called once per frame
    void Update()
    {
        if (ContainerController.HealPotion > 0)
        {
            IHP.SetActive(true);
        }
        else
        {
            IHP.SetActive(false);
        }

        if (ContainerController.ManaPotion > 0)
        {
            IMP.SetActive(true);
        }
        else
        {
            IMP.SetActive(false);
        }

        if (ContainerController.ElixirPotion > 0)
        {
            IEP.SetActive(true);
        }
        else
        {
            IEP.SetActive(false);
        }

        if (ContainerController.Bom > 0)
        {
            IB.SetActive(true);
        }
        else
        {
            IB.SetActive(false);
        }

        if (ContainerController.HoliHP > 0)
        {
            IHHP.SetActive(true);
        }
        else
        {
            IHHP.SetActive(false);
        }

        if (ContainerController.HoliMP > 0)
        {
            IHMP.SetActive(true);
        }
        else
        {
            IHMP.SetActive(false);
        }

        if (ContainerController.UltraBom > 0)
        {
            IUB.SetActive(true);
        }
        else
        {
            IUB.SetActive(false);
        }

        if (ContainerController.ReincarnationLife > 0)
        {
            IRL.SetActive(true);
        }
        else
        {
            IRL.SetActive(false);
        }
    }
}
