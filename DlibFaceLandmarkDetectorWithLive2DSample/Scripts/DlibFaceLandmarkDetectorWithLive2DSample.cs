using UnityEngine;
using System.Collections;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif

namespace DlibFaceLandmarkDetectorWithLive2DSample
{
    public class DlibFaceLandmarkDetectorWithLive2DSample : MonoBehaviour
    {

        // Use this for initialization
        void Start ()
        {

        }

        // Update is called once per frame
        void Update ()
        {

        }

        public void OnShowLicenseButton ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("ShowLicense");
            #else
            Application.LoadLevel ("ShowLicense");
            #endif
        }

        public void OnWebCamTextureLive2DSample ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("WebCamTextureLive2DSample");
            #else
            Application.LoadLevel ("WebCamTextureLive2DSample");
            #endif
        }

        public void OnWebCamTextureLive2DSample320x240 ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("WebCamTextureLive2DSample320x240");
            #else
            Application.LoadLevel ("WebCamTextureLive2DSample320x240");
            #endif
        }
    }
}
