using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraCutscenesController : MonoBehaviour
{
    public GameObject BlackCusFaded;
    public GameObject CE1, CE2, CE3, CE4, CE5;
    public AudioSource[] CutBGM, CutFX;

    public static int CEIndex, cuse1, cuse2, cuse3, cuse4, cuse5;

    void Start()
    {
        StartCoroutine(delayFaded());
        SynthesizeSystem.SynBugStop = 0;

        if (CEIndex == 1)
        {
            CE1.SetActive(true);
        }
        else if (CEIndex == 2)
        {
            CE2.SetActive(true);
        }
        else if (CEIndex == 3)
        {
            CE3.SetActive(true);
        }
        else if (CEIndex == 4)
        {
            CE4.SetActive(true);
        }
        else if (CEIndex == 5)
        {
            CE5.SetActive(true);
        }
    }

    public void BGMCutscenes(int changeIndex, bool stopPlay)
    {
        if (stopPlay == false)
        {
            for (int i = 0; i < CutBGM.Length; i++)
            {
                if (i == changeIndex)
                {
                    CutBGM[i].Play();
                }
                else
                {
                    CutBGM[i].Stop();
                }
            }
        }
        else
        {
            for (int i = 0; i < CutBGM.Length; i++)
            {
                CutBGM[i].Stop();
            }
        }
    }

    public void FXCutscenes(int changeIndex)
    {
        for (int i = 0; i < CutFX.Length; i++)
        {
            if (i == changeIndex)
            {
                CutFX[i].Play();
            }
            else
            {
                CutFX[i].Stop();
            }
        }
    }

    public void FXCutscenesStop()
    {
        for (int i = 0; i < CutFX.Length; i++)
        {
            CutFX[i].Stop();
        }
    }

    IEnumerator delayFaded()
    {
        yield return new WaitForSeconds(2f);
        BlackCusFaded.SetActive(false);
    }
}
