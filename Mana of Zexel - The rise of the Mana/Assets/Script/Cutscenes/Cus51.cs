using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus51 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, MariaVAL1, ManaGuardianVAR1;
    public GameObject NameTag;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
        cc = FindObjectOfType<CutscenesController>();
        tang = 0;
        StartCoroutine(DelayBGM());
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSettingController.GameLangPlot == 0)
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Stop there, human.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "!!!";
            }
            else if (tang == 3)
            {
                ManaGuardianVAR1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "You dare to go to this sacred place? I won't let you go any further.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Wait, we're not here to fight.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "???";
                dia.text = "Shut up and fight, I don't believe any human word.";
            }
            else if (tang == 6)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "We have to fight Vayne, this guy seems to want to destroy us.";
            }
            else if (tang == 7)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "I can sense a huge amount of mana from this guy.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "???";
                dia.text = "Let's start the battle! Graaaaaaaa!!!";
            }
            else if (tang >= 9)
            {
                CutscenesController.cus51 = 1;
                ContainerController.LoadingOpen = true;
                HPMPBarController.EIndex = 21;
                SceneManager.LoadScene("BSManaGuardian 1");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Đứng lại đó con người phàn trần.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "!!!";
            }
            else if (tang == 3)
            {
                ManaGuardianVAR1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Các người dám tiến tới nơi linh thiêng này ư? Ta đây sẽ không cho các ngươi tiến sâu vô đâu.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Khoan đã chúng tôi đến đây không phải để gây chiến.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "???";
                dia.text = "Im lặng và chiến đấu đi, ta không tin bất kỳ lời nói của con người.";
            }
            else if (tang == 6)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chúng ta phải chiến đấu thôi Vayne, tên này có vẻ muốn tiêu diệt chúng ta đấy.";
            }
            else if (tang == 7)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chị có thể cảm nhận được nguồn mana rất lớn từ tên này.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "???";
                dia.text = "Bắt đầu trận chiến nào! Graaaaaaaa!!!";
            }
            else if (tang >= 9)
            {
                CutscenesController.cus51 = 1;
                ContainerController.LoadingOpen = true;
                HPMPBarController.EIndex = 21;
                SceneManager.LoadScene("BSManaGuardian 1");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 1)
        {
            cc.FXCutscenes(6);
        }
        else if (tang == 2)
        {
            cc.FXCutscenesStop();
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus51 = 1;
        ContainerController.LoadingOpen = true;
        HPMPBarController.EIndex = 21;
        SceneManager.LoadScene("BSManaGuardian 1");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(4, false);
    }
}