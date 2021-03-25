using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using VoxelBusters;
using VoxelBusters.NativePlugins;

public class SharingScreen : MonoBehaviour
{
	private bool isSharing = false;

	public void RateMyApp()
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			NPBinding.Utility.OpenStoreLink("https://play.google.com/store/apps/details?id=com.PotatoARStudio.Aprendo");
		}
	}

	public void CalficaMiApp()
    {
		Application.OpenURL("https://play.google.com/store/apps/details?id=com.PotatoARStudio.Aprendo");
    }

	public void ShareSocialMedia()
	{
		isSharing = true;
	}

	void LateUpdate()
	{
		if (isSharing == true)
		{
			isSharing = false;

			StartCoroutine(CaptureScreenShoot());
		}
	}

	IEnumerator CaptureScreenShoot()
	{
		yield return new WaitForEndOfFrame();

		Texture2D texture = ScreenCapture.CaptureScreenshotAsTexture();

		ShareSheet(texture);

		Object.Destroy(texture);

	}

	private void ShareSheet(Texture2D texture)
	{
		ShareSheet _shareSheet = new ShareSheet();

		_shareSheet.Text = "Mira mis logros en la app Aprendo de potato AR Studio!!!";
		_shareSheet.AttachImage(texture);
		_shareSheet.URL = "https://www.facebook.com/Potato-AR-Studio-100541188158109";

		NPBinding.Sharing.ShowView(_shareSheet, FinishSharing);
	}

	private void FinishSharing(eShareResult _result)
	{
		Debug.Log(_result);
	}
}
