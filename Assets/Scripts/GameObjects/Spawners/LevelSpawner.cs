using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour { // This could be replaced by a common interface between spawners and LevelController

    #region Fields / Properties

    [SerializeField] private PlayerSpawner playerSpawner;
    [SerializeField] private PlanetSpawner planetSpawner;

    #endregion

    #region Public Behaviour

    public void SpawnLevel(LevelData levelData) {
        GameObject player = playerSpawner.SpawnPlayer(levelData.PlayerInitialPosition);
        planetSpawner.SpawnPlanets(levelData.Planets, player);
    }

    #endregion
	
}