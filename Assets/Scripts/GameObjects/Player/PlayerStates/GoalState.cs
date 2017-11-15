using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerStates {

    public class GoalState : BaseState {

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            Debug.Log("GoalState.Enter()");
        }

        #endregion
        
    }

}