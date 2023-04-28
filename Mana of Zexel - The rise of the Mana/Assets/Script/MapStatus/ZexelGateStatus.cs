using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZexelGateStatus : MonoBehaviour
{
    public GameObject ManaGateClose, ManaGateOpen;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus87 == 1 && CutscenesController.cus139 == 0)
        {
            Destroy(ManaGateClose);
            ManaGateOpen.SetActive(true);
        }
    }
}
