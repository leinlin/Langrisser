using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001166 RID: 4454
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo : LuaObject
{
	// Token: 0x06016BF3 RID: 93171 RVA: 0x00611CF4 File Offset: 0x0060FEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo o = new ConfigDataRiftChapterInfo();
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

	// Token: 0x06016BF4 RID: 93172 RVA: 0x00611D3C File Offset: 0x0060FF3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hardChapterInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.m_hardChapterInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BF5 RID: 93173 RVA: 0x00611D90 File Offset: 0x0060FF90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hardChapterInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo hardChapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out hardChapterInfo);
			configDataRiftChapterInfo.m_hardChapterInfo = hardChapterInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BF6 RID: 93174 RVA: 0x00611DE8 File Offset: 0x0060FFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.m_levelInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BF7 RID: 93175 RVA: 0x00611E3C File Offset: 0x0061003C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_levelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo[] levelInfos;
			LuaObject.checkArray<ConfigDataRiftLevelInfo>(l, 2, out levelInfos);
			configDataRiftChapterInfo.m_levelInfos = levelInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BF8 RID: 93176 RVA: 0x00611E94 File Offset: 0x00610094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BF9 RID: 93177 RVA: 0x00611EE8 File Offset: 0x006100E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataRiftChapterInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BFA RID: 93178 RVA: 0x00611F40 File Offset: 0x00610140
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BFB RID: 93179 RVA: 0x00611F94 File Offset: 0x00610194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataRiftChapterInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BFC RID: 93180 RVA: 0x00611FEC File Offset: 0x006101EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BFD RID: 93181 RVA: 0x00612040 File Offset: 0x00610240
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataRiftChapterInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BFE RID: 93182 RVA: 0x00612098 File Offset: 0x00610298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TitleName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.TitleName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BFF RID: 93183 RVA: 0x006120EC File Offset: 0x006102EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TitleName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			string titleName;
			LuaObject.checkType(l, 2, out titleName);
			configDataRiftChapterInfo.TitleName = titleName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C00 RID: 93184 RVA: 0x00612144 File Offset: 0x00610344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C01 RID: 93185 RVA: 0x00612198 File Offset: 0x00610398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataRiftChapterInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C02 RID: 93186 RVA: 0x006121F0 File Offset: 0x006103F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C03 RID: 93187 RVA: 0x00612244 File Offset: 0x00610444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataRiftChapterInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C04 RID: 93188 RVA: 0x0061229C File Offset: 0x0061049C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Place(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.Place);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C05 RID: 93189 RVA: 0x006122F0 File Offset: 0x006104F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Place(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			string place;
			LuaObject.checkType(l, 2, out place);
			configDataRiftChapterInfo.Place = place;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C06 RID: 93190 RVA: 0x00612348 File Offset: 0x00610548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlaceStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.PlaceStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C07 RID: 93191 RVA: 0x0061239C File Offset: 0x0061059C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlaceStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			string placeStrKey;
			LuaObject.checkType(l, 2, out placeStrKey);
			configDataRiftChapterInfo.PlaceStrKey = placeStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C08 RID: 93192 RVA: 0x006123F4 File Offset: 0x006105F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UnlockConditions(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.UnlockConditions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C09 RID: 93193 RVA: 0x00612448 File Offset: 0x00610648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Hard(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.Hard);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C0A RID: 93194 RVA: 0x0061249C File Offset: 0x0061069C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Hard(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			int hard;
			LuaObject.checkType(l, 2, out hard);
			configDataRiftChapterInfo.Hard = hard;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C0B RID: 93195 RVA: 0x006124F4 File Offset: 0x006106F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HardChapter(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.HardChapter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C0C RID: 93196 RVA: 0x00612548 File Offset: 0x00610748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HardChapter(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			int hardChapter;
			LuaObject.checkType(l, 2, out hardChapter);
			configDataRiftChapterInfo.HardChapter = hardChapter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C0D RID: 93197 RVA: 0x006125A0 File Offset: 0x006107A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RiftLevels_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.RiftLevels_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C0E RID: 93198 RVA: 0x006125F4 File Offset: 0x006107F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward1Star(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.Reward1Star);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C0F RID: 93199 RVA: 0x00612648 File Offset: 0x00610848
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Reward1Star(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			int reward1Star;
			LuaObject.checkType(l, 2, out reward1Star);
			configDataRiftChapterInfo.Reward1Star = reward1Star;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C10 RID: 93200 RVA: 0x006126A0 File Offset: 0x006108A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.Reward1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C11 RID: 93201 RVA: 0x006126F4 File Offset: 0x006108F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward2Star(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.Reward2Star);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C12 RID: 93202 RVA: 0x00612748 File Offset: 0x00610948
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Reward2Star(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			int reward2Star;
			LuaObject.checkType(l, 2, out reward2Star);
			configDataRiftChapterInfo.Reward2Star = reward2Star;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C13 RID: 93203 RVA: 0x006127A0 File Offset: 0x006109A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Reward2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.Reward2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C14 RID: 93204 RVA: 0x006127F4 File Offset: 0x006109F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Reward3Star(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.Reward3Star);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C15 RID: 93205 RVA: 0x00612848 File Offset: 0x00610A48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Reward3Star(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			int reward3Star;
			LuaObject.checkType(l, 2, out reward3Star);
			configDataRiftChapterInfo.Reward3Star = reward3Star;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C16 RID: 93206 RVA: 0x006128A0 File Offset: 0x00610AA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Reward3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.Reward3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C17 RID: 93207 RVA: 0x006128F4 File Offset: 0x00610AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Image(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C18 RID: 93208 RVA: 0x00612948 File Offset: 0x00610B48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Image(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			string image;
			LuaObject.checkType(l, 2, out image);
			configDataRiftChapterInfo.Image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C19 RID: 93209 RVA: 0x006129A0 File Offset: 0x00610BA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChapterBGPrefabName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.ChapterBGPrefabName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C1A RID: 93210 RVA: 0x006129F4 File Offset: 0x00610BF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ChapterBGPrefabName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			string chapterBGPrefabName;
			LuaObject.checkType(l, 2, out chapterBGPrefabName);
			configDataRiftChapterInfo.ChapterBGPrefabName = chapterBGPrefabName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C1B RID: 93211 RVA: 0x00612A4C File Offset: 0x00610C4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsOpened(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftChapterInfo.IsOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C1C RID: 93212 RVA: 0x00612AA0 File Offset: 0x00610CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsOpened(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = (ConfigDataRiftChapterInfo)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			configDataRiftChapterInfo.IsOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C1D RID: 93213 RVA: 0x00612AF8 File Offset: 0x00610CF8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataRiftChapterInfo");
		string name = "m_hardChapterInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_m_hardChapterInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_m_hardChapterInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1, true);
		string name2 = "m_levelInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_m_levelInfos);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_m_levelInfos);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache3, true);
		string name3 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_ID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_ID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache5, true);
		string name4 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_Name);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_Name);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache7, true);
		string name5 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_NameStrKey);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache9, true);
		string name6 = "TitleName";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_TitleName);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_TitleName);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheB, true);
		string name7 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_Desc);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_Desc);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheD, true);
		string name8 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_DescStrKey);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cacheF, true);
		string name9 = "Place";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_Place);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_Place);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache11, true);
		string name10 = "PlaceStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_PlaceStrKey);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_PlaceStrKey);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache13, true);
		string name11 = "UnlockConditions";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_UnlockConditions);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache14, null, true);
		string name12 = "Hard";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_Hard);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache15;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_Hard);
		}
		LuaObject.addMember(l, name12, get11, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache16, true);
		string name13 = "HardChapter";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_HardChapter);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache17;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_HardChapter);
		}
		LuaObject.addMember(l, name13, get12, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache18, true);
		string name14 = "RiftLevels_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_RiftLevels_ID);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache19, null, true);
		string name15 = "Reward1Star";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_Reward1Star);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_Reward1Star);
		}
		LuaObject.addMember(l, name15, get13, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1B, true);
		string name16 = "Reward1";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_Reward1);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1C, null, true);
		string name17 = "Reward2Star";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_Reward2Star);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1D;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_Reward2Star);
		}
		LuaObject.addMember(l, name17, get14, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1E, true);
		string name18 = "Reward2";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_Reward2);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache1F, null, true);
		string name19 = "Reward3Star";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_Reward3Star);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_Reward3Star);
		}
		LuaObject.addMember(l, name19, get15, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache21, true);
		string name20 = "Reward3";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_Reward3);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache22, null, true);
		string name21 = "Image";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_Image);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache23;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_Image);
		}
		LuaObject.addMember(l, name21, get16, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache24, true);
		string name22 = "ChapterBGPrefabName";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_ChapterBGPrefabName);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache25;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_ChapterBGPrefabName);
		}
		LuaObject.addMember(l, name22, get17, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache26, true);
		string name23 = "IsOpened";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.get_IsOpened);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache27;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.set_IsOpened);
		}
		LuaObject.addMember(l, name23, get18, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache28, true);
		if (Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.<>f__mg$cache29, typeof(ConfigDataRiftChapterInfo));
	}

	// Token: 0x0400D309 RID: 54025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D30A RID: 54026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D30B RID: 54027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D30C RID: 54028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D30D RID: 54029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D30E RID: 54030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D30F RID: 54031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D310 RID: 54032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D311 RID: 54033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D312 RID: 54034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D313 RID: 54035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D314 RID: 54036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D315 RID: 54037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D316 RID: 54038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D317 RID: 54039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D318 RID: 54040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D319 RID: 54041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D31A RID: 54042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D31B RID: 54043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D31C RID: 54044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D31D RID: 54045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D31E RID: 54046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D31F RID: 54047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D320 RID: 54048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D321 RID: 54049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D322 RID: 54050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D323 RID: 54051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D324 RID: 54052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D325 RID: 54053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D326 RID: 54054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D327 RID: 54055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D328 RID: 54056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D329 RID: 54057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D32A RID: 54058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D32B RID: 54059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D32C RID: 54060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D32D RID: 54061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D32E RID: 54062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D32F RID: 54063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D330 RID: 54064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D331 RID: 54065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D332 RID: 54066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
