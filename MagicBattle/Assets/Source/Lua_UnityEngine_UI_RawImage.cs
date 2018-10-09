using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001852 RID: 6226
[Preserve]
public class Lua_UnityEngine_UI_RawImage : LuaObject
{
	// Token: 0x060241E2 RID: 147938 RVA: 0x00CAEBC0 File Offset: 0x00CACDC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetNativeSize(IntPtr l)
	{
		int result;
		try
		{
			RawImage rawImage = (RawImage)LuaObject.checkSelf(l);
			rawImage.SetNativeSize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241E3 RID: 147939 RVA: 0x00CAEC0C File Offset: 0x00CACE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mainTexture(IntPtr l)
	{
		int result;
		try
		{
			RawImage rawImage = (RawImage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rawImage.mainTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241E4 RID: 147940 RVA: 0x00CAEC60 File Offset: 0x00CACE60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_texture(IntPtr l)
	{
		int result;
		try
		{
			RawImage rawImage = (RawImage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rawImage.texture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241E5 RID: 147941 RVA: 0x00CAECB4 File Offset: 0x00CACEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_texture(IntPtr l)
	{
		int result;
		try
		{
			RawImage rawImage = (RawImage)LuaObject.checkSelf(l);
			Texture texture;
			LuaObject.checkType<Texture>(l, 2, out texture);
			rawImage.texture = texture;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241E6 RID: 147942 RVA: 0x00CAED0C File Offset: 0x00CACF0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_uvRect(IntPtr l)
	{
		int result;
		try
		{
			RawImage rawImage = (RawImage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rawImage.uvRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241E7 RID: 147943 RVA: 0x00CAED64 File Offset: 0x00CACF64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_uvRect(IntPtr l)
	{
		int result;
		try
		{
			RawImage rawImage = (RawImage)LuaObject.checkSelf(l);
			Rect uvRect;
			LuaObject.checkValueType<Rect>(l, 2, out uvRect);
			rawImage.uvRect = uvRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241E8 RID: 147944 RVA: 0x00CAEDBC File Offset: 0x00CACFBC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.RawImage");
		if (Lua_UnityEngine_UI_RawImage.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_RawImage.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_RawImage.SetNativeSize);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_RawImage.<>f__mg$cache0);
		string name = "mainTexture";
		if (Lua_UnityEngine_UI_RawImage.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_RawImage.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_RawImage.get_mainTexture);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_RawImage.<>f__mg$cache1, null, true);
		string name2 = "texture";
		if (Lua_UnityEngine_UI_RawImage.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_RawImage.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_RawImage.get_texture);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_RawImage.<>f__mg$cache2;
		if (Lua_UnityEngine_UI_RawImage.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_RawImage.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_RawImage.set_texture);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_UI_RawImage.<>f__mg$cache3, true);
		string name3 = "uvRect";
		if (Lua_UnityEngine_UI_RawImage.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_RawImage.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_RawImage.get_uvRect);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_RawImage.<>f__mg$cache4;
		if (Lua_UnityEngine_UI_RawImage.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_RawImage.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_RawImage.set_uvRect);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_UI_RawImage.<>f__mg$cache5, true);
		LuaObject.createTypeMetatable(l, null, typeof(RawImage), typeof(MaskableGraphic));
	}

	// Token: 0x04019D9C RID: 105884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019D9D RID: 105885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019D9E RID: 105886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019D9F RID: 105887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019DA0 RID: 105888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019DA1 RID: 105889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
