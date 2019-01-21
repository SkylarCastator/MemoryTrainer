using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuComponent : MonoBehaviour
{
    public MemoryTrainerStateMachine stateMachine;
    public Text trainingTimerText;
    public Text slideTimerText;
    public Text studyText;
    public Text[] levelText;
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
        studyText.text = content;
    }

    public void SetStudySlideTimerText(string content)
    {
        slideTimerText.text = content;
    }

    public void ChangeLevelButtonPressed(int value)
    {
        stateMachine.ChangeUserLevel(value);
    }

    public void StartButtonPressed()
    {
        stateMachine.SetState(new StudyState(stateMachine));
    }

    public void SetLevelText(int level)
    {
        foreach (Text text in levelText)
        {
            text.text = "Level " + level.ToString();
        }
    }
}
