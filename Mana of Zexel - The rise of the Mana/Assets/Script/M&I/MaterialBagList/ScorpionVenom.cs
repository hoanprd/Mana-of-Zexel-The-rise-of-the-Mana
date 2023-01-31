using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorpionVenom : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ScorpionVenom;

        if (ContainerController.ScorpionVenom <= 0)
        {
            Destroy(gameObject);
        }
    }
}
