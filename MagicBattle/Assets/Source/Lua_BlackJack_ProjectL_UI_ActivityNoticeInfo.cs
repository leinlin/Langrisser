using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001353 RID: 4947
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo : LuaObject
{
	// Token: 0x0601A93A RID: 108858 RVA: 0x007E48C4 File Offset: 0x007E2AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeInfo o = new ActivityNoticeInfo();
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

	// Token: 0x0601A93B RID: 108859 RVA: 0x007E490C File Offset: 0x007E2B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActivityId(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeInfo activityNoticeInfo = (ActivityNoticeInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeInfo.ActivityId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A93C RID: 108860 RVA: 0x007E4960 File Offset: 0x007E2B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ActivityId(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeInfo activityNoticeInfo = (ActivityNoticeInfo)LuaObject.checkSelf(l);
			int activityId;
			LuaObject.checkType(l, 2, out activityId);
			activityNoticeInfo.ActivityId = activityId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A93D RID: 108861 RVA: 0x007E49B8 File Offset: 0x007E2BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsLarge(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeInfo activityNoticeInfo = (ActivityNoticeInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeInfo.IsLarge);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A93E RID: 108862 RVA: 0x007E4A0C File Offset: 0x007E2C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsLarge(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeInfo activityNoticeInfo = (ActivityNoticeInfo)LuaObject.checkSelf(l);
			bool isLarge;
			LuaObject.checkType(l, 2, out isLarge);
			activityNoticeInfo.IsLarge = isLarge;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A93F RID: 108863 RVA: 0x007E4A64 File Offset: 0x007E2C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SortId(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeInfo activityNoticeInfo = (ActivityNoticeInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeInfo.SortId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A940 RID: 108864 RVA: 0x007E4AB8 File Offset: 0x007E2CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SortId(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeInfo activityNoticeInfo = (ActivityNoticeInfo)LuaObject.checkSelf(l);
			int sortId;
			LuaObject.checkType(l, 2, out sortId);
			activityNoticeInfo.SortId = sortId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A941 RID: 108865 RVA: 0x007E4B10 File Offset: 0x007E2D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ImageName(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeInfo activityNoticeInfo = (ActivityNoticeInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeInfo.ImageName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A942 RID: 108866 RVA: 0x007E4B64 File Offset: 0x007E2D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ImageName(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeInfo activityNoticeInfo = (ActivityNoticeInfo)LuaObject.checkSelf(l);
			string imageName;
			LuaObject.checkType(l, 2, out imageName);
			activityNoticeInfo.ImageName = imageName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A943 RID: 108867 RVA: 0x007E4BBC File Offset: 0x007E2DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeInfo activityNoticeInfo = (ActivityNoticeInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A944 RID: 108868 RVA: 0x007E4C10 File Offset: 0x007E2E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeInfo activityNoticeInfo = (ActivityNoticeInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			activityNoticeInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A945 RID: 108869 RVA: 0x007E4C68 File Offset: 0x007E2E68
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ActivityNoticeInfo");
		string name = "ActivityId";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.get_ActivityId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.set_ActivityId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache1, true);
		string name2 = "IsLarge";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.get_IsLarge);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.set_IsLarge);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache3, true);
		string name3 = "SortId";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.get_SortId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.set_SortId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache5, true);
		string name4 = "ImageName";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.get_ImageName);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.set_ImageName);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache7, true);
		string name5 = "Desc";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.get_Desc);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.set_Desc);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.<>f__mg$cacheA, typeof(ActivityNoticeInfo));
	}

	// Token: 0x04010C76 RID: 68726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010C77 RID: 68727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010C78 RID: 68728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010C79 RID: 68729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010C7A RID: 68730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010C7B RID: 68731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010C7C RID: 68732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010C7D RID: 68733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010C7E RID: 68734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010C7F RID: 68735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010C80 RID: 68736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
