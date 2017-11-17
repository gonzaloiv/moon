using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace PlayerStates {

    public class DragState : BaseState {

        #region Fields / Properties

        private const float ANIMATION_TIME = 0.3f;

        private Vector3 initialPosition;
        private Vector3 initialMousePosition;
        private Vector3 mouseDrag;

        #endregion

        #region Mono Behaviour

        void OnMouseDrag () {
            if (!this.enabled) return;
            mouseDrag = cam.ScreenToWorldPoint(Input.mousePosition) - initialMousePosition;
            transform.position = mouseDrag.magnitude < GameConfig.PlayerMaxDragDistance ? initialPosition + mouseDrag : transform.position;
        }

        void OnMouseUp () {
            rb.AddForce((initialPosition - transform.position) * GameConfig.PlayerSpeed);
            rend.material.DOFade(1f, ANIMATION_TIME);
            playerController.ToMoveState();
        }

        #endregion

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            rend.material.DOFade(0.6f, ANIMATION_TIME); // TODO: Defining color rules on GameConfig
            initialPosition = transform.position;
            initialMousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        }

        #endregion
	
    }

}