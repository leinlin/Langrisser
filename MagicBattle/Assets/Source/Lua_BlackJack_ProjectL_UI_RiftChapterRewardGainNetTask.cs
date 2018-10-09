using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001560 RID: 5472
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RiftChapterRewardGainNetTask : LuaObject
{
	// Token: 0x06020BF0 RID: 134128 RVA: 0x00AF5BB0 File Offset: 0x00AF3DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			RiftChapterRewardGainNetTask o = new RiftChapterRewardGainNetTask(chapterId, index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BF1 RID: 134129 RVA: 0x00AF5C10 File Offset: 0x00AF3E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterRewardGainNetTask riftChapterRewardGainNetTask = (RiftChapterRewardGainNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterRewardGainNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BF2 RID: 134130 RVA: 0x00AF5C64 File Offset: 0x00AF3E64
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RiftChapterRewardGainNetTask");
		string name = "Reward";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterRewardGainNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterRewardGainNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterRewardGainNetTask.get_Reward);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_RiftChapterRewardGainNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterRewardGainNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterRewardGainNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterRewardGainNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RiftChapterRewardGainNetTask.<>f__mg$cache1, typeof(RiftChapterRewardGainNetTask), typeof(UINetTask));
	}

	// Token: 0x04016B12 RID: 92946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016B13 RID: 92947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
