using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelStates {

    public class BaseState : State {

        #region Fields / Properties

        protected LevelController levelController;
        protected LevelScreenController levelScreenController;
        protected LevelSpawner levelSpawner;
        protected Game game;
        protected LevelData currentLevelData { get { return game.CurrentLevelData; } }

        #endregion

        #region Mono Behaviour

        void Awake () {
            levelController = GetComponent<LevelController>();
            levelScreenController = levelController.LevelScreenController;
            levelSpawner = levelController.LevelSpawner;
            game = levelController.Game;
        }

        #endregion

    }

}