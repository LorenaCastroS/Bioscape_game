using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

public class TutorialMission : MonoBehaviour, IDataPersistence
{
    public static TutorialMission tutorialmission;
    Transform _Child; // Unique identifier for each object
    public Text _Text;
    public string _Texts;
    public static int TextCurrentOrder = 1;

    [Header("Tutorial")]
    public LocalizedString localizedStringDef;
    public LocalizedString localizedStringBath;
    public LocalizedString localizedStringKitchen;
    public LocalizedString localizedStringGarden;

    [Header("PrimeiraMissão")]
    public LocalizedString localizedStringFt;
    public LocalizedString localizedStringSt;
    public LocalizedString localizedStringTt;
    public LocalizedString localizedStringQt;
    public LocalizedString localizedStringJt;

    [Header("SegundaMissão")]
    public LocalizedString localizedStringFt2;
    public LocalizedString localizedStringSt2;
    public LocalizedString localizedStringTt2;
    public LocalizedString localizedStringQt2;

    [Header("TerceiraMissão")]
    public LocalizedString localizedStringFt3;
    public LocalizedString localizedStringSt3;
    public LocalizedString localizedStringTt3;
    public LocalizedString localizedStringQt3;


    public void LoadData(GameData data)
    {
        // Carrega os objetos existentes do save
        TextCurrentOrder = data._TutorialMissionText;
    }

    public void SaveData(GameData data)
    {
        // Salva todos os IDs registrados
        data._TutorialMissionText = TextCurrentOrder;
    }
    private void Update()
    {
        if (DataPersistenceManager.instance != null)
        {
            if (DataPersistenceManager.instance.MissionCompleted == 0)
            {
                _Child.gameObject.SetActive(true);

                switch (DataPersistenceManager.instance.CurrentOrder)
                {
                    case 1:
                        localizedStringDef.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        };
                        break;
                    case 2:
                        localizedStringBath.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        };
                        break;
                    case 3:
                        localizedStringKitchen.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        };
                        break;
                    case 4:
                        localizedStringGarden.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        };
                        break;
                    default:
                        break;
                }

            }
            else if (DataPersistenceManager.instance.MissionCompleted == 1)
            {
                switch (TextCurrentOrder)
                {
                    case 1:
                        localizedStringFt.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        };
                        break;
                    case 2:
                        localizedStringSt.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        };
                        break;
                    case 3:
                        localizedStringTt.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        };
                        break;
                    case 4:
                        localizedStringQt.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        }; break;
                    case 5:
                        localizedStringJt.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        };
                        break;
                    default:
                        break;
                }
            }
            else if (DataPersistenceManager.instance.MissionCompleted == 2)
            {
                switch (TextCurrentOrder)
                {
                    case 1:
                        localizedStringFt2.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        };
                        break;
                    case 2:
                        localizedStringSt2.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        };
                        break;
                    case 3:
                        localizedStringTt2.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        };
                        break;
                    case 4:
                        localizedStringQt2.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        }; break;
                    default:
                        break;
                }
            }
            else if (DataPersistenceManager.instance.MissionCompleted == 3)
            {
                switch (TextCurrentOrder)
                {
                    case 1:
                        localizedStringFt3.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        };
                        break;
                    case 2:
                        localizedStringSt3.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        };
                        break;
                    case 3:
                        localizedStringTt3.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        };
                        break;
                    case 4:
                        localizedStringQt3.GetLocalizedStringAsync().Completed += handle =>
                        {
                            if (_Text != null)
                                _Text.text = handle.Result;
                        }; break;
                    default:
                        break;
                }
            }
        }

    }
    private void Start()
    {
        _Child = transform.GetChild(0);
        tutorialmission = this;
    }
    private void OnApplicationQuit()
    {
    }

}
