using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001112 RID: 4370
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound : LuaObject
{
	// Token: 0x06015B97 RID: 88983 RVA: 0x005972FC File Offset: 0x005954FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_fillSoundName(IntPtr l)
	{
		int result;
		try
		{
			OnImageFillAmmountSound onImageFillAmmountSound = (OnImageFillAmmountSound)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onImageFillAmmountSound.m_fillSoundName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B98 RID: 88984 RVA: 0x00597350 File Offset: 0x00595550
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_fillSoundName(IntPtr l)
	{
		int result;
		try
		{
			OnImageFillAmmountSound onImageFillAmmountSound = (OnImageFillAmmountSound)LuaObject.checkSelf(l);
			string fillSoundName;
			LuaObject.checkType(l, 2, out fillSoundName);
			onImageFillAmmountSound.m_fillSoundName = fillSoundName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B99 RID: 88985 RVA: 0x005973A8 File Offset: 0x005955A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_fillAmmountValue(IntPtr l)
	{
		int result;
		try
		{
			OnImageFillAmmountSound onImageFillAmmountSound = (OnImageFillAmmountSound)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onImageFillAmmountSound.m_fillAmmountValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B9A RID: 88986 RVA: 0x005973FC File Offset: 0x005955FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fillAmmountValue(IntPtr l)
	{
		int result;
		try
		{
			OnImageFillAmmountSound onImageFillAmmountSound = (OnImageFillAmmountSound)LuaObject.checkSelf(l);
			float fillAmmountValue;
			LuaObject.checkType(l, 2, out fillAmmountValue);
			onImageFillAmmountSound.m_fillAmmountValue = fillAmmountValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B9B RID: 88987 RVA: 0x00597454 File Offset: 0x00595654
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.OnImageFillAmmountSound");
		string name = "m_fillSoundName";
		if (Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.get_m_fillSoundName);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.<>f__mg$cache0;
		if (Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.set_m_fillSoundName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.<>f__mg$cache1, true);
		string name2 = "m_fillAmmountValue";
		if (Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.get_m_fillAmmountValue);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.<>f__mg$cache2;
		if (Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.set_m_fillAmmountValue);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.<>f__mg$cache3, true);
		LuaObject.createTypeMetatable(l, null, typeof(OnImageFillAmmountSound), typeof(MonoBehaviour));
	}

	// Token: 0x0400C355 RID: 50005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C356 RID: 50006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C357 RID: 50007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C358 RID: 50008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
