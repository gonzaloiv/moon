using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameStates {

    public class MainMenuState : BaseState {

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            mainMenuScreenController.Show();
        }

        public override void Exit () {
            base.Exit();
            mainMenuScreenController.Hide();
        }

        public void OnStartButtonClickEvent () {
            gameController.ToLevelState();
        }

        #endregion

        #region Protected Behaviour

        protected override void AddListeners () {
            MainMenuScreenController.StartButtonClickEvent += OnStartButtonClickEvent;
        }

        protected override void RemoveListeners () {
            MainMenuScreenController.StartButtonClickEvent += OnStartButtonClickEvent;
        }

        #endregion

    }

}