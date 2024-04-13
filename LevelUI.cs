using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelUI : MonoBehaviour
{
    public TextMeshProUGUI levelText;

    // Update is called once per frame
    void Update()
    {
        levelText.text = LevelController.level.ToString();

    }
}
