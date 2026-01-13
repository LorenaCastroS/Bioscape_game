using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondMissionDialog : MonoBehaviour
{
    public static int _I;
    public bool _Interact;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_I);
        _Interact = true;
        if (_Interact)
        {
            _I = _I + 1;
            _Interact = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (_I == 3)
        {
            TutorialMission.TextCurrentOrder = 2;
            DataPersistenceManager.instance.CurrentOrder = 4;
          //  Cellphone.Instance.ShowNotification();
        }
    }
}
