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

    public delegate void PlayerGoalEventHandler ();
    public static event PlayerGoalEventHandler PlayerGoalEvent = delegate {};

    public delegate void PlayerHitEventHandler ();
    public static event PlayerHitEventHandler PlayerHitEvent = delegate {};

    #endregion

    #region Mono Behaviour

    void OnEnable () {
        ChangeState<IdleState>();
    }

    #endregion

    #region Public Behaviour

    public void Init (GameObject cam) {
        this.cam = cam.GetComponent<Camera>();
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

    public void InvokePlayerGoalEvent () {
        PlayerGoalEvent.Invoke();
    }

    public void InvokePlayerHitEvent () {
        PlayerHitEvent.Invoke();
    }

    #endregion

}