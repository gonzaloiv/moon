using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour {

    #region Fields / Properties

    private float speed;

    #endregion

    #region Mono Behaviour

    void Update() {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }

    #endregion

    #region Public Behaviour

    public void Init(float speed) {
        this.speed = speed;
    }

    #endregion
	
}
