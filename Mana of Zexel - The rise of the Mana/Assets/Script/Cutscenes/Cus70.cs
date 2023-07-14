using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus70 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1, FOP;
    public GameObject VayneVAL1, VayneVAR1, MariaVAL1, ShanVAL1, AlasaVAR1;
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
                ShanVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Alasa village chief, we have found the ice crystal!";
            }
            else if (tang == 2)
            {
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Just in time! I've finished making this stick that holds this ice crystal.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alasa";
                dia.text = "With this ice crystal, three people can obtain this fire energy core without any problems.";
            }
            else if (tang == 4)
            {
                ShanVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Will this prevent the village at the inferno volcano from being destroyed?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alasa";
                dia.text = "That's right. Shan! Lead them to the inferno volcano and tell Asila that she can get the fire core.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alasa";
                dia.text = "Oh one more thing, don't tell me this is an ice crystal from inferno ice, I want to surprise my brother!";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Surprise?";
            }
            else if (tang == 8)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Okay, if that's what you want, we'll keep quiet about the ice crystals.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alasa";
                dia.text = "Hahaha, okay I'll give this to you Vayne, good luck. After obtaining the fire core, I will give you the ice energy core.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Yes... Huh?";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(false);
                AlasaVAR1.SetActive(false);
                FOP.SetActive(true);
                NameTagText.text = "";
                dia.text = "Glowinggggggggggggggggg.............";
            }
            else if (tang == 12)
            {
                FOP.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "(What! Is the thing Orina gave me that is glowing again?)";
            }
            else if (tang == 13)
            {
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Any questions, Vayne?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "No it nothing, here we go.";
            }
            else if (tang == 15)
            {
                VayneVAL1.SetActive(false);
                AlasaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 16)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Just now, was the glowing thing Orina's, Vayne?";
            }
            else if (tang == 17)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's right, it seems to react to ice crystals.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Maria";
                dia.text = "May we be able to safely obtain the fire core.";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus70 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno ice");
            }
        }
        else
        {
            if (tang == 1)
            {
                ShanVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Thưa trưởng làng Alasa, chúng tôi đã tìm được tinh thể băng!";
            }
            else if (tang == 2)
            {
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Vừa đúng lúc lắm! Ta đã chế tạo xong gậy chứa đựng tinh thể băng này.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alasa";
                dia.text = "Với tinh thể băng này, ba người có thể lấy được lõi năng lượng lửa này mà không gặp vấn đề khó khăn gì cả.";
            }
            else if (tang == 4)
            {
                ShanVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thứ này sẽ ngăn chặn việc ngôi làng ở inferno volcano bị phá hủy ư?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alasa";
                dia.text = "Đúng thế. Shan! Hãy dẫn họ tới inferno volcano và bảo Asila là có thể lấy lõi năng lượng lửa.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alasa";
                dia.text = "À một chuyện nữa, ba người đừng bảo đây là tinh thể băng ở inferno ice nhé, ta muốn tạo bất ngờ cho anh trai của ta nhé!";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Bất ngờ ư?";
            }
            else if (tang == 8)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Được thôi, nếu ngài muốn vậy thì chúng tôi sẽ im lặng về tinh thể băng.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alasa";
                dia.text = "Hahaha, được rồi ta sẽ đưa thứ này cho cậu Vayne, chúc may mắn. Sau khi lấy được lõi năng lửa ta sẽ trao cho cậu lõi năng lương băng.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vâng... Hở?";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(false);
                AlasaVAR1.SetActive(false);
                FOP.SetActive(true);
                NameTagText.text = "";
                dia.text = "Glowinggggggggggggggggg.............";
            }
            else if (tang == 12)
            {
                FOP.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "(Gì thế! Là thứ của Orina đưa đang phát sáng tiếp ư?)";
            }
            else if (tang == 13)
            {
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Có gì thắc mắc à Vayne?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không có gì, chúng tôi đi đây.";
            }
            else if (tang == 15)
            {
                VayneVAL1.SetActive(false);
                AlasaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 16)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vừa rồi, thứ phát sáng có phải là của Orina à Vayne?";
            }
            else if (tang == 17)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế, hình như thứ đó phản ứng lại với tinh thể băng.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Maria";
                dia.text = "Cầu mong chúng ta có thể lấy được lõi năng lượng lửa một cách an toàn.";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus70 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno ice");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 11)
        {
            cc.FXCutscenes(3);
        }
        else if (tang == 12)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 10)
        {
            cc.BGMCutscenes(0, true);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus70 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno ice");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}