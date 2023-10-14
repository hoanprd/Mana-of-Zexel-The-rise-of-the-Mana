using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyInfoInterface : MonoBehaviour
{
    EnemyInfo ei;

    public AudioSource OpenHubFX, ClickFX;
    public GameObject EnemyInfoPanel, EnemyInfoText;
    public GameObject[] EnemyAvatar;
    public Text[] EnemyNameText;

    public static bool OpenEnemyList;

    // Start is called before the first frame update
    void Start()
    {
        ei = FindObjectOfType<EnemyInfo>();

        ei.InfoDisplay(EnemyAvatar, EnemyNameText);
    }

    void Update()
    {
        if (OpenEnemyList == true)
        {
            OpenEnemyList = false;
            EnemyInfoPanel.SetActive(true);
        }
    }
    public void ThiefInfoPress()
    {
        if (Global.EnemyListInfo[0] == 1)
        {
            OpenHubFX.Play();
            ei.InfoShow(0, EnemyInfoText);
        }
    }

    public void GoblinInfoPress()
    {
        if (Global.EnemyListInfo[1] == 1)
        {
            OpenHubFX.Play();
            ei.InfoShow(1, EnemyInfoText);
        }
    }

    public void GolemnInfoPress()
    {
        if (Global.EnemyListInfo[2] == 1)
        {
            OpenHubFX.Play();
            ei.InfoShow(2, EnemyInfoText);
        }
    }

    public void InfernoScorpionInfoPress()
    {
        if (Global.EnemyListInfo[3] == 1)
        {
            OpenHubFX.Play();
            ei.InfoShow(3, EnemyInfoText);
        }
    }

    public void ManaSlimeInfoPress()
    {
        if (Global.EnemyListInfo[4] == 1)
        {
            OpenHubFX.Play();
            ei.InfoShow(4, EnemyInfoText);
        }
    }

    public void FireFangInfoPress()
    {
        if (Global.EnemyListInfo[5] == 1)
        {
            OpenHubFX.Play();
            ei.InfoShow(5, EnemyInfoText);
        }
    }

    public void RedManaSlimeInfoPress()
    {
        if (Global.EnemyListInfo[6] == 1)
        {
            OpenHubFX.Play();
            ei.InfoShow(6, EnemyInfoText);
        }
    }

    public void IceFangInfoPress()
    {
        if (Global.EnemyListInfo[7] == 1)
        {
            OpenHubFX.Play();
            ei.InfoShow(7, EnemyInfoText);
        }
    }

    public void BlueManaSlimeInfoPress()
    {
        if (Global.EnemyListInfo[8] == 1)
        {
            OpenHubFX.Play();
            ei.InfoShow(8, EnemyInfoText);
        }
    }

    public void ManaEagleInfoPress()
    {
        if (Global.EnemyListInfo[9] == 1)
        {
            OpenHubFX.Play();
            ei.InfoShow(9, EnemyInfoText);
        }
    }

    public void GhostInfoPress()
    {
        if (Global.EnemyListInfo[10] == 1)
        {
            OpenHubFX.Play();
            ei.InfoShow(10, EnemyInfoText);
        }
    }

    public void IronGolemnInfoPress()
    {
        if (Global.EnemyListInfo[11] == 1)
        {
            OpenHubFX.Play();
            ei.InfoShow(11, EnemyInfoText);
        }
    }

    public void CloseEnemyInfoPanel()
    {
        ClickFX.Play();
        ei.ResetInfo(EnemyInfoText);
        HubController.BusyHub = false;
        EnemyInfoPanel.SetActive(false);
    }
}
