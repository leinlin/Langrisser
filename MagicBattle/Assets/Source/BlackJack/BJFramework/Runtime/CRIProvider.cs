using System;
using System.IO;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x020010F2 RID: 4338
	public class CRIProvider : ICRIProvider
	{
		// Token: 0x060159CA RID: 88522 RVA: 0x00580634 File Offset: 0x0057E834
		public GameObject GetCRIManagerObject()
		{
			return CriWare.managerObject;
		}

		// Token: 0x060159CB RID: 88523 RVA: 0x0058063C File Offset: 0x0057E83C
		public void Pause(bool pause)
		{
			CriAtomPlugin.Pause(pause);
		}

		// Token: 0x060159CC RID: 88524 RVA: 0x00580644 File Offset: 0x0057E844
		public void CriRegisterAcf(string acfFullPath)
		{
			if (CriWare.IsStreamingAssetsPath(acfFullPath))
			{
				CriAtomEx.RegisterAcf(null, Path.Combine(CriWare.streamingAssetsPath, acfFullPath));
			}
			else
			{
				CriAtomEx.RegisterAcf(null, acfFullPath);
			}
		}

		// Token: 0x060159CD RID: 88525 RVA: 0x00580670 File Offset: 0x0057E870
		public void AddCRIComponentSources()
		{
			this.m_criBackGroundSource = CriWare.managerObject.AddComponent<CriAtomSource>();
			this.m_criSoundSource = CriWare.managerObject.AddComponent<CriAtomSource>();
			this.m_criSpeechSource = CriWare.managerObject.AddComponent<CriAtomSource>();
		}

		// Token: 0x060159CE RID: 88526 RVA: 0x005806A4 File Offset: 0x0057E8A4
		public void CRIRemoveCueSheet(string sheetName)
		{
			CriAtom.RemoveCueSheet(sheetName);
		}

		// Token: 0x060159CF RID: 88527 RVA: 0x005806AC File Offset: 0x0057E8AC
		public void CRIAddCueSheet(string sheetName, string acbFullPath, string awbFullPath)
		{
			if (CriAtom.GetCueSheet(sheetName) == null)
			{
				CriAtomCueSheet criAtomCueSheet = CriAtom.AddCueSheet(sheetName, acbFullPath, awbFullPath, null);
				if (criAtomCueSheet == null || (criAtomCueSheet.acbFile == string.Empty && criAtomCueSheet.awbFile == string.Empty))
				{
					global::Debug.LogError(string.Format("Failed to add cue sheet: sheetName={0}, acbFullPath={1}, awbFullPath={2}", sheetName, acbFullPath, awbFullPath));
					this.CRIRemoveCueSheet(sheetName);
				}
			}
		}

		// Token: 0x060159D0 RID: 88528 RVA: 0x0058071C File Offset: 0x0057E91C
		public float GetCueLength(string sheetName, string cueName)
		{
			CriAtomEx.CueInfo cueInfo2;
			bool cueInfo = this.GetCueInfo(sheetName, cueName, out cueInfo2);
			if (cueInfo)
			{
				return (float)cueInfo2.length * 0.001f;
			}
			return 0f;
		}

		// Token: 0x060159D1 RID: 88529 RVA: 0x00580750 File Offset: 0x0057E950
		public void SetCategoryVolume(string category, float volume)
		{
			CriAtom.SetCategoryVolume(category, volume);
		}

		// Token: 0x060159D2 RID: 88530 RVA: 0x0058075C File Offset: 0x0057E95C
		public float GetCategoryVolume(string category)
		{
			return CriAtom.GetCategoryVolume(category);
		}

		// Token: 0x060159D3 RID: 88531 RVA: 0x00580764 File Offset: 0x0057E964
		public IAudioPlayback PlaySound(string sound)
		{
			CriAtomExPlayback playback = this.m_criSoundSource.Play(sound);
			if (playback.status == CriAtomExPlayback.Status.Removed)
			{
				global::Debug.LogError(string.Format("CRI Failed to play: {0}", sound));
				return null;
			}
			return new CriAudioPlayback(playback, sound);
		}

		// Token: 0x060159D4 RID: 88532 RVA: 0x005807A4 File Offset: 0x0057E9A4
		public void StopSound()
		{
			this.m_criSoundSource.Stop();
		}

		// Token: 0x060159D5 RID: 88533 RVA: 0x005807B4 File Offset: 0x0057E9B4
		private bool GetCueInfo(string sheetName, string cueName, out CriAtomEx.CueInfo cueInfo)
		{
			cueInfo = default(CriAtomEx.CueInfo);
			CriAtomCueSheet cueSheet = CriAtom.GetCueSheet(sheetName);
			if (cueSheet == null)
			{
				global::Debug.LogError(string.Format("Failed to get cue sheet: {0}", sheetName));
				return false;
			}
			return cueSheet.acb.GetCueInfo(cueName, out cueInfo);
		}

		// Token: 0x0400BCDB RID: 48347
		private CriAtomSource m_criBackGroundSource;

		// Token: 0x0400BCDC RID: 48348
		private CriAtomSource m_criSoundSource;

		// Token: 0x0400BCDD RID: 48349
		private CriAtomSource m_criSpeechSource;
	}
}
