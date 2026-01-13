using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkedToMilton : MonoBehaviour, IDataPersistence
{
    public static bool _I;
    // Start is called before the first frame update
    void Start()
    {
        _I = true;
        TutorialMission.TextCurrentOrder = 3;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadData(GameData data)
    {
        // Carrega os objetos existentes do save
        _I = data._TalkedToMilton;
    }

    public void SaveData(GameData data)
    {
        // Salva todos os IDs registrados
        data._TalkedToMilton = _I;
    }
}
