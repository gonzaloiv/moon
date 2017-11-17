using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameStates {

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
            levelScreen.SetActive(false);
            mainMenuScreen.SetActive(false);
        }

        #endregion
	
    }

}