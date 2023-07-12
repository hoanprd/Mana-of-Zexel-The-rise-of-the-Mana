using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus12 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, MariaVAR1;
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
                dia.text = "Hey Maria! We've already obtained some mana gem!";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Oh wait a minute. Ah finally see, surely the book information 1 year ago is in this.";
            }
            else if (tang == 3)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Did you find it?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Maybe so! Your father's full name is Dante Dias, right?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Oh! That's right! Do you have specific information?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Actually... Only Mr. Lance knows";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Why only Mr. Lance knows?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Simply no one can read my father's handwriting... not even me";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Heh? Are you kidding me? Never mind, we just have to go back to Mr. Lance.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Maria";
                dia.text = "Sorry for bothering you guys just now!";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "It's okay, Maria! If you don't mind, we can take the notebook to Mr. Lance.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Maria";
                dia.text = "Uhm, then here's the notebook, keep it safe.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "By the way, if you two don't mind, can I come with you?";
            }
            else if (tang == 14)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "It's OK! I'd love to, but do you have a job in town?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "It's really nothing, I just saw you two having an interesting adventure so I wanted to go along.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Just that? Looks like you also like to explore.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Maria";
                dia.text = "Of course, I'm an alchemist anyway, so it's only natural to go exploring in search of ingredients.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "I got it! If so, please help me with my alchemy experience.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Maria";
                dia.text = "Nice to work with you guys.";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus12 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing forest");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Này chị Maria! Tụi em đã thu thập đủ ngọc năng lượng rồi!";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Ồ đợi chị chút. À cuối cũng thấy rồi, cuốn sách chứa các thông tin của các nhà phiêu lưu một năm trước.";
            }
            else if (tang == 3)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chị thấy gì chứ?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Có lẽ thế! Cha của Vayne là Dante Dias ư?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng vậy! Chị có thông tin chi tiết đặc biệt nào chứ?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Chuyện này chỉ có cha chị mới biết được.";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Tại sao chỉ chú Lance mới biết?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Đơn giản không ai đọc được chữ bố chị viết... kể cả chị luôn.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cái gì? Đùa nhau hả trời? Thôi kệ đi chúng ta cần chỉ mang cuốn sổ cho chú Lance đọc là được.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Maria";
                dia.text = "Xin lỗi vì đã làm phiền mấy đứa lúc nãy!";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Được thôi, nếu chị không phiền thì để bọn em đưa cuốn sổ về chỗ chú Lance.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Maria";
                dia.text = "Ừ, vậy thì cuốn sổ đây, giữ nó cẩn thận.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Mà hai đứa có phiền nếu chị đi theo chứ?";
            }
            else if (tang == 14)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không sao cả! Bọn em rất hân hạnh, mà chị có công việc ở thị trấn hả?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "Không có gì đâu, chị chỉ cảm thấy hứng thú khi thấy hai đứa đi phiêu lưu này nọ nên chị cũng muốn đi theo.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chỉ vậy thôi sao? Có vẻ chị thích đi khám phá nhỉ?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Maria";
                dia.text = "Tất nhiên rồi, chị là một nhà giả kim mà, nên đó hoàn toàn tự nhiên khi ra ngoài khám phá tìm kiếm nguyên liệu.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Em hiểu rồi! Xin chị hãy chỉ giáo kỹ năng giả kim thuật cho em.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Maria";
                dia.text = "Rất vui được gặp mấy đứa.";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus12 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing forest");
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
        CutscenesController.cus12 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Wishing forest");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}