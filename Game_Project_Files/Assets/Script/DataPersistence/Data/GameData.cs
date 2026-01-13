using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    /*----------------------------------------------------------------------------------
        GENERAL
    ----------------------------------------------------------------------------------*/
    public string _currentScene;
    public string _TutorialMission;
    public int _TutorialMissionText;
    public Vector3 _playerPosition;
    public SerializableDictionary<string, bool> _allDialogs;
    public SerializableDictionary<string, bool> _allReports;
    public SerializableDictionary<string, bool> _allPhotos;
    public SerializableDictionary<string, bool> _allTasks;
    public SerializableDictionary<int, List<string>> completedTasksByMission;
    public List<string> spawnedObjects = new List<string>();
    public List<string> collectedLetters = new List<string>();

    public bool _Garden;
    public bool _DialogSequence;
    public bool _InteractSecondMission;
    public bool _Task1Result;
    public bool _Task2Result;
    public bool _TalkedToMilton;
    public bool _Key;
    public int _currentMissionIndex;
    public int _currentOrder;
    public int TextCurrentOrder;
    public int _missionCompleted;


    /*----------------------------------------------------------------------------------
        MAIN MENU
    ----------------------------------------------------------------------------------*/
    public long lastUpdated;
    public int _currentNewsIndex;


    // the values defined in this constructor will be the default values
    // the game starts with when there's no data to load
    public GameData()
    {
        this._currentNewsIndex = 0;
        this._currentScene = "SampleScene";
        _playerPosition = new Vector3(2.5f, -2f, 0f);
        _allDialogs = new SerializableDictionary<string, bool>();
        _allReports = new SerializableDictionary<string, bool>();
        _allPhotos = new SerializableDictionary<string, bool>();
        _allTasks = new SerializableDictionary<string, bool>();
        completedTasksByMission = new SerializableDictionary<int, List<string>>();
        _currentMissionIndex = 0;
        _currentOrder = 0;
        _missionCompleted = 0;

    }


}