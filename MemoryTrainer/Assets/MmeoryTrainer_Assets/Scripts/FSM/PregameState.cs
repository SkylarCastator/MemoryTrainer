using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PregameState : StateBase
{
    private float loadingTimer = 2f;
    private bool loadingFinished = false;

    public PregameState(MemoryTrainerStateMachine stateMachine) : base(stateMachine)
    {
        stateMachine.mainMenuComponent.EnableSplashScreen();
    }

    public override void OnStateEnter()
    {
        base.OnStateEnter();
    }

    public override void Tick()
    {
        loadingTimer -= Time.deltaTime;
        if (loadingTimer <= 0 && !loadingFinished)
        {
            stateMachine.SetState(new MainMenuState(stateMachine));
        }
    }

    public override void OnStateExit()
    {
        base.OnStateExit();
    }
}