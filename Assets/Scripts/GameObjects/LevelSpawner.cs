using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour {

    #region Fields / Properties

    [SerializeField] private GameObject cam; // Init() and Disable() should be called from LevelController
    [SerializeField] private PlayerSpawner playerSpawner;
    [SerializeField] private PlanetSpawner planetSpawner;

    #endregion

    #region Public Behaviour

    public void SpawnLevel (LevelData levelData) { // TODO: Planets gravity on Player should start on Player's Init, just from the closest planet 
        GameObject player = playerSpawner.SpawnPlayer(levelData.PlayerInitialPosition, cam);
        GameObject goal = planetSpawner.SpawnPlanet(levelData.Goal, player);
        List<GameObject> planets = planetSpawner.SpawnPlanets(levelData.Planets, player, goal);
        cam.GetComponent<CameraController>().Init(planets);
    }

    #endregion
    	
}