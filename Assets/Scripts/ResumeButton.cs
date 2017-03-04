using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour {
    public GameObject GState;
    public Camera PauseCamera;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnMouseDown()
    {
        GState.GetComponent<GameState>().Player1.GetComponent<Rigidbody>().velocity = GState.GetComponent<GameState>().lastPlayer1Velocity;
        GState.GetComponent<GameState>().Player2.GetComponent<Rigidbody>().velocity = GState.GetComponent<GameState>().lastPlayer2Velocity;
        GState.GetComponent<GameState>().PauseGame = false;
        PauseCamera.enabled = false;
    }


}
