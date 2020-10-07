using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class EyeTrackerSupported : MonoBehaviour
{
    [SerializeField]
    private Text eyeTrackerSupportedText;

    public EyeTrackerSupported(Text eyeTrackerSupportedText)
    {
        this.eyeTrackerSupportedText = eyeTrackerSupportedText;
    }


    void OnEnable()
    {
        ARFaceManager faceManager = FindObjectOfType<ARFaceManager>();
        
        if(faceManager != null && faceManager.subsystem != null && faceManager.subsystem.SubsystemDescriptor.supportsEyeTracking)
        {
            EyeTrackerSupportedText.text = "Eye Tracking is supported on this device";
        }
        else 
        {
            EyeTrackerSupportedText.text = "Eye Tracking is not supported on this device";
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}