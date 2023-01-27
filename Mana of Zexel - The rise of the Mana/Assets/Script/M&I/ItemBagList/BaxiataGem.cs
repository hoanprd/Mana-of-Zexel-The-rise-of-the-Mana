using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaxiataGem : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.BaxiataGem;

        if (ContainerController.BaxiataGem <= 0)
        {
            Destroy(gameObject);
        }
    }
}
