using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerStates {

    public class MoveState : BaseState {

        #region Mono Behaviour

        void OnCollisionEnter2D (Collision2D collision2D) {
            switch (collision2D.gameObject.layer) {
            case (int) CollisionLayer.Enemy:
                playerController.ToHitState();
                break;
            case (int) CollisionLayer.Goal:
                playerController.ToGoalState();
                break;
            } // TODO: A third type of collision should be orbits, to always getting out of the state
        }

        #endregion

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            StartCoroutine(MoveRoutine());
        }

        #endregion

        #region Private Behaviour

        private IEnumerator MoveRoutine () { // Temporary auto exit routine
            yield return new WaitForSeconds(1);
            playerController.ToIdleState();
        }

        #endregion

    }

}