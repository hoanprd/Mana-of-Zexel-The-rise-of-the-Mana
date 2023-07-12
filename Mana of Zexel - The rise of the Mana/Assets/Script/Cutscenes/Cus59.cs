using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus59 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAR1;
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
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Incredibly hot! I feel like I'm walking on fire.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "The ground is so hot here, even the air feels dry and thirsty.";
            }
            else if (tang == 3)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Let's quickly find the surrounding village before we become roast pigs.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Heh... Ahhh... so hot, so hot!";
            }
            else if (tang == 5)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Are you okay, Alia? All around us there are really dangerous times.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Everyone be careful because this area can still have monsters.";
            }
            else if (tang >= 7)
            {
                CutscenesController.cus59 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno volcano");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Nóng kinh khủng! Cảm giác mình đang đi trên lửa đấy.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đất ở đây nóng thật, kể cả không khí tớ cũng cảm thấy khô khan và khát nước nữa.";
            }
            else if (tang == 3)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chúng ta mau đi tìm ngôi làng xung quanh đây đi trước khi chúng ta trở thành heo quay.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Heh... Ahhh... nóng quá, nóng quá!";
            }
            else if (tang == 5)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không sao chứ Alia? Xung quanh chúng ta có những hồi nhung nham nguy hiểm thật.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Mọi người hãy cẩn thận vì khu vực này vẫn có thể có quái vật đấy.";
            }
            else if (tang >= 7)
            {
                CutscenesController.cus59 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno volcano");
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
        CutscenesController.cus59 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno volcano");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}