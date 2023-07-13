using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus89 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1, MariaVAR1;
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
                dia.text = "Okay! Finished a machine at inferno volcano already.";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "We should get out of here, it's really hot in here. Don't you have a better place to put your phone, Vayne?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hehe, I think here's as much fire element mana as possible.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Then you go first.";
            }
            else if (tang == 5)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Wait for me and Maria!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hehe...";
            }
            else if (tang >= 7)
            {
                CutscenesController.cus89 = 1;
                ContainerController.FireManaGenerator -= 1;
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
                dia.text = "Ok! Đã xong một máy ở inferno volcano rồi.";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chúng ta nên ra khỏi đây thôi, mà ở đây nóng thật. Em không có chỗ nào để đặt máy tốt hơn à Vayne?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hehe, em nghĩ ở đây là nhiều mana nguyên tố lửa nhất có thể rồi.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Vậy thì chị đi trước đây.";
            }
            else if (tang == 5)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Đợi em với chị Maria!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hehe...";
            }
            else if (tang >= 7)
            {
                CutscenesController.cus89 = 1;
                ContainerController.FireManaGenerator -= 1;
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
        CutscenesController.cus89 = 1;
        ContainerController.FireManaGenerator -= 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("InsideVolcanoCave");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(0, false);
    }
}