using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultState : StateBase
{
    public ResultState(MemoryTrainerStateMachine stateMachine) : base(stateMachine)
    {
        stateMachine.mainMenuComponent.EnableResultsScreen();
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