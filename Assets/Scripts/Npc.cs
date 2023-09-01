using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public string[] dialogs;

    private DialogManagerTest dm;

    private void Awake()
    {
        dm = GameObject.Find("DialogManager").GetComponent<DialogManagerTest>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        dm.ShowDialog(dialogs[1]);
    }
}
