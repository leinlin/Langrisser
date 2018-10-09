using System;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000023 RID: 35
	public interface ICRIProvider
	{
		// Token: 0x060002A6 RID: 678
		GameObject GetCRIManagerObject();

		// Token: 0x060002A7 RID: 679
		void CriRegisterAcf(string acfFullPath);

		// Token: 0x060002A8 RID: 680
		void AddCRIComponentSources();

		// Token: 0x060002A9 RID: 681
		void CRIRemoveCueSheet(string sheetName);

		// Token: 0x060002AA RID: 682
		void CRIAddCueSheet(string sheetName, string acbFullPath, string awbFullPath);

		// Token: 0x060002AB RID: 683
		float GetCueLength(string sheetName, string cueName);

		// Token: 0x060002AC RID: 684
		void SetCategoryVolume(string category, float volume);

		// Token: 0x060002AD RID: 685
		float GetCategoryVolume(string category);

		// Token: 0x060002AE RID: 686
		IAudioPlayback PlaySound(string sound);

		// Token: 0x060002AF RID: 687
		void Pause(bool pause);
	}
}
