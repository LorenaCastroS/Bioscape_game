using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmMission : MonoBehaviour
{
    public static int _I;
    public bool _Interact;
    public GameObject _Doors;
    // Start is called before the first frame update
    void Start()
    {
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
        if (_I == 5)
        {
            _Doors.SetActive(true);
            DataPersistenceManager.instance.CurrentOrder = 2;
            TutorialMission.TextCurrentOrder = 4;
        }
    }
}
