using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus54 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1, MariaVAL1, MariaVAR1;
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
                dia.text = "It worked! This is the mana chain that helps Alia stabilize the flow of mana in her body.";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Granted, Vayne is really talented, being able to think and create interesting things like this.";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Just now you felt the mana in my body decrease right?";
            }
            else if (tang == 4)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... That's right.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "Vayne's mana flow decreased? So it's not good?";
            }
            else if (tang == 6)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Normally the human body will have a flow of mana inside, for real alchemists they will have a more stable flow than normal people so you and Vayne can absorb mana without any problems...";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "However, alchemists can use mana to synthesize items to create new items, as well as use them in battle. For combat, the alchemists would use weapons to stabilize the flow of mana and magnify their power such as my crystal ball or Vayne's wand.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "When using mana flow, it will consume a certain amount of mana, Vayne just made that mana necklace that will cost quite a bit of mana because those items need a lot of mana to work. If the mana flow disappears then the person will have no soul and soul in the body and will die.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "No way, if so is Vayne weakening?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Maria";
                dia.text = "It's true that Vayne has weakened, but she'll be back to normal with just a day's sleep. Depends on the severity.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alia";
                dia.text = "Phew, it really worries me. Hey Vayne, with this necklace I'll protect you as best I can!";
            }
            else if (tang == 12)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I'm fine, don't worry about me.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Alia";
                dia.text = "Come on, I'm indebted to you, let me express my gratitude!";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "I said it's okay...";
            }
            else if (tang == 15)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "You two are so optimistic and interesting.";
            }
            else if (tang >= 16)
            {
                CutscenesController.cus54 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.ManaNecklace -= 1;
                SceneManager.LoadScene("Save room");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thành công rồi! Đây chính là dây chuyền mana giúp Alia ổn định lại dòng chảy mana trong cơ thể.";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Công nhận Vayne tài thật, có thể nghĩ và tạo ra những thứ thú vị như này.";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vừa rồi chị cảm nhận lượng mana trong cơ thể em vừa giảm xuống đúng không?";
            }
            else if (tang == 4)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Đúng thế.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "Dòng chảy mana của Vayne giảm xuống ư? Vậy là không tốt ư?";
            }
            else if (tang == 6)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Thường thì cơ thể con người sẽ có dòng chảy mana bên trong, đối với giả kim thật thì họ sẽ có dòng chảy ổn định hơn người bình thường nên chị và Vayne có thể hấp thụ mana mà không gặp bất kỳ trở ngại gì.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "Tuy nhiên nhà giả kim có thể sử dụng mana để tổng hợp vật phẩm chế tạo ra vật phẩm mới, cũng như dùng chúng trong chiến đấu. Đối với chiến đấu, các nhà giả kim sẽ dùng các vũ khí để ổn định dòng chảy mana và phóng đại sức mạnh của chúng như quả cầu pha lê của chị hoặc gậy phép của Vayne.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Khi sử dụng dòng chảy mana thì sẽ tiêu hao một lượng mana nhất định, Vayne vừa rồi chế tạo dây chuyền mana kia sẽ tốn kha khá mana vì những vật phẩm đó cần nhiều mana để hoạt động. Nếu dòng chảy mana biến mất thì người đó sẽ không còn hồn và phách trong cơ thể thì sẽ chết.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "Không thể nào, nếu vậy Vayne đang suy yếu sao?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Maria";
                dia.text = "Đúng là Vayne đã bị suy yếu đi nhưng chỉ cần ngủ nghỉ đủ giấc tầm 1 ngày là sẽ bình thường lại. Tùy thuộc mức độ nặng nhẹ.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alia";
                dia.text = "Phù, làm em lo thật đấy. Này Vayne, với dây chuyền này tớ sẽ bảo vệ cậu hết sức có thể!";
            }
            else if (tang == 12)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Tớ không sao đâu, đừng lo cho tớ quá.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Alia";
                dia.text = "Thôi nào, tớ đang mang ơn của cậu đấy, hãy cho tớ bày tỏ lòng biết ơn đi!";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tớ bảo là không sao rồi mà...";
            }
            else if (tang == 15)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hai đứa thật là lạc quan và thú vị đấy.";
            }
            else if (tang >= 16)
            {
                CutscenesController.cus54 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.ManaNecklace -= 1;
                SceneManager.LoadScene("Save room");
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
        CutscenesController.cus54 = 1;
        ContainerController.LoadingOpen = true;
        ContainerController.ManaNecklace -= 1;
        SceneManager.LoadScene("Save room");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}