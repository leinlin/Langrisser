using System;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x0200003B RID: 59
	public class GameClientSetting : ScriptableObject
	{
		// Token: 0x04000129 RID: 297
		public bool DisableUnityEngineLog;

		// Token: 0x0400012A RID: 298
		public bool Log2Persistent;

		// Token: 0x0400012B RID: 299
		public ResourcesSettings ResourcesSetting;

		// Token: 0x0400012C RID: 300
		public ResolutionSettings ResolutionSetting;

		// Token: 0x0400012D RID: 301
		public SceneSettings SceneSetting;

		// Token: 0x0400012E RID: 302
		public DynamicAssemblySettings DynamicAssemblySetting;

		// Token: 0x0400012F RID: 303
		public LuaSettings LuaSetting;

		// Token: 0x04000130 RID: 304
		public ConfigDataSettings ConfigDataSetting;

		// Token: 0x04000131 RID: 305
		public AudioSettings AudioSetting;

		// Token: 0x04000132 RID: 306
		public StringTableSettings StringTableSetting;

		// Token: 0x04000133 RID: 307
		public bool DisableUserGuide;

		// Token: 0x04000134 RID: 308
		public string UITaskRegisterTypeDNName = "Assembly-CSharp@BlackJack.ProjectSample.SampleGameUITaskRegister";

		// Token: 0x04000135 RID: 309
		public LoginSettings LoginSetting;

		// Token: 0x04000136 RID: 310
		public static string defaultClientPrefPath = "Assets/GameProject/Resources/GameClientSetting";
	}
}
