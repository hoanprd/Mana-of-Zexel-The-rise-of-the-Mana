using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZexelTempleStatus : MonoBehaviour
{
    public GameObject TrueRoomDoor;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus116 == 1)
        {
            TrueRoomDoor.SetActive(false);
        }
    }
}
