using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelStates {

    public class LevelState : BaseState {

        #region Public Behaviour

        public void OnPlayerGoalEvent () {
            levelController.ToLevelEndState();
        }

        #endregion

        #region Protected Behaviour

        protected override void AddListeners () {
            PlayerController.PlayerGoalEvent += OnPlayerGoalEvent;
        }

        protected override void RemoveListeners () {
            PlayerController.PlayerGoalEvent += OnPlayerGoalEvent;
        }

        #endregion

    }

}