using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arcamera_title : MonoBehaviour
{
    Text title;
    // Start is called before the first frame update
    void Start()
    {
        title = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        title.text = DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName;
    }
}
