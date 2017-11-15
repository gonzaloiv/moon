using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerStates {

    public class IdleState : BaseState {

        #region Mono Behaviour

        void OnMouseDown () {
            if (!this.enabled) return;
            playerController.ToDragState();
        }

        #endregion
	
    }

}