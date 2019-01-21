using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyState : StateBase
{
    private float slideTimer = 0;
    public StudyState(MemoryTrainerStateMachine stateMachine) : base(stateMachine)
    {
        stateMachine.mainMenuComponent.EnableTrainingSlideScreen();
        stateMachine.GenerateRandomList();
    }

    public override void OnStateEnter()
    {
        base.OnStateEnter();
    }

    public override void Tick()
    {
        slideTimer += Time.deltaTime;
        stateMachine.mainMenuComponent.SetStudySlideTimerText(((int)slideTimer).ToString());
    }

    public override void OnStateExit()
    {
        base.OnStateExit();
    }
}