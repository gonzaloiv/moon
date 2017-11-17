using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour {

    #region Fields / Properties

    [SerializeField] private Camera cam;
    [SerializeField] private PlayerSpawner playerSpawner;
    [SerializeField] private PlanetSpawner planetSpawner;

    #endregion

    #region Public Behaviour

    public void SpawnLevel(LevelData levelData) { // TODO: Planets gravity on Player should start on Player's Init, just from the closest planet 
        GameObject player = playerSpawner.SpawnPlayer(levelData.PlayerInitialPosition, cam);
        planetSpawner.SpawnPlanets(levelData.Planets, player);
    }

    #endregion
	
}