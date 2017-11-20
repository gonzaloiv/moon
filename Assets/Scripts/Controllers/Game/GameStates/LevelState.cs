using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameStates {

    public class LevelState : BaseState {

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            game.Init(gameData); // This state is active until the end of the play.
            levelController.Init(game);
        }

        public override void Exit () {
            base.Exit();
            levelController.Disable();
        }

        #endregion
	
    }

}