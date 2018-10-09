using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.U2D;

// Token: 0x02001807 RID: 6151
[Preserve]
public class Lua_UnityEngine_U2D_SpriteAtlas : LuaObject
{
	// Token: 0x06023F6F RID: 147311 RVA: 0x00C9F3FC File Offset: 0x00C9D5FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSprites(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				SpriteAtlas spriteAtlas = (SpriteAtlas)LuaObject.checkSelf(l);
				Sprite[] sprites;
				LuaObject.checkArray<Sprite>(l, 2, out sprites);
				int sprites2 = spriteAtlas.GetSprites(sprites);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, sprites2);
				result = 2;
			}
			else if (num == 3)
			{
				SpriteAtlas spriteAtlas2 = (SpriteAtlas)LuaObject.checkSelf(l);
				Sprite[] sprites3;
				LuaObject.checkArray<Sprite>(l, 2, out sprites3);
				string name;
				LuaObject.checkType(l, 3, out name);
				int sprites4 = spriteAtlas2.GetSprites(sprites3, name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, sprites4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetSprites to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F70 RID: 147312 RVA: 0x00C9F4D4 File Offset: 0x00C9D6D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSprite(IntPtr l)
	{
		int result;
		try
		{
			SpriteAtlas spriteAtlas = (SpriteAtlas)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			Sprite sprite = spriteAtlas.GetSprite(name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F71 RID: 147313 RVA: 0x00C9F538 File Offset: 0x00C9D738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isVariant(IntPtr l)
	{
		int result;
		try
		{
			SpriteAtlas spriteAtlas = (SpriteAtlas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spriteAtlas.isVariant);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F72 RID: 147314 RVA: 0x00C9F58C File Offset: 0x00C9D78C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_tag(IntPtr l)
	{
		int result;
		try
		{
			SpriteAtlas spriteAtlas = (SpriteAtlas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spriteAtlas.tag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F73 RID: 147315 RVA: 0x00C9F5E0 File Offset: 0x00C9D7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_spriteCount(IntPtr l)
	{
		int result;
		try
		{
			SpriteAtlas spriteAtlas = (SpriteAtlas)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spriteAtlas.spriteCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F74 RID: 147316 RVA: 0x00C9F634 File Offset: 0x00C9D834
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.U2D.SpriteAtlas");
		if (Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_U2D_SpriteAtlas.GetSprites);
		}
		LuaObject.addMember(l, Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache0);
		if (Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_U2D_SpriteAtlas.GetSprite);
		}
		LuaObject.addMember(l, Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache1);
		string name = "isVariant";
		if (Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_U2D_SpriteAtlas.get_isVariant);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache2, null, true);
		string name2 = "tag";
		if (Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_U2D_SpriteAtlas.get_tag);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache3, null, true);
		string name3 = "spriteCount";
		if (Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_U2D_SpriteAtlas.get_spriteCount);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_U2D_SpriteAtlas.<>f__mg$cache4, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(SpriteAtlas), typeof(UnityEngine.Object));
	}

	// Token: 0x04019BBF RID: 105407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019BC0 RID: 105408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019BC1 RID: 105409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019BC2 RID: 105410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019BC3 RID: 105411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
