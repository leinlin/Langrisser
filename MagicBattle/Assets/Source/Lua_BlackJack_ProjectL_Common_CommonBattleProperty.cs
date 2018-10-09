using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011E5 RID: 4581
[Preserve]
public class Lua_BlackJack_ProjectL_Common_CommonBattleProperty : LuaObject
{
	// Token: 0x06017C03 RID: 97283 RVA: 0x00689F2C File Offset: 0x0068812C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CommonBattleProperty o = new CommonBattleProperty();
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

	// Token: 0x06017C04 RID: 97284 RVA: 0x00689F74 File Offset: 0x00688174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CommonBattlePropertyToPBCommonBattleProperty_s(IntPtr l)
	{
		int result;
		try
		{
			CommonBattleProperty property;
			LuaObject.checkType<CommonBattleProperty>(l, 1, out property);
			ProCommonBattleProperty o = CommonBattleProperty.CommonBattlePropertyToPBCommonBattleProperty(property);
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

	// Token: 0x06017C05 RID: 97285 RVA: 0x00689FC8 File Offset: 0x006881C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBCommonBattlePropertyToCommonBattleProperty_s(IntPtr l)
	{
		int result;
		try
		{
			ProCommonBattleProperty pbProperty;
			LuaObject.checkType<ProCommonBattleProperty>(l, 1, out pbProperty);
			CommonBattleProperty o = CommonBattleProperty.PBCommonBattlePropertyToCommonBattleProperty(pbProperty);
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

	// Token: 0x06017C06 RID: 97286 RVA: 0x0068A01C File Offset: 0x0068821C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Id(IntPtr l)
	{
		int result;
		try
		{
			CommonBattleProperty commonBattleProperty = (CommonBattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)commonBattleProperty.Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C07 RID: 97287 RVA: 0x0068A070 File Offset: 0x00688270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Id(IntPtr l)
	{
		int result;
		try
		{
			CommonBattleProperty commonBattleProperty = (CommonBattleProperty)LuaObject.checkSelf(l);
			PropertyModifyType id;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out id);
			commonBattleProperty.Id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C08 RID: 97288 RVA: 0x0068A0C8 File Offset: 0x006882C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Value(IntPtr l)
	{
		int result;
		try
		{
			CommonBattleProperty commonBattleProperty = (CommonBattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonBattleProperty.Value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C09 RID: 97289 RVA: 0x0068A11C File Offset: 0x0068831C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Value(IntPtr l)
	{
		int result;
		try
		{
			CommonBattleProperty commonBattleProperty = (CommonBattleProperty)LuaObject.checkSelf(l);
			int value;
			LuaObject.checkType(l, 2, out value);
			commonBattleProperty.Value = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C0A RID: 97290 RVA: 0x0068A174 File Offset: 0x00688374
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.CommonBattleProperty");
		if (Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonBattleProperty.CommonBattlePropertyToPBCommonBattleProperty_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonBattleProperty.PBCommonBattlePropertyToCommonBattleProperty_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache1);
		string name = "Id";
		if (Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonBattleProperty.get_Id);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonBattleProperty.set_Id);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache3, true);
		string name2 = "Value";
		if (Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonBattleProperty.get_Value);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonBattleProperty.set_Value);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonBattleProperty.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_CommonBattleProperty.<>f__mg$cache6, typeof(CommonBattleProperty));
	}

	// Token: 0x0400E21B RID: 57883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E21C RID: 57884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E21D RID: 57885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E21E RID: 57886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E21F RID: 57887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E220 RID: 57888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E221 RID: 57889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
