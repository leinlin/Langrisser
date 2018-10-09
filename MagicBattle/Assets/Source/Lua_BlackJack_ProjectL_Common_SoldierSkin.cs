using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200127D RID: 4733
[Preserve]
public class Lua_BlackJack_ProjectL_Common_SoldierSkin : LuaObject
{
	// Token: 0x06018AA3 RID: 101027 RVA: 0x006F640C File Offset: 0x006F460C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				SoldierSkin o = new SoldierSkin();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				SoldierSkin other;
				LuaObject.checkType<SoldierSkin>(l, 2, out other);
				SoldierSkin o = new SoldierSkin(other);
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

	// Token: 0x06018AA4 RID: 101028 RVA: 0x006F64A4 File Offset: 0x006F46A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SoldierSkinToPbSoldierSkin_s(IntPtr l)
	{
		int result;
		try
		{
			SoldierSkin skin;
			LuaObject.checkType<SoldierSkin>(l, 1, out skin);
			ProSoldierSkin o = SoldierSkin.SoldierSkinToPbSoldierSkin(skin);
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

	// Token: 0x06018AA5 RID: 101029 RVA: 0x006F64F8 File Offset: 0x006F46F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PbSoldierSkinToSoldierSkin_s(IntPtr l)
	{
		int result;
		try
		{
			ProSoldierSkin pbSkin;
			LuaObject.checkType<ProSoldierSkin>(l, 1, out pbSkin);
			SoldierSkin o = SoldierSkin.PbSoldierSkinToSoldierSkin(pbSkin);
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

	// Token: 0x06018AA6 RID: 101030 RVA: 0x006F654C File Offset: 0x006F474C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkinId(IntPtr l)
	{
		int result;
		try
		{
			SoldierSkin soldierSkin = (SoldierSkin)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierSkin.SkinId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AA7 RID: 101031 RVA: 0x006F65A0 File Offset: 0x006F47A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SkinId(IntPtr l)
	{
		int result;
		try
		{
			SoldierSkin soldierSkin = (SoldierSkin)LuaObject.checkSelf(l);
			int skinId;
			LuaObject.checkType(l, 2, out skinId);
			soldierSkin.SkinId = skinId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AA8 RID: 101032 RVA: 0x006F65F8 File Offset: 0x006F47F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoldierId(IntPtr l)
	{
		int result;
		try
		{
			SoldierSkin soldierSkin = (SoldierSkin)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierSkin.SoldierId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AA9 RID: 101033 RVA: 0x006F664C File Offset: 0x006F484C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SoldierId(IntPtr l)
	{
		int result;
		try
		{
			SoldierSkin soldierSkin = (SoldierSkin)LuaObject.checkSelf(l);
			int soldierId;
			LuaObject.checkType(l, 2, out soldierId);
			soldierSkin.SoldierId = soldierId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AAA RID: 101034 RVA: 0x006F66A4 File Offset: 0x006F48A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.SoldierSkin");
		if (Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SoldierSkin.SoldierSkinToPbSoldierSkin_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SoldierSkin.PbSoldierSkinToSoldierSkin_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache1);
		string name = "SkinId";
		if (Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SoldierSkin.get_SkinId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SoldierSkin.set_SkinId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache3, true);
		string name2 = "SoldierId";
		if (Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SoldierSkin.get_SoldierId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SoldierSkin.set_SoldierId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SoldierSkin.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_SoldierSkin.<>f__mg$cache6, typeof(SoldierSkin));
	}

	// Token: 0x0400EF8B RID: 61323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EF8C RID: 61324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EF8D RID: 61325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EF8E RID: 61326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EF8F RID: 61327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EF90 RID: 61328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EF91 RID: 61329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
