using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReincarnationLife : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ReincarnationLife;

        if (ContainerController.ReincarnationLife <= 0)
        {
            Destroy(gameObject);
        }
    }
}
