using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryTrainerStateMachine : MonoBehaviour {

    private StateBase currentState;
    public MainMenuComponent mainMenuComponent;
    public string numberList { private set; get;}
    private int playerLevel = 0;

    public float trainingTimerLength = 600;
    public float trainingSlideTimer = 0;
    public float testSlideTimer = 0;

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

    public void ChangeUserLevel(int levelChange)
    {
        playerLevel += levelChange;
        mainMenuComponent.SetLevelText(playerLevel);
    }

    public void GenerateRandomList()
    {
        numberList = "";
        for (int i = 0; i < (playerLevel + 1); i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int randomValue = Random.Range(0, 99);
                if (randomValue < 10)
                {
                    numberList += "0" + randomValue;
                }
                else
                {
                    numberList += (randomValue.ToString() + "");
                }
            }

            numberList += " ";
        }

        mainMenuComponent.SetStudyContentText(numberList);
    }
}
