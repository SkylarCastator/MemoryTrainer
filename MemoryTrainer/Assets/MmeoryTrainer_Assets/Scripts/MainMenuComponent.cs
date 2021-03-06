﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuComponent : MonoBehaviour
{
    public MemoryTrainerStateMachine stateMachine;
    public Text[] trainingTimerText;
    public Text[] studyTimerText;
    public Text[] testTimerText;
    public Text[] studyText;
    public Text[] levelText;
    public Text userSubmittedText;
    public Text playerScore;
    public InputField submitInputField;
    public GameObject splashScreenObject;
    public GameObject mainMenuObject;
    public GameObject trainingSlideObject;
    public GameObject resultsMenuObject;
    public GameObject testMenuObject;

	public void DisableMenus()
    {
        splashScreenObject.SetActive(false);
        mainMenuObject.SetActive(false);
        trainingSlideObject.SetActive(false);
        resultsMenuObject.SetActive(false);
        testMenuObject.SetActive(false);
    }

    public void EnableSplashScreen()
    {
        DisableMenus();
        splashScreenObject.SetActive(true);
    }

    public void EnableTrainingSlideScreen()
    {
        DisableMenus();
        trainingSlideObject.SetActive(true);
    }

    public void EnableTestSlideScreen()
    {
        DisableMenus();
        testMenuObject.SetActive(true);
    }

    public void EnableMainMenuScene()
    {
        DisableMenus();
        mainMenuObject.SetActive(true);
    }

    public void EnableResultsScreen()
    {
        DisableMenus();
        resultsMenuObject.SetActive(true);
    }

    public void SetStudyContentText(string content)
    {
        foreach (Text text in studyText)
        {
            text.text = content;
        }
    }

    public void SetStudySlideTimerText(string content)
    {
        foreach (Text text in studyTimerText)
        {
            text.text = content;
        }
    }

    public void SetTestSlideTimerText(string content)
    {
        foreach (Text text in testTimerText)
        {
            text.text = content;
        }
    }

    public void ChangeLevelButtonPressed(int value)
    {
        stateMachine.ChangeUserLevel(value);
    }

    public void StartButtonPressed()
    {
        stateMachine.SetState(new StudyState(stateMachine));
    }

    public void TestButtonPressed()
    {
        stateMachine.SetState(new TestState(stateMachine));
    }

    public void SubmitButtonPressed()
    {
        stateMachine.SetState(new ResultState(stateMachine));
    }

    public void ExitButtonPressed()
    {
        stateMachine.SetState(new MainMenuState(stateMachine));
    }

    public void InputFieldChanged()
    {
        string content = submitInputField.text;
        userSubmittedText.text = content;
        stateMachine.UpdateUserSubmittedString(content);
    }

    public void UpdatePlayerScore(float score)
    {
        playerScore.text = ((int)score).ToString();
    }

    public void SetLevelText(int level)
    {
        foreach (Text text in levelText)
        {
            text.text = "Level " + level.ToString();
        }
    }
}
