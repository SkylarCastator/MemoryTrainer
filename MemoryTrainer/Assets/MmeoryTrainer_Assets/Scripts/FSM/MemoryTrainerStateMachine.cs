using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryTrainerStateMachine : MonoBehaviour {

    private StateBase currentState;
    public MainMenuComponent mainMenuComponent;
    public string numberList { private set; get;}
    private int playerLevel = 0;
    private float playerScore = 0f;
    public float trainingTimerLength = 600;
    public float trainingSlideTimer = 0;
    public float testSlideTimer = 0;

    private string userSubmittedString;

    public void UpdateUserSubmittedString(string content)
    {
        userSubmittedString = content;
    }

    public void ScoreTestVerseStudy()
    {

        if (userSubmittedString != "")
        {
            string cleanedNumberList = numberList.Replace(" ", "");
            string cleanedUserSubmittedString = userSubmittedString.Replace(" ", "");
            float score = 0;
            float totalNumberOfNumbers = cleanedNumberList.Length;

            for (int i = 0; i < cleanedNumberList.Length; i++)
            {
                if (cleanedNumberList[i] == cleanedUserSubmittedString[i])
                {
                    score += 1;
                }
            }

            Debug.Log("scored = " + score);
            playerScore = (score / totalNumberOfNumbers) * 100f;
            Debug.Log("player final score = " + playerScore);
            mainMenuComponent.UpdatePlayerScore(playerScore);
        }
        else
        {
            Debug.Log("User entered empty string");
        }
    }

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
