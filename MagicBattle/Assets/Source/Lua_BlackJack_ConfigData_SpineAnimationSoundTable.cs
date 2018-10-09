using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001188 RID: 4488
[Preserve]
public class Lua_BlackJack_ConfigData_SpineAnimationSoundTable : LuaObject
{
	// Token: 0x06016FC2 RID: 94146 RVA: 0x0062CEA8 File Offset: 0x0062B0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SpineAnimationSoundTable o = new SpineAnimationSoundTable();
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

	// Token: 0x06016FC3 RID: 94147 RVA: 0x0062CEF0 File Offset: 0x0062B0F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize_s(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoader loader;
			LuaObject.checkType<ClientConfigDataLoader>(l, 1, out loader);
			SpineAnimationSoundTable.Initialize(loader);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FC4 RID: 94148 RVA: 0x0062CF3C File Offset: 0x0062B13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSoundName_s(IntPtr l)
	{
		int result;
		try
		{
			string spineDataName;
			LuaObject.checkType(l, 1, out spineDataName);
			string animationName;
			LuaObject.checkType(l, 2, out animationName);
			string eventName;
			LuaObject.checkType(l, 3, out eventName);
			string soundName = SpineAnimationSoundTable.GetSoundName(spineDataName, animationName, eventName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soundName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FC5 RID: 94149 RVA: 0x0062CFAC File Offset: 0x0062B1AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.SpineAnimationSoundTable");
		if (Lua_BlackJack_ConfigData_SpineAnimationSoundTable.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_SpineAnimationSoundTable.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_SpineAnimationSoundTable.Initialize_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_SpineAnimationSoundTable.<>f__mg$cache0);
		if (Lua_BlackJack_ConfigData_SpineAnimationSoundTable.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_SpineAnimationSoundTable.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_SpineAnimationSoundTable.GetSoundName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_SpineAnimationSoundTable.<>f__mg$cache1);
		if (Lua_BlackJack_ConfigData_SpineAnimationSoundTable.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_SpineAnimationSoundTable.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_SpineAnimationSoundTable.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_SpineAnimationSoundTable.<>f__mg$cache2, typeof(SpineAnimationSoundTable));
	}

	// Token: 0x0400D694 RID: 54932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D695 RID: 54933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D696 RID: 54934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
