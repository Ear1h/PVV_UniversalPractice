

using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class UserUI: MonoBehaviour 
{
    private TMP_Text label;
    public Slider audioslider;
    public AudioSource audio;
    public TMP_InputField input;
    public TMP_Text inputlabel;
    private Text timer;
    public TMP_Text timerlabel;

    private void Start()
    {
        SetText();
        audioslider = GetComponent<Slider>();
        timer = GetComponent<Text>();
    }

    public void SetText()
    {
        label.text = "Hello Unity!";
    }

    public void OpenUnity()
    {
        Application.OpenURL("https://unity.com/");
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Game");
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 24), "Меню в игре");
        GUI.Box(new Rect(10, 40, 130, 90), "Выберите уровень");

        if (GUI.Button(new Rect(20, 70, 80, 24), "Уровень 1"))
        {
            SceneManager.LoadScene(0);
        }

        if (GUI.Button(new Rect(20, 100, 80, 24), "Уровень 2"))
        {
            SceneManager.LoadScene(1);
        }
    }

    public void OnChangeVolume()
    {
        audio.volume = audioslider.value;
    }

    public void changeText()
    {
        inputlabel.text = input.text;
    }

    private void Update()
    {
        string time = String.Format("{0:0.0}", Time.timeSinceLevelLoad);

        timerlabel.text = "Время: " + time;
    }
}
