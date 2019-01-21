using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuState : StateBase
{
    public MainMenuState(MemoryTrainerStateMachine stateMachine) : base(stateMachine)
    {
        stateMachine.mainMenuComponent.EnableMainMenuScene();
    }

    public override void OnStateEnter()
    {
        base.OnStateEnter();
    }

    public override void Tick()
    {

    }

    public override void OnStateExit()
    {
        base.OnStateExit();
    }
}
