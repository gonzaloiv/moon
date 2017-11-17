using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelStates {

    public class LevelState : BaseState {

        #region Public Behaviour

        public void OnGoalEvent() {
            levelController.ToLevelEndState();            
        }

        #endregion

        #region Protected Behaviour

        protected override void AddListeners () {
            PlayerController.GoalEvent += OnGoalEvent;
        }

        protected override void RemoveListeners () {
            PlayerController.GoalEvent += OnGoalEvent;
        }

        #endregion

    }

}