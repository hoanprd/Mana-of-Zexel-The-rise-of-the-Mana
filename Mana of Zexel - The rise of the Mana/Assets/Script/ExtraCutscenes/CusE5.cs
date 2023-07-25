using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CusE5 : MonoBehaviour
{
    ExtraCutscenesController ecc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject OldScarf, Scraf;
    public GameObject VayneVAL1, MariaVAR1;
    public GameObject NameTag;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
        ecc = FindObjectOfType<ExtraCutscenesController>();
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
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hmm?";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Is there something there, Vayne?";
            }
            else if (tang == 3)
            {
                OldScarf.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... It's a scarf... looks pretty old.";
            }
            else if (tang == 4)
            {
                Scraf.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "This scarf... is pretty similar to the one I'm carrying.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "They look exactly the same, even the patterns are the same.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "A scarf from a long-abandoned temple, strange.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "It seems to be the ruins left by the ancients before this place was abandoned.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Maybe so, then we should move on.";
            }
            else if (tang == 9)
            {
                OldScarf.SetActive(false);
                Scraf.SetActive(false);
                NameTagText.text = "Maria";
                dia.text = "Uhm, ...";
            }
            else if (tang == 10)
            {
                VayneVAL1.SetActive(false);
                NameTagText.text = "Maria";
                dia.text = "(Strange, the pattern of the scarf is exactly the same as mine)";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "(It can't be such a coincidence, my mother sewed the exact same pattern)";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Maria";
                dia.text = "(Who left this scarf here?)";
            }
            else if (tang >= 13)
            {
                ExtraCutscenesController.cuse5 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel temple");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hửm?";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có thứ gì ở đó hả Vayne?";
            }
            else if (tang == 3)
            {
                OldScarf.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Là một khăn choàng cổ... trông khá là lâu đời.";
            }
            else if (tang == 4)
            {
                Scraf.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cái khăn này... khá giống với của chị đang mang theo.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Trông hai cái y hệt nhau, kể cả hoa văn cũng giống.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Một cái khăn choàng ở một đền bỏ hoang từ lâu, kỳ lạ thật.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "Có vẻ là tàn tích của người xưa để lại trước khi nơi này bị bỏ hoang.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Có lẻ thế, thôi thì chúng ta nên đi tiếp thôi.";
            }
            else if (tang == 9)
            {
                OldScarf.SetActive(false);
                Scraf.SetActive(false);
                NameTagText.text = "Maria";
                dia.text = "Uhm, ...";
            }
            else if (tang == 10)
            {
                VayneVAL1.SetActive(false);
                NameTagText.text = "Maria";
                dia.text = "(Lạ thật, hoa văn của chiếc khăn giống y hệt của mình)";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "(Không thể nào trùng hợp như vậy được, chính tay mẹ của mình đã may hoa văn giống hệt này)";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Maria";
                dia.text = "(Ai là người đã bỏ lại chiếc khăn choàng này ở đây thế?)";
            }
            else if (tang >= 13)
            {
                ExtraCutscenesController.cuse5 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel temple");
            }
        }
    }

    public void Pressnext()
    {
        ecc.FXCutscenes(1);

        tang += 1;
    }

    public void Pressskip()
    {
        ecc.FXCutscenes(1);
        ExtraCutscenesController.cuse5 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel temple");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        ecc.BGMCutscenes(2, false);
    }
}
