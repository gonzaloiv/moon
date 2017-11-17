using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerStates;

public class PlayerController : StateMachine {

    #region Fields / Properties

    public Camera Cam { get { return cam; } }
    private Camera cam;

    #endregion

    #region Events

    public delegate void GoalEventHandler ();
    public static event GoalEventHandler GoalEvent = delegate {};

    #endregion

    #region Mono Behaviour

    void OnEnable () {
        ChangeState<IdleState>();
    }

    #endregion

    #region Public Behaviour

    public void Init (Camera cam) {
        this.cam = cam;
    }

    public void ToIdleState () {
        ChangeState<IdleState>();
    }

    public void ToDragState () {
        ChangeState<DragState>();
    }

    public void ToMoveState () {
        ChangeState<MoveState>();
    }

    public void ToHitState () {
        ChangeState<HitState>();
    }

    public void ToGoalState () {
        ChangeState<GoalState>();
    }

    public void InvokeGoalEvent () {
        GoalEvent.Invoke();
    }

    #endregion

}