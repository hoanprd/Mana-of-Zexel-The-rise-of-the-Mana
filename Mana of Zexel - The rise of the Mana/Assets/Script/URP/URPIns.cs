using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URPIns : MonoBehaviour
{
    public GameObject[] URPPrefab;

    // Start is called before the first frame update
    void Start()
    {
        if (!(GraphicSettingController.Bloom == 0 && GraphicSettingController.Vignette == 0 && GraphicSettingController.WhiteBalance == 0 && GraphicSettingController.HightlightShadow == 0))
        {
            for (int i = 0; i < URPPrefab.Length; i++)
            {
                Instantiate(URPPrefab[i], new Vector3(0, 0, 0), Quaternion.identity);
            }
        }
    }
}
