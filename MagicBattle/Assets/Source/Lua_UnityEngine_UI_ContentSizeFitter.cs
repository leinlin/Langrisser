using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001818 RID: 6168
[Preserve]
public class Lua_UnityEngine_UI_ContentSizeFitter : LuaObject
{
	// Token: 0x06023FDD RID: 147421 RVA: 0x00CA1CF8 File Offset: 0x00C9FEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayoutHorizontal(IntPtr l)
	{
		int result;
		try
		{
			ContentSizeFitter contentSizeFitter = (ContentSizeFitter)LuaObject.checkSelf(l);
			contentSizeFitter.SetLayoutHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FDE RID: 147422 RVA: 0x00CA1D44 File Offset: 0x00C9FF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayoutVertical(IntPtr l)
	{
		int result;
		try
		{
			ContentSizeFitter contentSizeFitter = (ContentSizeFitter)LuaObject.checkSelf(l);
			contentSizeFitter.SetLayoutVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FDF RID: 147423 RVA: 0x00CA1D90 File Offset: 0x00C9FF90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_horizontalFit(IntPtr l)
	{
		int result;
		try
		{
			ContentSizeFitter contentSizeFitter = (ContentSizeFitter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)contentSizeFitter.horizontalFit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FE0 RID: 147424 RVA: 0x00CA1DE4 File Offset: 0x00C9FFE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_horizontalFit(IntPtr l)
	{
		int result;
		try
		{
			ContentSizeFitter contentSizeFitter = (ContentSizeFitter)LuaObject.checkSelf(l);
			ContentSizeFitter.FitMode horizontalFit;
			LuaObject.checkEnum<ContentSizeFitter.FitMode>(l, 2, out horizontalFit);
			contentSizeFitter.horizontalFit = horizontalFit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FE1 RID: 147425 RVA: 0x00CA1E3C File Offset: 0x00CA003C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_verticalFit(IntPtr l)
	{
		int result;
		try
		{
			ContentSizeFitter contentSizeFitter = (ContentSizeFitter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)contentSizeFitter.verticalFit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FE2 RID: 147426 RVA: 0x00CA1E90 File Offset: 0x00CA0090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_verticalFit(IntPtr l)
	{
		int result;
		try
		{
			ContentSizeFitter contentSizeFitter = (ContentSizeFitter)LuaObject.checkSelf(l);
			ContentSizeFitter.FitMode verticalFit;
			LuaObject.checkEnum<ContentSizeFitter.FitMode>(l, 2, out verticalFit);
			contentSizeFitter.verticalFit = verticalFit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FE3 RID: 147427 RVA: 0x00CA1EE8 File Offset: 0x00CA00E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.ContentSizeFitter");
		if (Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_ContentSizeFitter.SetLayoutHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_ContentSizeFitter.SetLayoutVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache1);
		string name = "horizontalFit";
		if (Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_ContentSizeFitter.get_horizontalFit);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache2;
		if (Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_ContentSizeFitter.set_horizontalFit);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache3, true);
		string name2 = "verticalFit";
		if (Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_ContentSizeFitter.get_verticalFit);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache4;
		if (Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_ContentSizeFitter.set_verticalFit);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_ContentSizeFitter.<>f__mg$cache5, true);
		LuaObject.createTypeMetatable(l, null, typeof(ContentSizeFitter), typeof(UIBehaviour));
	}

	// Token: 0x04019C0B RID: 105483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019C0C RID: 105484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019C0D RID: 105485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019C0E RID: 105486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019C0F RID: 105487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019C10 RID: 105488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
