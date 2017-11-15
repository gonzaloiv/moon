using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerStates {

    public class DragState : BaseState {

        #region Fields / Properties

        private Vector3 initialPosition;
        private Vector3 initialMousePosition;
        private Vector3 currentMousePosition;

        #endregion

        #region Mono Behaviour

        void OnMouseDrag () {
            if (!this.enabled) return;
            currentMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = initialPosition + currentMousePosition - initialMousePosition;
        }

        void OnMouseUp () {
            playerController.ToMoveState();
        }

        #endregion

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            initialPosition = transform.position;
            initialMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("InitialPosition " + initialPosition);
            Debug.Log("InitialMousePosition " + initialMousePosition);
        }

        #endregion
	
    }

}