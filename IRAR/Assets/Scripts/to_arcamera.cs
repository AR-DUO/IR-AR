using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class to_arcamera : MonoBehaviour
{

   public void Move_to_cam()
    {
        SceneManager.LoadScene("AR_Cam");
        SceneManager.LoadScene("ar_scene");
    }
}
