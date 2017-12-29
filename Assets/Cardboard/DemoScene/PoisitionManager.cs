using UnityEngine;
using System.Collections;

public class PoisitionManager : MonoBehaviour {

    public Transform PlayerCameraTransform;
    public Transform ControlPanel;
    public Transform RotationControlPanel;
    public Transform[] PlayerPositions;
    public Transform[] ControlPanelTransform;
    public Transform[] RotationControlTransform;

    public void Start()
    {
        ChangeCameraPosition(0);
    }

    //camera pozisyonunu değiştirir. Ve rotation'ını.
    public void ChangeCameraPosition(int target)
    {
        //player
        iTween.MoveTo(PlayerCameraTransform.gameObject, PlayerPositions[target].position, 12f * Time.deltaTime);
        iTween.RotateTo(PlayerCameraTransform.gameObject, PlayerPositions[target].localEulerAngles, 12f * Time.deltaTime);
        //control panel
        iTween.MoveTo(ControlPanel.gameObject, ControlPanelTransform[target].position, 12f * Time.deltaTime);
        iTween.RotateTo(ControlPanel.gameObject, ControlPanelTransform[target].localEulerAngles, 12f * Time.deltaTime);
        //rotation control panel
        iTween.RotateTo(RotationControlPanel.gameObject, RotationControlTransform[target].localEulerAngles, 12f * Time.deltaTime);
    }
}
