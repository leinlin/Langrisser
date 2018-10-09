using System;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C10 RID: 3088
	[CustomLuaClass]
	[AttributeUsage(AttributeTargets.All)]
	public class ControllerDescriptionAttribute : Attribute
	{
		// Token: 0x0600D8BC RID: 55484 RVA: 0x003AE5C8 File Offset: 0x003AC7C8
		public ControllerDescriptionAttribute(string prefabPath, string controllerName)
		{
			this.prefabPath = prefabPath;
			this.controllerName = controllerName;
		}

		// Token: 0x0400850C RID: 34060
		public string prefabPath;

		// Token: 0x0400850D RID: 34061
		public string controllerName;
	}
}
