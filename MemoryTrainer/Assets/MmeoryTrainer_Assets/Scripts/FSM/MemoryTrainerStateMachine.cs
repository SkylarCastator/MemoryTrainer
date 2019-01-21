using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryTrainerStateMachine : MonoBehaviour {

    private StateBase currentState;
    public MainMenuComponent mainMenuComponent;

	void Start ()
    {
        SetState(new PregameState(this));
	}
	
	void Update ()
    {
		if (currentState != null)
        {
            currentState.Tick();
        }
	}

    public void SetState(StateBase state)
    {
        currentState = state;
    }
}
