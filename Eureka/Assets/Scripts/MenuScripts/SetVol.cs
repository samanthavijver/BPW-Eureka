using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVol : MonoBehaviour {

    public AudioMixer masterMixer;

	public void SetMasterLvl(float masterLvl)
    {
        masterMixer.SetFloat("masterVol", masterLvl);
    }

    public void SetMusicLvl(float musicLvl)
    {
        masterMixer.SetFloat("musicVol", musicLvl);
    }

    public void SetSfxLvl(float sfxLvl)
    {
        masterMixer.SetFloat("sfxVol", sfxLvl);
    }

    //public void ClearVolume()
    //{
        //masterMixer.ClearFloat("musicVol");
    //}

}
