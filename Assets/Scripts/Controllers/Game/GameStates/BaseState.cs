using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameStates {

    public class BaseState : State {

        #region Fields

        protected GameController gameController;
        protected Game game;
        protected LevelController levelController;
        protected GameObject levelScreen;
        protected GameObject mainMenuScreen;

        #endregion

        #region Mono Behaviour

        void Awake () {
            gameController = GetComponent<GameController>();
            game = gameController.Game;
            levelController = gameController.LevelController;
            levelScreen = gameController.LevelScreen;
            mainMenuScreen = gameController.MainMenuScreen;
        }

        #endregion

    }

}