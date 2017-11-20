using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlanetSpawner : MonoBehaviour {

    #region Fields / Properties

    private List<GameObject> currentPlanets;

    #endregion

    #region Public Behaviour

    public List<GameObject> SpawnPlanets (List<Planet> planets, GameObject player, GameObject goal) {
        currentPlanets = new List<GameObject>();
        planets.ForEach(planet => currentPlanets.Add(SpawnPlanet(planet, player, goal)));
        return currentPlanets;
    }

    public GameObject SpawnPlanet (Planet planet, GameObject player, GameObject goal = null) {
        GameObject currentPlanet = Instantiate(planet.Prefab, transform);
        currentPlanet.GetComponent<PlanetController>().Init(planet.Speed, player, goal);
        return currentPlanet;
    }

    #endregion
	
}