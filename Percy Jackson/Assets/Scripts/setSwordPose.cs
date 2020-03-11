using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WiimoteApi;

public class setSwordPose : MonoBehaviour
{
    public Wiimote remote1;

    // Start is called before the first frame update
    void Start()
    {
        InitWiimotes();

        
        
    }

    // Update is called once per frame
    void Update()
    {
        //FinishedWithWiimotes();
    }


    void InitWiimotes() {
        WiimoteManager.FindWiimotes(); // Poll native bluetooth drivers to find Wiimotes
        foreach(Wiimote remote in WiimoteManager.Wiimotes) {
            remote1 = remote;
        }
        remote1.SendPlayerLED(false, true, true, false); // LEDs will look like this: [* - - *]
    }


    void FinishedWithWiimotes() {
        foreach(Wiimote remote in WiimoteManager.Wiimotes) {
            WiimoteManager.Cleanup(remote);
        }
    }
    
}
