using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyState : StateBase
{
    
    public StudyState(MemoryTrainerStateMachine stateMachine) : base(stateMachine)
    {
        stateMachine.trainingSlideTimer = 0;
        stateMachine.testSlideTimer = 0;

        stateMachine.mainMenuComponent.EnableTrainingSlideScreen();
        stateMachine.GenerateRandomList();
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