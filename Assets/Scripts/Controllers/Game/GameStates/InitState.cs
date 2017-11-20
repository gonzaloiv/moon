using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameStates {

    // The only purpose of the State is loading local or global data and initializing the game from it
    public class InitState : BaseState {

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            DisableGameScreens();
            StartCoroutine(InitRoutine());
        }

        #endregion

        #region Private Behaviour

        private IEnumerator InitRoutine () {
            yield return null;
            GameConfig.Init(gameConfigData);
            gameController.ToMainMenuState();
        }

        private void DisableGameScreens () {
            levelController.Disable();
            mainMenuScreenController.Hide();
        }

        #endregion
	
    }

}