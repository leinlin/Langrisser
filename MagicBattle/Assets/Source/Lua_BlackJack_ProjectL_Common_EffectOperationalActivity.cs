using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001219 RID: 4633
[Preserve]
public class Lua_BlackJack_ProjectL_Common_EffectOperationalActivity : LuaObject
{
	// Token: 0x060180A5 RID: 98469 RVA: 0x006AB5C4 File Offset: 0x006A97C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				EffectOperationalActivity o = new EffectOperationalActivity();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				ulong instanceId;
				LuaObject.checkType(l, 2, out instanceId);
				int operationalActivityId;
				LuaObject.checkType(l, 3, out operationalActivityId);
				OperationalActivityType operationalActivityType;
				LuaObject.checkEnum<OperationalActivityType>(l, 4, out operationalActivityType);
				EffectOperationalActivity o = new EffectOperationalActivity(instanceId, operationalActivityId, operationalActivityType);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180A6 RID: 98470 RVA: 0x006AB674 File Offset: 0x006A9874
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeserializeFromPB(IntPtr l)
	{
		int result;
		try
		{
			EffectOperationalActivity effectOperationalActivity = (EffectOperationalActivity)LuaObject.checkSelf(l);
			ProEffectOperationActivity pbOperationalActivity;
			LuaObject.checkType<ProEffectOperationActivity>(l, 2, out pbOperationalActivity);
			ConfigDataOperationalActivityInfo config;
			LuaObject.checkType<ConfigDataOperationalActivityInfo>(l, 3, out config);
			effectOperationalActivity.DeserializeFromPB(pbOperationalActivity, config);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180A7 RID: 98471 RVA: 0x006AB6D8 File Offset: 0x006A98D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPBNtf(IntPtr l)
	{
		int result;
		try
		{
			EffectOperationalActivity effectOperationalActivity = (EffectOperationalActivity)LuaObject.checkSelf(l);
			DSOperationalActivityNtf ntf;
			LuaObject.checkType<DSOperationalActivityNtf>(l, 2, out ntf);
			effectOperationalActivity.ToPBNtf(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180A8 RID: 98472 RVA: 0x006AB730 File Offset: 0x006A9930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToPB(IntPtr l)
	{
		int result;
		try
		{
			EffectOperationalActivity effectOperationalActivity = (EffectOperationalActivity)LuaObject.checkSelf(l);
			ProEffectOperationActivity o = effectOperationalActivity.SerializeToPB();
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

	// Token: 0x060180A9 RID: 98473 RVA: 0x006AB784 File Offset: 0x006A9984
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.EffectOperationalActivity");
		if (Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.DeserializeFromPB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.ToPBNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.SerializeToPB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.<>f__mg$cache3, typeof(EffectOperationalActivity), typeof(OperationalActivityBase));
	}

	// Token: 0x0400E655 RID: 58965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E656 RID: 58966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E657 RID: 58967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E658 RID: 58968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
