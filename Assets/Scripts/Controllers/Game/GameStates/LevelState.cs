using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameStates {

    public class LevelState : BaseState {

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            levelScreen.SetActive(true);
            game.Init(new Player(GameConfig.PlayerInitialLives)); // This state is active until the end of the play.
            levelController.InitLevel(gameData, game);
        }

        public override void Exit () {
            base.Exit();
            levelScreen.SetActive(false);
        }

        #endregion
	
    }

}