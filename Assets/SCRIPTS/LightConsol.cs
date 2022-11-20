using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LightConsol : MonoBehaviour
{
    public GameObject cityLights;
    //public Light lampName;
    public SoundManager soundmanager;
    public bool isLightOn;

    private void Start()
    {
        isLightOn = false;
    }


    // Start is called before the first frame update
    void OnMouseDown()
    {
        if (isLightOn)
        {
            //lampName.enabled = false;
            cityLights.SetActive(false);
            isLightOn = false;
            soundmanager.PlaySwitchOnClick();
        }
        else
        {
            //lampName.enabled = true;
            cityLights.SetActive(true);
            //lampName.color = Color.green;
            isLightOn = true;
            soundmanager.PlaySwitchOnClick();
        }
    }

    // Update is called once per frame
    void Update ()
    {
        
    }
}
