using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettinsMenu : MonoBehaviour {

	public AudioMixer audioMixer;

	public Dropdown resolutionDropdown;

	Resolution[] resolutions;

    public static bool resolutionSet;

	void Start ()
	{
        //if (resolutionSet == false)
        //{
        //}
            resolutions = Screen.resolutions;
        //takes away text
        resolutionDropdown.ClearOptions ();
		//adds resolutions
		int currentResolution = 0;
		List<string> options = new List<string> ();
		//format
		int currentResolutionIndex = 0;
		for (int i = 0; i < resolutions.Length; i++)
		{
			string option = resolutions[i].width + " x " + resolutions[i].height;
			options.Add(option);

			if (resolutions [i].width == Screen.currentResolution.width &&
				resolutions[i].height == Screen.currentResolution.height)
			{
				currentResolutionIndex = i;
			}
		}
		//added
		resolutionDropdown.AddOptions (options);
		resolutionDropdown.value = currentResolutionIndex;
		resolutionDropdown.RefreshShownValue ();
	}

	public void SetResolution (int resolutionIndex)
	{
        Resolution resolution = resolutions [resolutionIndex];
		Screen.SetResolution (resolution.width, resolution.height, Screen.fullScreen);
    }

	public void SetVolume (float volume)
	{
		audioMixer.SetFloat ("Volume", volume);
	}

	public void SetQuality (int qualityIndex)
	{
		QualitySettings.SetQualityLevel (qualityIndex);
	}

	public void SetFullscreen (bool isFullscreen)
	{
		Screen.fullScreen = isFullscreen;
	}
}