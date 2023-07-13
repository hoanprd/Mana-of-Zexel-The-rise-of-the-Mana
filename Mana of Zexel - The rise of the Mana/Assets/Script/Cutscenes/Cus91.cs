using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus91 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAR1, MariaVAR1, ManaElfVAL1, ManaElfVAR1, ManaRockVAL1, ManaLightVAL1;
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
                ManaElfVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "Looks like everyone found Zexel's fire and ice mana core.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's right! We have obtained those two cores of energy with all our sincerity...";
            }
            else if (tang == 3)
            {
                ManaElfVAL1.SetActive(false);
                ManaRockVAL1.SetActive(true);
                NameTagText.text = "Mana rock";
                dia.text = "If you are selfish in defying both the inferno volcano and inferno ice villages, you will fail the Zexel Gate test.";
            }
            else if (tang == 4)
            {
                ManaRockVAL1.SetActive(false);
                ManaLightVAL1.SetActive(true);
                NameTagText.text = "Mana light";
                dia.text = "And you will be devoured by the mana core. However, you have passed the test wonderfully.";
            }
            else if (tang == 5)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "So resolving the conflict between the two villages is part of the challenge? Why didn't the gods foretell?";
            }
            else if (tang == 6)
            {
                ManaLightVAL1.SetActive(false);
                ManaElfVAL1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "Only then will we be able to see the true heart of humans, which is also the basis of other mana's belief in you.";
            }
            else if (tang == 7)
            {
                ManaElfVAL1.SetActive(false);
                ManaRockVAL1.SetActive(true);
                NameTagText.text = "Mana rock";
                dia.text = "Don't be selfish especially between humans. That is the key to being able to make friends with other species like us mana.";
            }
            else if (tang == 8)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Then can we open the Zexel portal with these two power cores?";
            }
            else if (tang == 9)
            {
                ManaRockVAL1.SetActive(false);
                ManaElfVAL1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "You just need to put two of Zexel's energy cores in front of the gate to open it.";
            }
            else if (tang == 10)
            {
                ManaElfVAL1.SetActive(false);
                ManaLightVAL1.SetActive(true);
                NameTagText.text = "Mana light";
                dia.text = "However, the main challenge begins now. What you do next will determine the fate of this place.";
            }
            else if (tang == 11)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Decide fate? I still don't understand what will happen next.";
            }
            else if (tang == 12)
            {
                ManaLightVAL1.SetActive(false);
                ManaElfVAL1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "You will understand once you get there. The journey of maturity, everyone can understand that.";
            }
            else if (tang == 13)
            {
                ManaElfVAL1.SetActive(false);
                ManaRockVAL1.SetActive(true);
                NameTagText.text = "Mana rock";
                dia.text = "Zexel before his death brought temporary peace between humans and mana. Those who hold it will be those people.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Sounds stressful, right? If so, we'll go to the gate!";
            }
            else if (tang == 15)
            {
                ManaRockVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 16)
            {
                ManaLightVAL1.SetActive(true);
                NameTagText.text = "Mana light";
                dia.text = "Are you sure they can do it?";
            }
            else if (tang == 17)
            {
                ManaElfVAR1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "If Zexel believes in the next generation, then they can do it. Not only that, the red-haired alchemist, is the key to the cycle of peace continuing.";
            }
            else if (tang >= 18)
            {
                CutscenesController.cus91 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana temple");
            }
        }
        else
        {
            if (tang == 1)
            {
                ManaElfVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "Có vẻ mọi người đã tìm được lõi năng lượng mana băng và lửa của Zexel rồi nhỉ.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đúng là thế! Chúng tôi đã lấy được hai lõi năng lượng ấy bằng cả tấm lòng chân thành...";
            }
            else if (tang == 3)
            {
                ManaElfVAL1.SetActive(false);
                ManaRockVAL1.SetActive(true);
                NameTagText.text = "Mana rock";
                dia.text = "Nếu các ngươi ích kỷ trong việc bất chấp phá hủy cả hai ngôi làng ở inferno volcano và inferno ice thì các ngươi sẽ thất bại thử thách qua cổng Zexel.";
            }
            else if (tang == 4)
            {
                ManaRockVAL1.SetActive(false);
                ManaLightVAL1.SetActive(true);
                NameTagText.text = "Mana light";
                dia.text = "Và các ngươi sẽ bị lõi năng lượng mana nuốt chửng. Tuy nhiên các ngươi đã vượt qua thử thách một cách tuyệt vời.";
            }
            else if (tang == 5)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vậy là giải quyết xung đột của hai làng là một phần của thử thách ư? Sao mấy vị thần không báo trước thế.";
            }
            else if (tang == 6)
            {
                ManaLightVAL1.SetActive(false);
                ManaElfVAL1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "Chỉ có vậy bọn ta mới thấy được tâm địa thật sự của con người, cũng là cơ sở các mana khác tin vào các người.";
            }
            else if (tang == 7)
            {
                ManaElfVAL1.SetActive(false);
                ManaRockVAL1.SetActive(true);
                NameTagText.text = "Mana rock";
                dia.text = "Đừng có ích kỷ đặc biệt là giữa con người với con người. Đó chính là chìa khóa để có thể kết bạn với các loài khác như mana bọn ta.";
            }
            else if (tang == 8)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vậy thì chúng tôi có thể mở được cánh cổng Zexel bằng hai lõi năng lượng này rồi chứ?";
            }
            else if (tang == 9)
            {
                ManaRockVAL1.SetActive(false);
                ManaElfVAL1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "Các người chỉ cần đưa hai lõi năng lượng của Zexel trước cánh cổng là sẽ mở được cánh cổng đó.";
            }
            else if (tang == 10)
            {
                ManaElfVAL1.SetActive(false);
                ManaLightVAL1.SetActive(true);
                NameTagText.text = "Mana light";
                dia.text = "Tuy nhiên thử thách chính mới bắt đầu từ bây giờ. Điều mà các ngươi làm kế tiếp sẽ quyết định số phận của nơi đây.";
            }
            else if (tang == 11)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Quyết định số phận ư? Tôi vẫn không hiểu được chuyện gì sẽ xảy ra tiếp theo.";
            }
            else if (tang == 12)
            {
                ManaLightVAL1.SetActive(false);
                ManaElfVAL1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "Các người sẽ hiểu một khi đến đó. Hành trình của sự trưởng thành, mọi người có thể hiểu vậy là được.";
            }
            else if (tang == 13)
            {
                ManaElfVAL1.SetActive(false);
                ManaRockVAL1.SetActive(true);
                NameTagText.text = "Mana rock";
                dia.text = "Zexel trước khi mất đã đem lại sự hòa bình nhất thời giữa con người và mana. Người giữ lấy nó sẽ là các người đó.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nghe có vẻ căng thẳng nhỉ? Nếu vậy chúng tôi sẽ đi đến chỗ cánh cổng đây!";
            }
            else if (tang == 15)
            {
                ManaRockVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 16)
            {
                ManaLightVAL1.SetActive(true);
                NameTagText.text = "Mana light";
                dia.text = "Cô có chắc họ sẽ làm được chứ?";
            }
            else if (tang == 17)
            {
                ManaElfVAR1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "Nếu như Zexel tin tưởng vào thế hệ sau thì chắc họ sẽ làm được. Không chỉ thế cô gái giả kim tóc đỏ kia, chính là chìa khóa để vòng lặp hòa bình được tiếp diễn.";
            }
            else if (tang >= 18)
            {
                CutscenesController.cus91 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana temple");
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
        CutscenesController.cus91 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana temple");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(1, false);
    }
}