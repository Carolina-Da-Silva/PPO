using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManagerTest : MonoBehaviour
{
    public Text text;

    public void Awake()
    {
        text.text = "INICIOU";

        
    }

    public void ShowDialog(string dialog)
    {
        text.text = dialog;
    }
}
