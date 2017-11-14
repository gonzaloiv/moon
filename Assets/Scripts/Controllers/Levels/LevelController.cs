using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    #region Fields / Properties

    [SerializeField] private LevelScreenController levelScreenController;
    [SerializeField] private LevelSpawner levelSpawner;

    #endregion

    #region Public Behaviour

    public void InitLevel (LevelData levelData) {
        levelScreenController.Init(levelData);
        levelSpawner.SpawnLevel(levelData);
    }

    #endregion
	
}
