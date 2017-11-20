using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelStates {

    public class LevelStartState : BaseState {

        #region Public Behaviour

        public override void Enter () {
            base.Enter();
            levelScreenController.Show(currentLevelData);
            levelSpawner.SpawnLevel(currentLevelData);
            StartCoroutine(LevelStartRoutine());
        }

        #endregion

        #region Private Behaviour

        private IEnumerator LevelStartRoutine () { // Temp. testing routine...
            yield return new WaitForSeconds(1);
            levelController.ToLevelState();
        }

        #endregion

    }

}