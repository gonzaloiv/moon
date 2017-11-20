using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelStates {

    public class LevelEndState : BaseState {

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            Debug.Log("LevelEndState.Enter()");
        }

        #endregion

    }

}