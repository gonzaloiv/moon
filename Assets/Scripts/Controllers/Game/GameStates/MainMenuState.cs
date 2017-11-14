using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameStates {

    public class MainMenuState : BaseState {

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            mainMenuScreen.SetActive(true);
        }

        public override void Exit () {
            base.Exit();
            mainMenuScreen.SetActive(false);
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