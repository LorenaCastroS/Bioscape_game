using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Missions1Dialog : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnDisable()
    {

        StartDialog2.startdialog2.ActiveButton();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void Start()
    {
        TutorialMission.TextCurrentOrder = 5;
    }
}
