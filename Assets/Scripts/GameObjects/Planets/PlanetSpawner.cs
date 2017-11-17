using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlanetSpawner : MonoBehaviour {

    #region Fields / Properties

    private List<GameObject> currentPlanets;

    #endregion

    #region Public Behaviour

    public void SpawnPlanets (List<Planet> planets, GameObject player) {
        currentPlanets = new List<GameObject>();
        planets.ForEach(planet => currentPlanets.Add(SpawnPlanet(planet, player)));
    }

    public GameObject SpawnPlanet (Planet planet, GameObject player) {
        GameObject currentPlanet = Instantiate(planet.Prefab, transform);
        currentPlanet.GetComponent<PlanetController>().Init(planet.Speed, player);
        return currentPlanet;
    }

    #endregion
	
}