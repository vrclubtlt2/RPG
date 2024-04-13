using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthUI : MonoBehaviour
{
    public TextMeshProUGUI healthText;
  

    // Update is called once per frame
    void Update()
    {
        healthText.text = Corn.singleton.health.ToString();
    }
}
