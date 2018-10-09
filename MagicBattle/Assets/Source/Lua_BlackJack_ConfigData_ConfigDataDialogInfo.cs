using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200114B RID: 4427
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataDialogInfo : LuaObject
{
	// Token: 0x0601674F RID: 91983 RVA: 0x005EFF90 File Offset: 0x005EE190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo o = new ConfigDataDialogInfo();
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

	// Token: 0x06016750 RID: 91984 RVA: 0x005EFFD8 File Offset: 0x005EE1D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_prevDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.m_prevDialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016751 RID: 91985 RVA: 0x005F002C File Offset: 0x005EE22C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_prevDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			ConfigDataDialogInfo prevDialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out prevDialogInfo);
			configDataDialogInfo.m_prevDialogInfo = prevDialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016752 RID: 91986 RVA: 0x005F0084 File Offset: 0x005EE284
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_nextDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.m_nextDialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016753 RID: 91987 RVA: 0x005F00D8 File Offset: 0x005EE2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			ConfigDataDialogInfo nextDialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out nextDialogInfo);
			configDataDialogInfo.m_nextDialogInfo = nextDialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016754 RID: 91988 RVA: 0x005F0130 File Offset: 0x005EE330
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_charImageInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.m_charImageInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016755 RID: 91989 RVA: 0x005F0184 File Offset: 0x005EE384
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_charImageInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 2, out charImageInfo);
			configDataDialogInfo.m_charImageInfo = charImageInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016756 RID: 91990 RVA: 0x005F01DC File Offset: 0x005EE3DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016757 RID: 91991 RVA: 0x005F0230 File Offset: 0x005EE430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataDialogInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016758 RID: 91992 RVA: 0x005F0288 File Offset: 0x005EE488
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016759 RID: 91993 RVA: 0x005F02DC File Offset: 0x005EE4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataDialogInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601675A RID: 91994 RVA: 0x005F0334 File Offset: 0x005EE534
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601675B RID: 91995 RVA: 0x005F0388 File Offset: 0x005EE588
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataDialogInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601675C RID: 91996 RVA: 0x005F03E0 File Offset: 0x005EE5E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NextDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.NextDialog_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601675D RID: 91997 RVA: 0x005F0434 File Offset: 0x005EE634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NextDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			int nextDialog_ID;
			LuaObject.checkType(l, 2, out nextDialog_ID);
			configDataDialogInfo.NextDialog_ID = nextDialog_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601675E RID: 91998 RVA: 0x005F048C File Offset: 0x005EE68C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FrameType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.FrameType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601675F RID: 91999 RVA: 0x005F04E0 File Offset: 0x005EE6E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FrameType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			int frameType;
			LuaObject.checkType(l, 2, out frameType);
			configDataDialogInfo.FrameType = frameType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016760 RID: 92000 RVA: 0x005F0538 File Offset: 0x005EE738
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlaceName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.PlaceName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016761 RID: 92001 RVA: 0x005F058C File Offset: 0x005EE78C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PlaceName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string placeName;
			LuaObject.checkType(l, 2, out placeName);
			configDataDialogInfo.PlaceName = placeName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016762 RID: 92002 RVA: 0x005F05E4 File Offset: 0x005EE7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlaceNameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.PlaceNameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016763 RID: 92003 RVA: 0x005F0638 File Offset: 0x005EE838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlaceNameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string placeNameStrKey;
			LuaObject.checkType(l, 2, out placeNameStrKey);
			configDataDialogInfo.PlaceNameStrKey = placeNameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016764 RID: 92004 RVA: 0x005F0690 File Offset: 0x005EE890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CharName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.CharName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016765 RID: 92005 RVA: 0x005F06E4 File Offset: 0x005EE8E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CharName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string charName;
			LuaObject.checkType(l, 2, out charName);
			configDataDialogInfo.CharName = charName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016766 RID: 92006 RVA: 0x005F073C File Offset: 0x005EE93C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CharNameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.CharNameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016767 RID: 92007 RVA: 0x005F0790 File Offset: 0x005EE990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CharNameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string charNameStrKey;
			LuaObject.checkType(l, 2, out charNameStrKey);
			configDataDialogInfo.CharNameStrKey = charNameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016768 RID: 92008 RVA: 0x005F07E8 File Offset: 0x005EE9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CharImage_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.CharImage_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016769 RID: 92009 RVA: 0x005F083C File Offset: 0x005EEA3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CharImage_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			int charImage_ID;
			LuaObject.checkType(l, 2, out charImage_ID);
			configDataDialogInfo.CharImage_ID = charImage_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601676A RID: 92010 RVA: 0x005F0894 File Offset: 0x005EEA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601676B RID: 92011 RVA: 0x005F08E8 File Offset: 0x005EEAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Position(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			int position;
			LuaObject.checkType(l, 2, out position);
			configDataDialogInfo.Position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601676C RID: 92012 RVA: 0x005F0940 File Offset: 0x005EEB40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnterType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.EnterType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601676D RID: 92013 RVA: 0x005F0994 File Offset: 0x005EEB94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnterType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			int enterType;
			LuaObject.checkType(l, 2, out enterType);
			configDataDialogInfo.EnterType = enterType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601676E RID: 92014 RVA: 0x005F09EC File Offset: 0x005EEBEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BGM(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.BGM);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601676F RID: 92015 RVA: 0x005F0A40 File Offset: 0x005EEC40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BGM(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string bgm;
			LuaObject.checkType(l, 2, out bgm);
			configDataDialogInfo.BGM = bgm;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016770 RID: 92016 RVA: 0x005F0A98 File Offset: 0x005EEC98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LeaveType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.LeaveType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016771 RID: 92017 RVA: 0x005F0AEC File Offset: 0x005EECEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LeaveType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			int leaveType;
			LuaObject.checkType(l, 2, out leaveType);
			configDataDialogInfo.LeaveType = leaveType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016772 RID: 92018 RVA: 0x005F0B44 File Offset: 0x005EED44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TogetherLeave(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.TogetherLeave);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016773 RID: 92019 RVA: 0x005F0B98 File Offset: 0x005EED98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TogetherLeave(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			bool togetherLeave;
			LuaObject.checkType(l, 2, out togetherLeave);
			configDataDialogInfo.TogetherLeave = togetherLeave;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016774 RID: 92020 RVA: 0x005F0BF0 File Offset: 0x005EEDF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LeaveTime(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.LeaveTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016775 RID: 92021 RVA: 0x005F0C44 File Offset: 0x005EEE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LeaveTime(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			int leaveTime;
			LuaObject.checkType(l, 2, out leaveTime);
			configDataDialogInfo.LeaveTime = leaveTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016776 RID: 92022 RVA: 0x005F0C9C File Offset: 0x005EEE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.PreAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016777 RID: 92023 RVA: 0x005F0CF0 File Offset: 0x005EEEF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PreAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string preAnimation;
			LuaObject.checkType(l, 2, out preAnimation);
			configDataDialogInfo.PreAnimation = preAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016778 RID: 92024 RVA: 0x005F0D48 File Offset: 0x005EEF48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PreFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.PreFacialAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016779 RID: 92025 RVA: 0x005F0D9C File Offset: 0x005EEF9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PreFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string preFacialAnimation;
			LuaObject.checkType(l, 2, out preFacialAnimation);
			configDataDialogInfo.PreFacialAnimation = preFacialAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601677A RID: 92026 RVA: 0x005F0DF4 File Offset: 0x005EEFF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IdleAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.IdleAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601677B RID: 92027 RVA: 0x005F0E48 File Offset: 0x005EF048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IdleAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string idleAnimation;
			LuaObject.checkType(l, 2, out idleAnimation);
			configDataDialogInfo.IdleAnimation = idleAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601677C RID: 92028 RVA: 0x005F0EA0 File Offset: 0x005EF0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IdleFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.IdleFacialAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601677D RID: 92029 RVA: 0x005F0EF4 File Offset: 0x005EF0F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IdleFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string idleFacialAnimation;
			LuaObject.checkType(l, 2, out idleFacialAnimation);
			configDataDialogInfo.IdleFacialAnimation = idleFacialAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601677E RID: 92030 RVA: 0x005F0F4C File Offset: 0x005EF14C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Background(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.Background);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601677F RID: 92031 RVA: 0x005F0FA0 File Offset: 0x005EF1A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Background(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string background;
			LuaObject.checkType(l, 2, out background);
			configDataDialogInfo.Background = background;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016780 RID: 92032 RVA: 0x005F0FF8 File Offset: 0x005EF1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BackgroundImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.BackgroundImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016781 RID: 92033 RVA: 0x005F104C File Offset: 0x005EF24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BackgroundImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string backgroundImage;
			LuaObject.checkType(l, 2, out backgroundImage);
			configDataDialogInfo.BackgroundImage = backgroundImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016782 RID: 92034 RVA: 0x005F10A4 File Offset: 0x005EF2A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BackgroundX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.BackgroundX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016783 RID: 92035 RVA: 0x005F10F8 File Offset: 0x005EF2F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BackgroundX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			int backgroundX;
			LuaObject.checkType(l, 2, out backgroundX);
			configDataDialogInfo.BackgroundX = backgroundX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016784 RID: 92036 RVA: 0x005F1150 File Offset: 0x005EF350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Voice(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.Voice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016785 RID: 92037 RVA: 0x005F11A4 File Offset: 0x005EF3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Voice(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string voice;
			LuaObject.checkType(l, 2, out voice);
			configDataDialogInfo.Voice = voice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016786 RID: 92038 RVA: 0x005F11FC File Offset: 0x005EF3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Words(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.Words);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016787 RID: 92039 RVA: 0x005F1250 File Offset: 0x005EF450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Words(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string words;
			LuaObject.checkType(l, 2, out words);
			configDataDialogInfo.Words = words;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016788 RID: 92040 RVA: 0x005F12A8 File Offset: 0x005EF4A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WordsStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.WordsStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016789 RID: 92041 RVA: 0x005F12FC File Offset: 0x005EF4FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_WordsStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			string wordsStrKey;
			LuaObject.checkType(l, 2, out wordsStrKey);
			configDataDialogInfo.WordsStrKey = wordsStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601678A RID: 92042 RVA: 0x005F1354 File Offset: 0x005EF554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BeforeEnterEffectGroup1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.BeforeEnterEffectGroup1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601678B RID: 92043 RVA: 0x005F13A8 File Offset: 0x005EF5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BeforeEnterEffectGroup2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.BeforeEnterEffectGroup2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601678C RID: 92044 RVA: 0x005F13FC File Offset: 0x005EF5FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BeforeEnterEffectGroup3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.BeforeEnterEffectGroup3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601678D RID: 92045 RVA: 0x005F1450 File Offset: 0x005EF650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BeforeEnterInsertEffect(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.BeforeEnterInsertEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601678E RID: 92046 RVA: 0x005F14A4 File Offset: 0x005EF6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BeforeEnterInsertEffect(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			int beforeEnterInsertEffect;
			LuaObject.checkType(l, 2, out beforeEnterInsertEffect);
			configDataDialogInfo.BeforeEnterInsertEffect = beforeEnterInsertEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601678F RID: 92047 RVA: 0x005F14FC File Offset: 0x005EF6FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BeforeTalkEffectGroup1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.BeforeTalkEffectGroup1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016790 RID: 92048 RVA: 0x005F1550 File Offset: 0x005EF750
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BeforeTalkEffectGroup2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.BeforeTalkEffectGroup2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016791 RID: 92049 RVA: 0x005F15A4 File Offset: 0x005EF7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BeforeTalkEffectGroup3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.BeforeTalkEffectGroup3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016792 RID: 92050 RVA: 0x005F15F8 File Offset: 0x005EF7F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BeforeTalkInsertEffect(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.BeforeTalkInsertEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016793 RID: 92051 RVA: 0x005F164C File Offset: 0x005EF84C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BeforeTalkInsertEffect(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			int beforeTalkInsertEffect;
			LuaObject.checkType(l, 2, out beforeTalkInsertEffect);
			configDataDialogInfo.BeforeTalkInsertEffect = beforeTalkInsertEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016794 RID: 92052 RVA: 0x005F16A4 File Offset: 0x005EF8A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AfterTalkEffectGroup1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.AfterTalkEffectGroup1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016795 RID: 92053 RVA: 0x005F16F8 File Offset: 0x005EF8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AfterTalkEffectGroup2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.AfterTalkEffectGroup2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016796 RID: 92054 RVA: 0x005F174C File Offset: 0x005EF94C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AfterTalkEffectGroup3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.AfterTalkEffectGroup3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016797 RID: 92055 RVA: 0x005F17A0 File Offset: 0x005EF9A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AfterTalkInsertEffect(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDialogInfo.AfterTalkInsertEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016798 RID: 92056 RVA: 0x005F17F4 File Offset: 0x005EF9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AfterTalkInsertEffect(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDialogInfo configDataDialogInfo = (ConfigDataDialogInfo)LuaObject.checkSelf(l);
			int afterTalkInsertEffect;
			LuaObject.checkType(l, 2, out afterTalkInsertEffect);
			configDataDialogInfo.AfterTalkInsertEffect = afterTalkInsertEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016799 RID: 92057 RVA: 0x005F184C File Offset: 0x005EFA4C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataDialogInfo");
		string name = "m_prevDialogInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_m_prevDialogInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_m_prevDialogInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1, true);
		string name2 = "m_nextDialogInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_m_nextDialogInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_m_nextDialogInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3, true);
		string name3 = "m_charImageInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_m_charImageInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_m_charImageInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache5, true);
		string name4 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_ID);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_ID);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache7, true);
		string name5 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache9, true);
		string name6 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_NameStrKey);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheB, true);
		string name7 = "NextDialog_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_NextDialog_ID);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_NextDialog_ID);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheD, true);
		string name8 = "FrameType";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_FrameType);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_FrameType);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cacheF, true);
		string name9 = "PlaceName";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_PlaceName);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_PlaceName);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache11, true);
		string name10 = "PlaceNameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_PlaceNameStrKey);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_PlaceNameStrKey);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache13, true);
		string name11 = "CharName";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_CharName);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_CharName);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache15, true);
		string name12 = "CharNameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_CharNameStrKey);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_CharNameStrKey);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache17, true);
		string name13 = "CharImage_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_CharImage_ID);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_CharImage_ID);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache19, true);
		string name14 = "Position";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_Position);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_Position);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1B, true);
		string name15 = "EnterType";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_EnterType);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_EnterType);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1D, true);
		string name16 = "BGM";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_BGM);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_BGM);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache1F, true);
		string name17 = "LeaveType";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_LeaveType);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_LeaveType);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache21, true);
		string name18 = "TogetherLeave";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_TogetherLeave);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_TogetherLeave);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache23, true);
		string name19 = "LeaveTime";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_LeaveTime);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_LeaveTime);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache25, true);
		string name20 = "PreAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_PreAnimation);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_PreAnimation);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache27, true);
		string name21 = "PreFacialAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_PreFacialAnimation);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache28;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_PreFacialAnimation);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache29, true);
		string name22 = "IdleAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_IdleAnimation);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2A;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_IdleAnimation);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2B, true);
		string name23 = "IdleFacialAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_IdleFacialAnimation);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2C;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_IdleFacialAnimation);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2D, true);
		string name24 = "Background";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_Background);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2E;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_Background);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache2F, true);
		string name25 = "BackgroundImage";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_BackgroundImage);
		}
		LuaCSFunction get25 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache30;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_BackgroundImage);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache31, true);
		string name26 = "BackgroundX";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_BackgroundX);
		}
		LuaCSFunction get26 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache32;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_BackgroundX);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache33, true);
		string name27 = "Voice";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_Voice);
		}
		LuaCSFunction get27 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache34;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_Voice);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache35, true);
		string name28 = "Words";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_Words);
		}
		LuaCSFunction get28 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache36;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_Words);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache37, true);
		string name29 = "WordsStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_WordsStrKey);
		}
		LuaCSFunction get29 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache38;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_WordsStrKey);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache39, true);
		string name30 = "BeforeEnterEffectGroup1";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_BeforeEnterEffectGroup1);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3A, null, true);
		string name31 = "BeforeEnterEffectGroup2";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_BeforeEnterEffectGroup2);
		}
		LuaObject.addMember(l, name31, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3B, null, true);
		string name32 = "BeforeEnterEffectGroup3";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_BeforeEnterEffectGroup3);
		}
		LuaObject.addMember(l, name32, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3C, null, true);
		string name33 = "BeforeEnterInsertEffect";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_BeforeEnterInsertEffect);
		}
		LuaCSFunction get30 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3D;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_BeforeEnterInsertEffect);
		}
		LuaObject.addMember(l, name33, get30, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3E, true);
		string name34 = "BeforeTalkEffectGroup1";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_BeforeTalkEffectGroup1);
		}
		LuaObject.addMember(l, name34, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache3F, null, true);
		string name35 = "BeforeTalkEffectGroup2";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_BeforeTalkEffectGroup2);
		}
		LuaObject.addMember(l, name35, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache40, null, true);
		string name36 = "BeforeTalkEffectGroup3";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_BeforeTalkEffectGroup3);
		}
		LuaObject.addMember(l, name36, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache41, null, true);
		string name37 = "BeforeTalkInsertEffect";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_BeforeTalkInsertEffect);
		}
		LuaCSFunction get31 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache42;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_BeforeTalkInsertEffect);
		}
		LuaObject.addMember(l, name37, get31, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache43, true);
		string name38 = "AfterTalkEffectGroup1";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_AfterTalkEffectGroup1);
		}
		LuaObject.addMember(l, name38, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache44, null, true);
		string name39 = "AfterTalkEffectGroup2";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_AfterTalkEffectGroup2);
		}
		LuaObject.addMember(l, name39, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache45, null, true);
		string name40 = "AfterTalkEffectGroup3";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_AfterTalkEffectGroup3);
		}
		LuaObject.addMember(l, name40, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache46, null, true);
		string name41 = "AfterTalkInsertEffect";
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.get_AfterTalkInsertEffect);
		}
		LuaCSFunction get32 = Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache47;
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.set_AfterTalkInsertEffect);
		}
		LuaObject.addMember(l, name41, get32, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache48, true);
		if (Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataDialogInfo.<>f__mg$cache49, typeof(ConfigDataDialogInfo));
	}

	// Token: 0x0400CE9B RID: 52891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CE9C RID: 52892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CE9D RID: 52893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CE9E RID: 52894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CE9F RID: 52895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CEA0 RID: 52896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CEA1 RID: 52897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CEA2 RID: 52898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CEA3 RID: 52899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CEA4 RID: 52900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CEA5 RID: 52901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CEA6 RID: 52902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CEA7 RID: 52903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CEA8 RID: 52904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CEA9 RID: 52905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CEAA RID: 52906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CEAB RID: 52907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CEAC RID: 52908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CEAD RID: 52909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CEAE RID: 52910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CEAF RID: 52911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CEB0 RID: 52912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CEB1 RID: 52913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CEB2 RID: 52914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CEB3 RID: 52915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CEB4 RID: 52916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CEB5 RID: 52917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CEB6 RID: 52918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CEB7 RID: 52919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CEB8 RID: 52920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CEB9 RID: 52921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CEBA RID: 52922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CEBB RID: 52923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400CEBC RID: 52924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400CEBD RID: 52925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400CEBE RID: 52926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400CEBF RID: 52927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400CEC0 RID: 52928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400CEC1 RID: 52929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400CEC2 RID: 52930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400CEC3 RID: 52931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400CEC4 RID: 52932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400CEC5 RID: 52933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400CEC6 RID: 52934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400CEC7 RID: 52935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400CEC8 RID: 52936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400CEC9 RID: 52937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400CECA RID: 52938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400CECB RID: 52939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400CECC RID: 52940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400CECD RID: 52941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400CECE RID: 52942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400CECF RID: 52943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400CED0 RID: 52944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400CED1 RID: 52945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400CED2 RID: 52946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400CED3 RID: 52947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400CED4 RID: 52948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400CED5 RID: 52949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400CED6 RID: 52950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400CED7 RID: 52951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400CED8 RID: 52952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400CED9 RID: 52953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400CEDA RID: 52954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400CEDB RID: 52955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400CEDC RID: 52956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400CEDD RID: 52957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400CEDE RID: 52958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400CEDF RID: 52959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400CEE0 RID: 52960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400CEE1 RID: 52961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400CEE2 RID: 52962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400CEE3 RID: 52963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400CEE4 RID: 52964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;
}
