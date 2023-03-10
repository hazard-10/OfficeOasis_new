// "WaveVR SDK 
// © 2017 HTC Corporation. All Rights Reserved.
//
// Unless otherwise required by copyright law and practice,
// upon the execution of HTC SDK license agreement,
// HTC grants you access to and use of the WaveVR SDK(s).
// You shall fully comply with all of HTC’s SDK license agreement terms and
// conditions signed by you and all SDK and API requirements,
// specifications, and documentation provided by HTC to You."

using UnityEngine;
using Wave.Essence.Eye;

namespace Wave.Essence.Samples.Raycast
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(MeshRenderer))]
	sealed class EyeTrackingCube : MonoBehaviour
	{
		MeshRenderer m_MeshRenderer = null;

		void Start()
		{
			m_MeshRenderer = GetComponent<MeshRenderer>();
		}

		void Update()
		{
			if (EyeManager.Instance != null)
				m_MeshRenderer.enabled = EyeManager.Instance.IsEyeTrackingAvailable();
			else
				m_MeshRenderer.enabled = false;
		}
	}
}
