using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus119 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2, va3;
    public GameObject VayneVAL1, AliaVAL1, MariaVAL1;
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
                dia.text = "Maybe we should split up to make the search easier.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Ok!!!";
            }
            else if (tang == 3)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "There are no clues here either.";
            }
            else if (tang == 5)
            {
                va2.SetActive(false);
                va3.SetActive(true);
                MariaVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 6)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Let's see, we're not here yet...";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "Hey, there's someone over there!";
            }
            else if (tang == 8)
            {
                AliaVAL1.SetActive(false);
                NameTagText.text = "???";
                dia.text = "Who is that?";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hey guys, there's a strange man in this corner!";
            }
            else if (tang == 10)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Hey don't make me lose my mind! Luckily not a monster.";
            }
            else if (tang == 11)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Are you the husband of someone in the village of inferno ice?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Yes, I already have a wife, could it be...";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Your wife is worried about you! Why are you here?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Actually after the attack of the inferno beast I lost my wedding ring but I told my wife that I will go down to the ice cave to get the ring back.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Maybe she didn't hear you out of panic.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "I've already worried my wife but I can't come back with my lost wedding ring because it's our keepsake.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay, we'll help you get the ring back.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Really? Thanks everyone!";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus119 = 1;
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
                dia.text = "Có lẽ chúng ta nên chia ra cho việc tìm kiếm trở nên dễ hơn.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Ok!!!";
            }
            else if (tang == 3)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Ở đây cũng kh có manh mối gì hết.";
            }
            else if (tang == 5)
            {
                va2.SetActive(false);
                va3.SetActive(true);
                MariaVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 6)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Để xem nào, chúng ta vẫn chưa đến chỗ này...";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "Hể, đằng kia có ai đó!";
            }
            else if (tang == 8)
            {
                AliaVAL1.SetActive(false);
                NameTagText.text = "???";
                dia.text = "Là ai thế?";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Này mọi người có một người đàn ông lạ mặt đang ở góc này đây!";
            }
            else if (tang == 10)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Này đừng làm tôi hết hồn chứ! May là không phải quái vật.";
            }
            else if (tang == 11)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cho hỏi ông có phải là chồng của ai đó ở ngôi làng inferno ice đúng không?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Đúng thế, tôi đã có vợ rồi, chẳng lẽ nào...";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vợ ông đang lo lắng cho ông đấy! Tại sao ông lại ở đây?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Thật ra thì sau cuộc tấn công của inferno beast tôi đã làm mất chiếc nhẫn cưới nhưng tôi đã nói với vợ tôi là sẽ xuống hang băng kiếm lại chiếc nhẫn.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Có lẽ vì hoảng loạng mà cô ấy không nghe ông nói rồi.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Tôi đã làm vợ tôi lo lắng rồi nhưng tôi không thể trở về với chiếc nhẫn cưới thất lạc được vì đó là vật kỷ niệm của chúng tôi.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được rồi, chúng tôi sẽ giúp ông kiếm lại chiếc nhẫn.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Thật vậy ư? Cảm ơn mọi người!";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus119 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("InsideIceCave");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 8)
        {
            cc.BGMCutscenes(0, true);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus119 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("InsideIceCave");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}