using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001566 RID: 5478
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RiftLevelRaidNetTask : LuaObject
{
	// Token: 0x06020CB3 RID: 134323 RVA: 0x00AFBE70 File Offset: 0x00AFA070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int riftLevelId;
			LuaObject.checkType(l, 2, out riftLevelId);
			int count;
			LuaObject.checkType(l, 3, out count);
			RiftLevelRaidNetTask o = new RiftLevelRaidNetTask(riftLevelId, count);
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

	// Token: 0x06020CB4 RID: 134324 RVA: 0x00AFBED0 File Offset: 0x00AFA0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelRaidNetTask riftLevelRaidNetTask = (RiftLevelRaidNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelRaidNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CB5 RID: 134325 RVA: 0x00AFBF24 File Offset: 0x00AFA124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExtraReward(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelRaidNetTask riftLevelRaidNetTask = (RiftLevelRaidNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelRaidNetTask.ExtraReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CB6 RID: 134326 RVA: 0x00AFBF78 File Offset: 0x00AFA178
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RiftLevelRaidNetTask");
		string name = "Reward";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelRaidNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelRaidNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelRaidNetTask.get_Reward);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_RiftLevelRaidNetTask.<>f__mg$cache0, null, true);
		string name2 = "ExtraReward";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelRaidNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelRaidNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelRaidNetTask.get_ExtraReward);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_RiftLevelRaidNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelRaidNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelRaidNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelRaidNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RiftLevelRaidNetTask.<>f__mg$cache2, typeof(RiftLevelRaidNetTask), typeof(UINetTask));
	}

	// Token: 0x04016BC9 RID: 93129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016BCA RID: 93130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016BCB RID: 93131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
