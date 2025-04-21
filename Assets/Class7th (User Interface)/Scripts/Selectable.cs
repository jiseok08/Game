using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Selectable : MonoBehaviour
{
    [SerializeField] Text titleText;

    public void Entered()
    {
        titleText.fontSize = 100;
    }

    public void Exited()
    {
        titleText.fontSize = 75;
    }

    public void Selected()
    {
        titleText.fontSize = 50;
    }
}
