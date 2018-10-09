using System;
using SLua;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x02000881 RID: 2177
	[CustomLuaClass]
	public class GlobalMonoBehaviourEventListener
	{
		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x06006BDE RID: 27614 RVA: 0x001E37F8 File Offset: 0x001E19F8
		// (set) Token: 0x06006BDD RID: 27613 RVA: 0x001E37F0 File Offset: 0x001E19F0
		public static IMonoBehaviourEventListener Instance
		{
			get
			{
				return GlobalMonoBehaviourEventListener.s_instance;
			}
			set
			{
				GlobalMonoBehaviourEventListener.s_instance = value;
			}
		}

		// Token: 0x040052F9 RID: 21241
		private static IMonoBehaviourEventListener s_instance;
	}
}
