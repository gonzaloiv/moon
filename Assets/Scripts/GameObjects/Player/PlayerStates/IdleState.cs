using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace PlayerStates {

    public class IdleState : BaseState {

        #region Fields / Properties

        private const float ANIMATION_TIME = 0.3f;

        #endregion

        #region Mono Behaviour

        void OnMouseDown () {
            if (!this.enabled) return;
            playerController.ToDragState();
        }

        #endregion

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            StartCoroutine(IdleRoutine());
        }

        public override void Exit() {
            base.Exit();
            StopAllCoroutines();
        }

        #endregion

        #region Private Behaviour

        private IEnumerator IdleRoutine() {
            while(gameObject.activeInHierarchy) {
                transform.DOShakeScale(ANIMATION_TIME, 0.1f);
                yield return new WaitForSeconds(ANIMATION_TIME * 2);
            }
        }

        #endregion
	
    }

}