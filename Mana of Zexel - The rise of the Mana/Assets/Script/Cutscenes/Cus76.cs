using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus76 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, AliaVAR1, MariaVAL1, AsilaVAR1;
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
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Okay, the fate of this whole village in the inferno volcano depends on me.";
            }
            else if (tang == 2)
            {
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "I hope you succeed, if you fail then I won't give you Zexel's fire energy core.";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                AsilaVAR1.SetActive(false);
                va1.SetActive(false);
                va2.SetActive(true);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Done!";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Looks like nothing happened, right?";
            }
            else if (tang == 6)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Uhm, the volcano is still stable.";
            }
            else if (tang == 7)
            {
                AliaVAR1.SetActive(false);
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Hum... If so, you've succeeded in creating a new fire energy core. So amazing!";
            }
            else if (tang == 8)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Really, we succeeded! If so, will Zexel's fire energy core be ours?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Asila";
                dia.text = "That's right! If there was a replacement, I wouldn't regret Zexel's fire core.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Well, why would the village chief Alasa want to harm his village, aren't you two brothers?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Asila";
                dia.text = "... This... I think we should go back to my village to talk easily because it's not that simple.";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "If so, we'd be glad to.";
            }
            else if (tang >= 13)
            {
                CutscenesController.cus76 = 1;
                ContainerController.ManaCoreFireVayne -= 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("InsideVolcanoCave");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Được rồi, vận mệnh của cả ngôi làng ở inferno volcano này phụ thuộc vào mình.";
            }
            else if (tang == 2)
            {
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Ta mong là ngươi thành công, nếu thất bại thì ta sẽ không giao lõi năng lượng lửa của Zexel cho ngươi đâu.";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                AsilaVAR1.SetActive(false);
                va1.SetActive(false);
                va2.SetActive(true);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Đã xong!";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Có vẻ như không có chuyện gì xảy ra nữa nhỉ?";
            }
            else if (tang == 6)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Uhm, núi lửa vẫn ổn định.";
            }
            else if (tang == 7)
            {
                AliaVAR1.SetActive(false);
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Hum... Nếu vậy thì các ngươi đã thành công trong việc tạo ra lõi năng lượng lửa mới rồi. Thật kinh ngạc!";
            }
            else if (tang == 8)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thật là chúng ta đã thành công rồi ư! Nếu vậy lõi năng lượng lửa của Zexel sẽ là của chúng tôi chứ?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Asila";
                dia.text = "Đúng thế! Nếu như đã có thứ thay thế thì ta không nuối tiếc gì lõi năng lượng lửa của Zexel nữa.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "À mà tại sao trưởng làng Alasa lại muốn hại ngôi làng của ngài, chẳng lẻ hai người là anh em mà?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Asila";
                dia.text = "... Chuyện này... ta nghĩ chúng ta nên quay lại ngôi làng của ta nói chuyện cho dễ vì nó không đơn giản đâu.";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nếu vậy chúng tôi rất sẵn lòng.";
            }
            else if (tang >= 13)
            {
                CutscenesController.cus76 = 1;
                ContainerController.ManaCoreFireVayne -= 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("InsideVolcanoCave");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus76 = 1;
        ContainerController.ManaCoreFireVayne -= 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("InsideVolcanoCave");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(1, false);
    }
}