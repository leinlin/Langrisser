using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200181E RID: 6174
[Preserve]
public class Lua_UnityEngine_UI_Dropdown_OptionData : LuaObject
{
	// Token: 0x06024022 RID: 147490 RVA: 0x00CA3A04 File Offset: 0x00CA1C04
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
				Dropdown.OptionData o = new Dropdown.OptionData();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string)))
			{
				string text;
				LuaObject.checkType(l, 2, out text);
				Dropdown.OptionData o = new Dropdown.OptionData(text);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Sprite)))
			{
				Sprite image;
				LuaObject.checkType<Sprite>(l, 2, out image);
				Dropdown.OptionData o = new Dropdown.OptionData(image);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				string text2;
				LuaObject.checkType(l, 2, out text2);
				Sprite image2;
				LuaObject.checkType<Sprite>(l, 3, out image2);
				Dropdown.OptionData o = new Dropdown.OptionData(text2, image2);
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

	// Token: 0x06024023 RID: 147491 RVA: 0x00CA3B24 File Offset: 0x00CA1D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_text(IntPtr l)
	{
		int result;
		try
		{
			Dropdown.OptionData optionData = (Dropdown.OptionData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, optionData.text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024024 RID: 147492 RVA: 0x00CA3B78 File Offset: 0x00CA1D78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_text(IntPtr l)
	{
		int result;
		try
		{
			Dropdown.OptionData optionData = (Dropdown.OptionData)LuaObject.checkSelf(l);
			string text;
			LuaObject.checkType(l, 2, out text);
			optionData.text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024025 RID: 147493 RVA: 0x00CA3BD0 File Offset: 0x00CA1DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_image(IntPtr l)
	{
		int result;
		try
		{
			Dropdown.OptionData optionData = (Dropdown.OptionData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, optionData.image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024026 RID: 147494 RVA: 0x00CA3C24 File Offset: 0x00CA1E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_image(IntPtr l)
	{
		int result;
		try
		{
			Dropdown.OptionData optionData = (Dropdown.OptionData)LuaObject.checkSelf(l);
			Sprite image;
			LuaObject.checkType<Sprite>(l, 2, out image);
			optionData.image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024027 RID: 147495 RVA: 0x00CA3C7C File Offset: 0x00CA1E7C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Dropdown.OptionData");
		string name = "text";
		if (Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown_OptionData.get_text);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache0;
		if (Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown_OptionData.set_text);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache1, true);
		string name2 = "image";
		if (Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown_OptionData.get_image);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache2;
		if (Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown_OptionData.set_image);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache3, true);
		if (Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown_OptionData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_Dropdown_OptionData.<>f__mg$cache4, typeof(Dropdown.OptionData));
	}

	// Token: 0x04019C44 RID: 105540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019C45 RID: 105541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019C46 RID: 105542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019C47 RID: 105543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019C48 RID: 105544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
