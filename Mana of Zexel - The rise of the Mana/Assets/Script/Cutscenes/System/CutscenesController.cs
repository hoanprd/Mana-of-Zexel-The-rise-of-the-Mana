using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutscenesController : MonoBehaviour
{
    public GameObject C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12;
    public static int cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8, cus9, cus10, cus11, cus12, cus13, cus14, cus15, cus16, cus17, cus18, cus19, cus20;

    void Start()
    {
        if (cus1 == 0)
            C1.SetActive(true);
        else if (cus2 == 0)
            C2.SetActive(true);
        else if (cus3 == 0)
            C3.SetActive(true);
        else if (cus4 == 0)
            C4.SetActive(true);
        else if (cus5 == 0)
            C5.SetActive(true);
        else if (cus6 == 0)
            C6.SetActive(true);
        else if (cus7 == 0)
            C7.SetActive(true);
        else if (cus8 == 0)
            C8.SetActive(true);
        else if (cus9 == 0)
            C9.SetActive(true);
        else if (cus10 == 0)
            C10.SetActive(true);
        else if (cus11 == 0)
            C11.SetActive(true);
        else if (cus12 == 0)
            C12.SetActive(true);
    }
}
