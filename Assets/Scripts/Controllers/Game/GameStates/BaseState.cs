using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameStates {

    public class BaseState : State {

        #region Fields

        protected GameController gameController;
        protected GameData gameData;
        protected GameConfigData gameConfigData;
        protected LevelController levelController;
        protected GameObject levelScreen;
        protected GameObject mainMenuScreen;
        protected Game game;

        #endregion

        #region Mono Behaviour

        void Awake () {
            gameController = GetComponent<GameController>();
            gameData = gameController.GameData;
            gameConfigData = gameController.GameConfigData;
            levelController = gameController.LevelController;
            levelScreen = gameController.LevelScreen;
            mainMenuScreen = gameController.MainMenuScreen;
            game = gameController.Game;
        }

        #endregion

    }

}