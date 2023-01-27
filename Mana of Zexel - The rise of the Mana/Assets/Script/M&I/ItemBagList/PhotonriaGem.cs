using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotonriaGem : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.PhotonriaGem;

        if (ContainerController.PhotonriaGem <= 0)
        {
            Destroy(gameObject);
        }
    }
}
