using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    int guess;

    // Use this for initialization
    void Start ()
    {
        StartGame();
    }
	
    public void OnPressHigher () {
        min = guess;
        NextGuess();
    }

    public void OnPressLower () {
        max = guess;
        NextGuess();
    }
    void StartGame()
    {
        max += 1;
        guess = (max + min) / 2;
    }

	// Update is called once per frame
	void Update () {
    }

    void NextGuess ()
    {
        guess = (min + max) / 2;
        Debug.Log("Is your number higher or lower than : " + guess);
    }
}
