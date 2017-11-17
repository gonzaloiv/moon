using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerStates {

    public class GoalState : BaseState {

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            playerController.InvokeGoalEvent();
            Debug.Log("GoalState");
        }

        #endregion
        
    }

}