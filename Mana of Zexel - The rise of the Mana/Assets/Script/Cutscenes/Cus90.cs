using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus90 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1;
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
                dia.text = "Okay! Another machine in inferno ice already.";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ahhhhhh... It's those disgusting slimes again!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Calm down Alia, don't touch them.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Calm down, they keep coming towards me. Why don't they like the other two! I don't like you guys.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay, okay, I'll deal with them.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "Let's get out of here, I'm freezing cold too!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "(It's hard to understand girls!)";
            }
            else if (tang >= 8)
            {
                CutscenesController.cus90 = 1;
                ContainerController.IceManaGenerator -= 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("InsideIceCave");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Ok! Thêm một máy nữa ở inferno ice rồi.";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ahhhhhh... Lại là bọn slime ghê tởm này!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Bình tĩnh đi Alia, đừng đụng chạm chúng là được.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Bình tĩnh cái gì, bọn chúng cứ thích tiến tới tớ. Sao bọn chúng không thích hai người kia thế! Ta không thích bọn ngươi đâu.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được rồi, được rồi, tớ sẽ giải quyết bọn chúng.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "Thôi chúng ta ra khỏi đây đi, tớ cũng lạnh sắp đóng băng rồi đây!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "(Đúng là khó hiểu tụi con gái thật!)";
            }
            else if (tang >= 8)
            {
                CutscenesController.cus90 = 1;
                ContainerController.IceManaGenerator -= 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("InsideIceCave");
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
        CutscenesController.cus90 = 1;
        ContainerController.IceManaGenerator -= 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("InsideIceCave");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(0, false);
    }
}