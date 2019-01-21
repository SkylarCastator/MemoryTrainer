using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateBase {
    protected MemoryTrainerStateMachine stateMachine;
    public abstract void Tick();
    public virtual void OnStateEnter() { }
    public virtual void OnStateExit() { }

    public StateBase(MemoryTrainerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
}
