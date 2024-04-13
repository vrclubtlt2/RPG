using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CrystalUI : MonoBehaviour
{
   public TextMeshPro crystalText;

    // Update is called once per frame
    void Update()
    {
        crystalText.text = Corn.singleton.crystals.ToString();

    }
}
