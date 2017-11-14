using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameStates {

    public class LevelState : BaseState {

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            levelScreen.SetActive(true);
        }

        public override void Exit () {
            base.Exit();
            levelScreen.SetActive(false);
        }

        #endregion
	
    }

}