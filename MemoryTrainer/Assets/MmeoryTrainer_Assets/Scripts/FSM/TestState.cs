using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestState : StateBase
{
    public TestState(MemoryTrainerStateMachine stateMachine) : base(stateMachine)
    {
        stateMachine.mainMenuComponent.EnableTestSlideScreen();
    }

    public override void OnStateEnter()
    {
        base.OnStateEnter();
    }

    public override void Tick()
    {
        stateMachine.trainingSlideTimer += Time.deltaTime;
        stateMachine.mainMenuComponent.SetStudySlideTimerText(((int)stateMachine.trainingSlideTimer).ToString());
    }

    public override void OnStateExit()
    {
        base.OnStateExit();
    }
}