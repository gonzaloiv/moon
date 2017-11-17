﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerStates {

    public class BaseState : State {

        #region Fields / Properties

        protected PlayerController playerController;
        protected Rigidbody2D rb;
        protected Renderer rend;
        protected Camera cam;

        #endregion

        #region Mono Behaviour

        void Awake () {
            playerController = GetComponent<PlayerController>();
            rb = GetComponent<Rigidbody2D>();
            rend = GetComponent<Renderer>();
            cam = playerController.Cam;
        }

        #endregion

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            this.enabled = true;
        }

        public override void Exit () {
            base.Exit();
            this.enabled = false;
        }

        #endregion
	
    }

}