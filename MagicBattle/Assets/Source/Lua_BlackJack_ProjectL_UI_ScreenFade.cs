using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200156A RID: 5482
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ScreenFade : LuaObject
{
	// Token: 0x06020DC1 RID: 134593 RVA: 0x00B045D4 File Offset: 0x00B027D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade o = new ScreenFade();
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

	// Token: 0x06020DC2 RID: 134594 RVA: 0x00B0461C File Offset: 0x00B0281C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Setup(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			screenFade.Setup(image);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DC3 RID: 134595 RVA: 0x00B04674 File Offset: 0x00B02874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FadeIn(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			Color color;
			LuaObject.checkType(l, 3, out color);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onEnd);
			screenFade.FadeIn(time, color, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DC4 RID: 134596 RVA: 0x00B046E8 File Offset: 0x00B028E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FadeOut(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			Color color;
			LuaObject.checkType(l, 3, out color);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onEnd);
			screenFade.FadeOut(time, color, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DC5 RID: 134597 RVA: 0x00B0475C File Offset: 0x00B0295C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			screenFade.Update(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DC6 RID: 134598 RVA: 0x00B047B4 File Offset: 0x00B029B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFading(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			bool b = screenFade.m_luaExportHelper.IsFading();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DC7 RID: 134599 RVA: 0x00B04810 File Offset: 0x00B02A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_onEnd(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			screenFade.m_luaExportHelper.__callDele_m_onEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DC8 RID: 134600 RVA: 0x00B04864 File Offset: 0x00B02A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_m_onEnd(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			screenFade.m_luaExportHelper.__clearDele_m_onEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DC9 RID: 134601 RVA: 0x00B048B8 File Offset: 0x00B02AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curTime(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, screenFade.m_luaExportHelper.m_curTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DCA RID: 134602 RVA: 0x00B04910 File Offset: 0x00B02B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curTime(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			float curTime;
			LuaObject.checkType(l, 2, out curTime);
			screenFade.m_luaExportHelper.m_curTime = curTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DCB RID: 134603 RVA: 0x00B0496C File Offset: 0x00B02B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_duration(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, screenFade.m_luaExportHelper.m_duration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DCC RID: 134604 RVA: 0x00B049C4 File Offset: 0x00B02BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_duration(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			float duration;
			LuaObject.checkType(l, 2, out duration);
			screenFade.m_luaExportHelper.m_duration = duration;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DCD RID: 134605 RVA: 0x00B04A20 File Offset: 0x00B02C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_delayFrame(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, screenFade.m_luaExportHelper.m_delayFrame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DCE RID: 134606 RVA: 0x00B04A78 File Offset: 0x00B02C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_delayFrame(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			int delayFrame;
			LuaObject.checkType(l, 2, out delayFrame);
			screenFade.m_luaExportHelper.m_delayFrame = delayFrame;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DCF RID: 134607 RVA: 0x00B04AD4 File Offset: 0x00B02CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFadeIn(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, screenFade.m_luaExportHelper.m_isFadeIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DD0 RID: 134608 RVA: 0x00B04B2C File Offset: 0x00B02D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFadeIn(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			bool isFadeIn;
			LuaObject.checkType(l, 2, out isFadeIn);
			screenFade.m_luaExportHelper.m_isFadeIn = isFadeIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DD1 RID: 134609 RVA: 0x00B04B88 File Offset: 0x00B02D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isEnd(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, screenFade.m_luaExportHelper.m_isEnd);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DD2 RID: 134610 RVA: 0x00B04BE0 File Offset: 0x00B02DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isEnd(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			bool isEnd;
			LuaObject.checkType(l, 2, out isEnd);
			screenFade.m_luaExportHelper.m_isEnd = isEnd;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DD3 RID: 134611 RVA: 0x00B04C3C File Offset: 0x00B02E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_color(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, screenFade.m_luaExportHelper.m_color);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DD4 RID: 134612 RVA: 0x00B04C94 File Offset: 0x00B02E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_color(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			Color color;
			LuaObject.checkType(l, 2, out color);
			screenFade.m_luaExportHelper.m_color = color;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DD5 RID: 134613 RVA: 0x00B04CF0 File Offset: 0x00B02EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onEnd(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				screenFade.m_luaExportHelper.m_onEnd = action;
			}
			else if (num == 1)
			{
				ScreenFade.LuaExportHelper luaExportHelper = screenFade.m_luaExportHelper;
				luaExportHelper.m_onEnd = (Action)Delegate.Combine(luaExportHelper.m_onEnd, action);
			}
			else if (num == 2)
			{
				ScreenFade.LuaExportHelper luaExportHelper2 = screenFade.m_luaExportHelper;
				luaExportHelper2.m_onEnd = (Action)Delegate.Remove(luaExportHelper2.m_onEnd, action);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DD6 RID: 134614 RVA: 0x00B04DA4 File Offset: 0x00B02FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, screenFade.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DD7 RID: 134615 RVA: 0x00B04DFC File Offset: 0x00B02FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			ScreenFade screenFade = (ScreenFade)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			screenFade.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DD8 RID: 134616 RVA: 0x00B04E58 File Offset: 0x00B03058
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ScreenFade");
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.Setup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.FadeIn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.FadeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.IsFading);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.__callDele_m_onEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.__clearDele_m_onEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache6);
		string name = "m_curTime";
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.get_m_curTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.set_m_curTime);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache8, true);
		string name2 = "m_duration";
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.get_m_duration);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.set_m_duration);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheA, true);
		string name3 = "m_delayFrame";
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.get_m_delayFrame);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.set_m_delayFrame);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheC, true);
		string name4 = "m_isFadeIn";
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.get_m_isFadeIn);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.set_m_isFadeIn);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheE, true);
		string name5 = "m_isEnd";
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.get_m_isEnd);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.set_m_isEnd);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache10, true);
		string name6 = "m_color";
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.get_m_color);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.set_m_color);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache12, true);
		string name7 = "m_onEnd";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.set_m_onEnd);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache13, true);
		string name8 = "m_image";
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.get_m_image);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.set_m_image);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache15, true);
		if (Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenFade.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ScreenFade.<>f__mg$cache16, typeof(ScreenFade));
	}

	// Token: 0x04016CCF RID: 93391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016CD0 RID: 93392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016CD1 RID: 93393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016CD2 RID: 93394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016CD3 RID: 93395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016CD4 RID: 93396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016CD5 RID: 93397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016CD6 RID: 93398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016CD7 RID: 93399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016CD8 RID: 93400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016CD9 RID: 93401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016CDA RID: 93402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016CDB RID: 93403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016CDC RID: 93404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016CDD RID: 93405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016CDE RID: 93406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016CDF RID: 93407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016CE0 RID: 93408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016CE1 RID: 93409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016CE2 RID: 93410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016CE3 RID: 93411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016CE4 RID: 93412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016CE5 RID: 93413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
