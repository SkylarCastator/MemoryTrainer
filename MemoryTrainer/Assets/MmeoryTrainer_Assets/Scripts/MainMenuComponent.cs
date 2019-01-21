using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuComponent : MonoBehaviour
{
    public Text trainingTimerText;
    public Text slideTimerText;
    public GameObject splashScreenObject;
    public GameObject mainMenuObject;
    public GameObject trainingSlideObject;
    public GameObject resultsMenuObject;

    private float trainingTimerLength;
    private float slideTimerLength;

	public void DisableMenus()
    {
        splashScreenObject.SetActive(false);
        mainMenuObject.SetActive(false);
        trainingSlideObject.SetActive(false);
        resultsMenuObject.SetActive(false);
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
}
