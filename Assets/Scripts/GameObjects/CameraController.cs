using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CameraController : MonoBehaviour { // Later should be a state machine called from LevelController states and initialized with leve objs...

    #region Fields / Properties

    private List<Renderer> levelRenderers;
    private Vector3 nextPosition = GameConfig.CameraInitialPosition;

    #endregion

    #region Mono Behaviour

    void Update () {
        transform.position = Vector3.Lerp(transform.position, nextPosition, GameConfig.CameraSpeed); 
    }

    #endregion

    #region Public Behaviour

    public void Init (List<GameObject> objs) {
        this.levelRenderers = new List<Renderer>();
        objs.ForEach(obj => levelRenderers.Add(obj.GetComponent<Renderer>()));
        nextPosition = GameConfig.CameraInitialPosition;
        StartCoroutine(TravellingRoutine());
    }

    public void Disable () {
        StopAllCoroutines();
        nextPosition = GameConfig.CameraInitialPosition;
    }

    #endregion

    #region Private Behaviour

    private IEnumerator TravellingRoutine () {
        while (gameObject.activeInHierarchy) {
            yield return new WaitForSeconds(1);
            nextPosition += levelRenderers.FirstOrDefault(rend => !rend.isVisible) ? new Vector3(0, 0, -1) : transform.position.z > 1 ? new Vector3(0, 0, 1) : new Vector3(0, 0, 0); 
        }    
    }

    #endregion
	
}
