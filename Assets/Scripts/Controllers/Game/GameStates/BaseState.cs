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
        protected MainMenuScreenController mainMenuScreenController;
        protected Game game;

        #endregion

        #region Mono Behaviour

        void Awake () {
            gameController = GetComponent<GameController>();
            gameData = gameController.GameData;
            gameConfigData = gameController.GameConfigData;
            levelController = gameController.LevelController;
            mainMenuScreenController = gameController.MainMenuScreenController;
            game = gameController.Game;
        }

        #endregion

    }

}