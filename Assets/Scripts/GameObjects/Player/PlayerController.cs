using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerStates;

public class PlayerController : StateMachine {

    #region Mono Behaviour

    void OnEnable() {
        ChangeState<IdleState>();
    }

    #endregion

    #region Public Behaviour

    public void ToIdleState() {
        ChangeState<IdleState>();
    }

    public void ToDragState() {
        ChangeState<DragState>();
    }

    public void ToMoveState() {
        ChangeState<MoveState>();
    }

    public void ToHitState() {
        ChangeState<HitState>();
    }

    public void ToGoalState() {
        ChangeState<GoalState>();
    }

    #endregion

}