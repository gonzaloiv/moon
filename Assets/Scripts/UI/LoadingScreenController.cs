using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreenController : MonoBehaviour {

    #region Mono Behaviour

    void Start () {
        Debug.Log("Loading MainScene...");
        SceneManager.LoadScene((int) GameScene.Main);
    }

    #endregion

}
