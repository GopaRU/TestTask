using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static int Counter { get; set; }
    private int Prevalue;

    [SerializeField]
    private Canvas Menu;

    [SerializeField]
    private Text CounterText;

    void Start() {

        //loading progress
        Counter = PlayerPrefs.GetInt("Counts");
        CounterText.text = "BallHit: " + Counter;
    }

    void Update() {

        //on changing value we prepare it for save
        if (Counter > Prevalue)
        {
            PlayerPrefs.SetInt("Counts", Counter);
            Prevalue = Counter;
        }

        //on going "back" we go to menu 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CounterText.text = "BallHit: " + Counter;
            Menu.enabled = true;
            PlayerPrefs.Save();
        }
	}

    //planet button functionality
    public void ApplyNew(PlanetData data)
    {
        Camera.main.backgroundColor = data.BackgroundColor;
        Physics2D.gravity = Physics.gravity.normalized * data.GravityValue;
        Menu.enabled = false;
    }
}
