using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerStates {

    public class HitState : BaseState {

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            playerController.InvokePlayerHitEvent();
        }

        #endregion
	
    }

}