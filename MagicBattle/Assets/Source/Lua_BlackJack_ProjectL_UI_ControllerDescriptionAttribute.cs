using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001405 RID: 5125
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute : LuaObject
{
	// Token: 0x0601CEDB RID: 118491 RVA: 0x0090FBC8 File Offset: 0x0090DDC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string prefabPath;
			LuaObject.checkType(l, 2, out prefabPath);
			string controllerName;
			LuaObject.checkType(l, 3, out controllerName);
			ControllerDescriptionAttribute o = new ControllerDescriptionAttribute(prefabPath, controllerName);
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

	// Token: 0x0601CEDC RID: 118492 RVA: 0x0090FC28 File Offset: 0x0090DE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_prefabPath(IntPtr l)
	{
		int result;
		try
		{
			ControllerDescriptionAttribute controllerDescriptionAttribute = (ControllerDescriptionAttribute)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, controllerDescriptionAttribute.prefabPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEDD RID: 118493 RVA: 0x0090FC7C File Offset: 0x0090DE7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_prefabPath(IntPtr l)
	{
		int result;
		try
		{
			ControllerDescriptionAttribute controllerDescriptionAttribute = (ControllerDescriptionAttribute)LuaObject.checkSelf(l);
			string prefabPath;
			LuaObject.checkType(l, 2, out prefabPath);
			controllerDescriptionAttribute.prefabPath = prefabPath;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEDE RID: 118494 RVA: 0x0090FCD4 File Offset: 0x0090DED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_controllerName(IntPtr l)
	{
		int result;
		try
		{
			ControllerDescriptionAttribute controllerDescriptionAttribute = (ControllerDescriptionAttribute)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, controllerDescriptionAttribute.controllerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEDF RID: 118495 RVA: 0x0090FD28 File Offset: 0x0090DF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_controllerName(IntPtr l)
	{
		int result;
		try
		{
			ControllerDescriptionAttribute controllerDescriptionAttribute = (ControllerDescriptionAttribute)LuaObject.checkSelf(l);
			string controllerName;
			LuaObject.checkType(l, 2, out controllerName);
			controllerDescriptionAttribute.controllerName = controllerName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEE0 RID: 118496 RVA: 0x0090FD80 File Offset: 0x0090DF80
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ControllerDescriptionAttribute");
		string name = "prefabPath";
		if (Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.get_prefabPath);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.set_prefabPath);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache1, true);
		string name2 = "controllerName";
		if (Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.get_controllerName);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.set_controllerName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.<>f__mg$cache4, typeof(ControllerDescriptionAttribute), typeof(Attribute));
	}

	// Token: 0x040130B3 RID: 78003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040130B4 RID: 78004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040130B5 RID: 78005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040130B6 RID: 78006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040130B7 RID: 78007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
