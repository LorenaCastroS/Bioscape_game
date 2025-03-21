using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour

{
    public AudioSource _selectButton;

    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();

        button.onClick.AddListener(PlaySound);
    }

    // Update is called once per frame
    void PlaySound()
    {
        _selectButton.Play();
    }
}
