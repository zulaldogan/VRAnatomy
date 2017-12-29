using UnityEngine;
using System.Collections;

public class ModelController : MonoBehaviour {

    public Transform ObjectTransform;


    /// <summary>
    /// Modeli döndürür
    /// </summary>
    /// <param name="direction">1:sağ -1:sol</param>
    public void StartRotation(int direction)
    {
        StartCoroutine(Rotate(direction));
    }


    //saniyede 50 kez çağrılır. 3 derece çevirir modeli.
    private IEnumerator Rotate(int direction)
    {
        while (true)
        {
            ObjectTransform.Rotate(Vector3.up, 3f * direction);
            yield return new WaitForSeconds(0.05f);
        }
    }

    //modelin dönmesini durdurur.
    public void StopRotation()
    {
        StopAllCoroutines();
    }

}
