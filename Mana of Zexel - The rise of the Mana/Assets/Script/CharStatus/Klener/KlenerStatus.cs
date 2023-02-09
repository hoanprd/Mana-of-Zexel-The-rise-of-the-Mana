using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlenerStatus : MonoBehaviour
{
    public GameObject Klener;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus5 == 0)
        {
            Klener.SetActive(false);
        }
    }
}
