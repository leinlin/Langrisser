using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001139 RID: 4409
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo : LuaObject
{
	// Token: 0x060164CD RID: 91341 RVA: 0x005DDCC8 File Offset: 0x005DBEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo o = new ConfigDataBattleDialogInfo();
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

	// Token: 0x060164CE RID: 91342 RVA: 0x005DDD10 File Offset: 0x005DBF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prevDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.m_prevDialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164CF RID: 91343 RVA: 0x005DDD64 File Offset: 0x005DBF64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_prevDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo prevDialogInfo;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out prevDialogInfo);
			configDataBattleDialogInfo.m_prevDialogInfo = prevDialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164D0 RID: 91344 RVA: 0x005DDDBC File Offset: 0x005DBFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nextDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.m_nextDialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164D1 RID: 91345 RVA: 0x005DDE10 File Offset: 0x005DC010
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_nextDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo nextDialogInfo;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out nextDialogInfo);
			configDataBattleDialogInfo.m_nextDialogInfo = nextDialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164D2 RID: 91346 RVA: 0x005DDE68 File Offset: 0x005DC068
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_charImageInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.m_charImageInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164D3 RID: 91347 RVA: 0x005DDEBC File Offset: 0x005DC0BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charImageInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 2, out charImageInfo);
			configDataBattleDialogInfo.m_charImageInfo = charImageInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164D4 RID: 91348 RVA: 0x005DDF14 File Offset: 0x005DC114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164D5 RID: 91349 RVA: 0x005DDF68 File Offset: 0x005DC168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataBattleDialogInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164D6 RID: 91350 RVA: 0x005DDFC0 File Offset: 0x005DC1C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164D7 RID: 91351 RVA: 0x005DE014 File Offset: 0x005DC214
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataBattleDialogInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164D8 RID: 91352 RVA: 0x005DE06C File Offset: 0x005DC26C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164D9 RID: 91353 RVA: 0x005DE0C0 File Offset: 0x005DC2C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataBattleDialogInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164DA RID: 91354 RVA: 0x005DE118 File Offset: 0x005DC318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.NextDialog_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164DB RID: 91355 RVA: 0x005DE16C File Offset: 0x005DC36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NextDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			int nextDialog_ID;
			LuaObject.checkType(l, 2, out nextDialog_ID);
			configDataBattleDialogInfo.NextDialog_ID = nextDialog_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164DC RID: 91356 RVA: 0x005DE1C4 File Offset: 0x005DC3C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FrameType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.FrameType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164DD RID: 91357 RVA: 0x005DE218 File Offset: 0x005DC418
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FrameType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			int frameType;
			LuaObject.checkType(l, 2, out frameType);
			configDataBattleDialogInfo.FrameType = frameType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164DE RID: 91358 RVA: 0x005DE270 File Offset: 0x005DC470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CharName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.CharName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164DF RID: 91359 RVA: 0x005DE2C4 File Offset: 0x005DC4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CharName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			string charName;
			LuaObject.checkType(l, 2, out charName);
			configDataBattleDialogInfo.CharName = charName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164E0 RID: 91360 RVA: 0x005DE31C File Offset: 0x005DC51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CharNameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.CharNameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164E1 RID: 91361 RVA: 0x005DE370 File Offset: 0x005DC570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CharNameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			string charNameStrKey;
			LuaObject.checkType(l, 2, out charNameStrKey);
			configDataBattleDialogInfo.CharNameStrKey = charNameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164E2 RID: 91362 RVA: 0x005DE3C8 File Offset: 0x005DC5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CharImage_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.CharImage_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164E3 RID: 91363 RVA: 0x005DE41C File Offset: 0x005DC61C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CharImage_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			int charImage_ID;
			LuaObject.checkType(l, 2, out charImage_ID);
			configDataBattleDialogInfo.CharImage_ID = charImage_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164E4 RID: 91364 RVA: 0x005DE474 File Offset: 0x005DC674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164E5 RID: 91365 RVA: 0x005DE4C8 File Offset: 0x005DC6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Position(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			int position;
			LuaObject.checkType(l, 2, out position);
			configDataBattleDialogInfo.Position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164E6 RID: 91366 RVA: 0x005DE520 File Offset: 0x005DC720
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnterType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.EnterType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164E7 RID: 91367 RVA: 0x005DE574 File Offset: 0x005DC774
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnterType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			int enterType;
			LuaObject.checkType(l, 2, out enterType);
			configDataBattleDialogInfo.EnterType = enterType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164E8 RID: 91368 RVA: 0x005DE5CC File Offset: 0x005DC7CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.PreAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164E9 RID: 91369 RVA: 0x005DE620 File Offset: 0x005DC820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PreAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			string preAnimation;
			LuaObject.checkType(l, 2, out preAnimation);
			configDataBattleDialogInfo.PreAnimation = preAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164EA RID: 91370 RVA: 0x005DE678 File Offset: 0x005DC878
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PreFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.PreFacialAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164EB RID: 91371 RVA: 0x005DE6CC File Offset: 0x005DC8CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PreFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			string preFacialAnimation;
			LuaObject.checkType(l, 2, out preFacialAnimation);
			configDataBattleDialogInfo.PreFacialAnimation = preFacialAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164EC RID: 91372 RVA: 0x005DE724 File Offset: 0x005DC924
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IdleAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.IdleAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164ED RID: 91373 RVA: 0x005DE778 File Offset: 0x005DC978
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IdleAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			string idleAnimation;
			LuaObject.checkType(l, 2, out idleAnimation);
			configDataBattleDialogInfo.IdleAnimation = idleAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164EE RID: 91374 RVA: 0x005DE7D0 File Offset: 0x005DC9D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IdleFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.IdleFacialAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164EF RID: 91375 RVA: 0x005DE824 File Offset: 0x005DCA24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IdleFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			string idleFacialAnimation;
			LuaObject.checkType(l, 2, out idleFacialAnimation);
			configDataBattleDialogInfo.IdleFacialAnimation = idleFacialAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164F0 RID: 91376 RVA: 0x005DE87C File Offset: 0x005DCA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Voice(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.Voice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164F1 RID: 91377 RVA: 0x005DE8D0 File Offset: 0x005DCAD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Voice(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			string voice;
			LuaObject.checkType(l, 2, out voice);
			configDataBattleDialogInfo.Voice = voice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164F2 RID: 91378 RVA: 0x005DE928 File Offset: 0x005DCB28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Words(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.Words);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164F3 RID: 91379 RVA: 0x005DE97C File Offset: 0x005DCB7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Words(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			string words;
			LuaObject.checkType(l, 2, out words);
			configDataBattleDialogInfo.Words = words;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164F4 RID: 91380 RVA: 0x005DE9D4 File Offset: 0x005DCBD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WordsStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleDialogInfo.WordsStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164F5 RID: 91381 RVA: 0x005DEA28 File Offset: 0x005DCC28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_WordsStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = (ConfigDataBattleDialogInfo)LuaObject.checkSelf(l);
			string wordsStrKey;
			LuaObject.checkType(l, 2, out wordsStrKey);
			configDataBattleDialogInfo.WordsStrKey = wordsStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164F6 RID: 91382 RVA: 0x005DEA80 File Offset: 0x005DCC80
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataBattleDialogInfo");
		string name = "m_prevDialogInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_m_prevDialogInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_m_prevDialogInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1, true);
		string name2 = "m_nextDialogInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_m_nextDialogInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_m_nextDialogInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache3, true);
		string name3 = "m_charImageInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_m_charImageInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_m_charImageInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache5, true);
		string name4 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_ID);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_ID);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache7, true);
		string name5 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache9, true);
		string name6 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_NameStrKey);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheB, true);
		string name7 = "NextDialog_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_NextDialog_ID);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_NextDialog_ID);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheD, true);
		string name8 = "FrameType";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_FrameType);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_FrameType);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cacheF, true);
		string name9 = "CharName";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_CharName);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_CharName);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache11, true);
		string name10 = "CharNameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_CharNameStrKey);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_CharNameStrKey);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache13, true);
		string name11 = "CharImage_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_CharImage_ID);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_CharImage_ID);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache15, true);
		string name12 = "Position";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_Position);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_Position);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache17, true);
		string name13 = "EnterType";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_EnterType);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_EnterType);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache19, true);
		string name14 = "PreAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_PreAnimation);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_PreAnimation);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1B, true);
		string name15 = "PreFacialAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_PreFacialAnimation);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_PreFacialAnimation);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1D, true);
		string name16 = "IdleAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_IdleAnimation);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_IdleAnimation);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache1F, true);
		string name17 = "IdleFacialAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_IdleFacialAnimation);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_IdleFacialAnimation);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache21, true);
		string name18 = "Voice";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_Voice);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_Voice);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache23, true);
		string name19 = "Words";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_Words);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_Words);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache25, true);
		string name20 = "WordsStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.get_WordsStrKey);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.set_WordsStrKey);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache27, true);
		if (Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.<>f__mg$cache28, typeof(ConfigDataBattleDialogInfo));
	}

	// Token: 0x0400CC3D RID: 52285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CC3E RID: 52286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CC3F RID: 52287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CC40 RID: 52288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CC41 RID: 52289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CC42 RID: 52290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CC43 RID: 52291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CC44 RID: 52292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CC45 RID: 52293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CC46 RID: 52294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CC47 RID: 52295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CC48 RID: 52296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CC49 RID: 52297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CC4A RID: 52298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CC4B RID: 52299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CC4C RID: 52300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CC4D RID: 52301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CC4E RID: 52302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CC4F RID: 52303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CC50 RID: 52304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CC51 RID: 52305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CC52 RID: 52306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CC53 RID: 52307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CC54 RID: 52308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CC55 RID: 52309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CC56 RID: 52310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CC57 RID: 52311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CC58 RID: 52312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CC59 RID: 52313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CC5A RID: 52314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CC5B RID: 52315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CC5C RID: 52316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CC5D RID: 52317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400CC5E RID: 52318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400CC5F RID: 52319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400CC60 RID: 52320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400CC61 RID: 52321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400CC62 RID: 52322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400CC63 RID: 52323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400CC64 RID: 52324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400CC65 RID: 52325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;
}
