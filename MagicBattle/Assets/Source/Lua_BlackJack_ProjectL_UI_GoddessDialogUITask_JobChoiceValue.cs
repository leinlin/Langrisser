using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200146D RID: 5229
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue : LuaObject
{
	// Token: 0x0601E3B8 RID: 123832 RVA: 0x009B62D4 File Offset: 0x009B44D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask.JobChoiceValue o = new GoddessDialogUITask.JobChoiceValue();
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

	// Token: 0x0601E3B9 RID: 123833 RVA: 0x009B631C File Offset: 0x009B451C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_protagonistInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask.JobChoiceValue jobChoiceValue = (GoddessDialogUITask.JobChoiceValue)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jobChoiceValue.m_protagonistInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3BA RID: 123834 RVA: 0x009B6370 File Offset: 0x009B4570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_protagonistInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask.JobChoiceValue jobChoiceValue = (GoddessDialogUITask.JobChoiceValue)LuaObject.checkSelf(l);
			ConfigDataProtagonistInfo protagonistInfo;
			LuaObject.checkType<ConfigDataProtagonistInfo>(l, 2, out protagonistInfo);
			jobChoiceValue.m_protagonistInfo = protagonistInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3BB RID: 123835 RVA: 0x009B63C8 File Offset: 0x009B45C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_value(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask.JobChoiceValue jobChoiceValue = (GoddessDialogUITask.JobChoiceValue)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jobChoiceValue.m_value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3BC RID: 123836 RVA: 0x009B641C File Offset: 0x009B461C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_value(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogUITask.JobChoiceValue jobChoiceValue = (GoddessDialogUITask.JobChoiceValue)LuaObject.checkSelf(l);
			int value;
			LuaObject.checkType(l, 2, out value);
			jobChoiceValue.m_value = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3BD RID: 123837 RVA: 0x009B6474 File Offset: 0x009B4674
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GoddessDialogUITask.JobChoiceValue");
		string name = "m_protagonistInfo";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.get_m_protagonistInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.set_m_protagonistInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache1, true);
		string name2 = "m_value";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.get_m_value);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.set_m_value);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.<>f__mg$cache4, typeof(GoddessDialogUITask.JobChoiceValue));
	}

	// Token: 0x040144C0 RID: 83136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040144C1 RID: 83137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040144C2 RID: 83138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040144C3 RID: 83139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040144C4 RID: 83140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
