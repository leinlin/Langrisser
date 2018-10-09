using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001175 RID: 4469
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo : LuaObject
{
	// Token: 0x06016ECE RID: 93902 RVA: 0x00626ADC File Offset: 0x00624CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo o = new ConfigDataUserGuideDialogInfo();
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

	// Token: 0x06016ECF RID: 93903 RVA: 0x00626B24 File Offset: 0x00624D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prevDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.m_prevDialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ED0 RID: 93904 RVA: 0x00626B78 File Offset: 0x00624D78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_prevDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			ConfigDataUserGuideDialogInfo prevDialogInfo;
			LuaObject.checkType<ConfigDataUserGuideDialogInfo>(l, 2, out prevDialogInfo);
			configDataUserGuideDialogInfo.m_prevDialogInfo = prevDialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ED1 RID: 93905 RVA: 0x00626BD0 File Offset: 0x00624DD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_nextDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.m_nextDialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ED2 RID: 93906 RVA: 0x00626C24 File Offset: 0x00624E24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_nextDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			ConfigDataUserGuideDialogInfo nextDialogInfo;
			LuaObject.checkType<ConfigDataUserGuideDialogInfo>(l, 2, out nextDialogInfo);
			configDataUserGuideDialogInfo.m_nextDialogInfo = nextDialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ED3 RID: 93907 RVA: 0x00626C7C File Offset: 0x00624E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charImageInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.m_charImageInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ED4 RID: 93908 RVA: 0x00626CD0 File Offset: 0x00624ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charImageInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 2, out charImageInfo);
			configDataUserGuideDialogInfo.m_charImageInfo = charImageInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ED5 RID: 93909 RVA: 0x00626D28 File Offset: 0x00624F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ED6 RID: 93910 RVA: 0x00626D7C File Offset: 0x00624F7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataUserGuideDialogInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ED7 RID: 93911 RVA: 0x00626DD4 File Offset: 0x00624FD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ED8 RID: 93912 RVA: 0x00626E28 File Offset: 0x00625028
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataUserGuideDialogInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ED9 RID: 93913 RVA: 0x00626E80 File Offset: 0x00625080
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EDA RID: 93914 RVA: 0x00626ED4 File Offset: 0x006250D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataUserGuideDialogInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EDB RID: 93915 RVA: 0x00626F2C File Offset: 0x0062512C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.NextDialog_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EDC RID: 93916 RVA: 0x00626F80 File Offset: 0x00625180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NextDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			int nextDialog_ID;
			LuaObject.checkType(l, 2, out nextDialog_ID);
			configDataUserGuideDialogInfo.NextDialog_ID = nextDialog_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EDD RID: 93917 RVA: 0x00626FD8 File Offset: 0x006251D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FrameType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.FrameType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EDE RID: 93918 RVA: 0x0062702C File Offset: 0x0062522C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FrameType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			int frameType;
			LuaObject.checkType(l, 2, out frameType);
			configDataUserGuideDialogInfo.FrameType = frameType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EDF RID: 93919 RVA: 0x00627084 File Offset: 0x00625284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CharName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.CharName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EE0 RID: 93920 RVA: 0x006270D8 File Offset: 0x006252D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CharName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			string charName;
			LuaObject.checkType(l, 2, out charName);
			configDataUserGuideDialogInfo.CharName = charName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EE1 RID: 93921 RVA: 0x00627130 File Offset: 0x00625330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CharImage_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.CharImage_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EE2 RID: 93922 RVA: 0x00627184 File Offset: 0x00625384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CharImage_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			int charImage_ID;
			LuaObject.checkType(l, 2, out charImage_ID);
			configDataUserGuideDialogInfo.CharImage_ID = charImage_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EE3 RID: 93923 RVA: 0x006271DC File Offset: 0x006253DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EE4 RID: 93924 RVA: 0x00627230 File Offset: 0x00625430
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Position(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			int position;
			LuaObject.checkType(l, 2, out position);
			configDataUserGuideDialogInfo.Position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EE5 RID: 93925 RVA: 0x00627288 File Offset: 0x00625488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnterType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.EnterType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EE6 RID: 93926 RVA: 0x006272DC File Offset: 0x006254DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnterType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			int enterType;
			LuaObject.checkType(l, 2, out enterType);
			configDataUserGuideDialogInfo.EnterType = enterType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EE7 RID: 93927 RVA: 0x00627334 File Offset: 0x00625534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.PreAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EE8 RID: 93928 RVA: 0x00627388 File Offset: 0x00625588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PreAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			string preAnimation;
			LuaObject.checkType(l, 2, out preAnimation);
			configDataUserGuideDialogInfo.PreAnimation = preAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EE9 RID: 93929 RVA: 0x006273E0 File Offset: 0x006255E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.PreFacialAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EEA RID: 93930 RVA: 0x00627434 File Offset: 0x00625634
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PreFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			string preFacialAnimation;
			LuaObject.checkType(l, 2, out preFacialAnimation);
			configDataUserGuideDialogInfo.PreFacialAnimation = preFacialAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EEB RID: 93931 RVA: 0x0062748C File Offset: 0x0062568C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IdleAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.IdleAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EEC RID: 93932 RVA: 0x006274E0 File Offset: 0x006256E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IdleAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			string idleAnimation;
			LuaObject.checkType(l, 2, out idleAnimation);
			configDataUserGuideDialogInfo.IdleAnimation = idleAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EED RID: 93933 RVA: 0x00627538 File Offset: 0x00625738
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IdleFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.IdleFacialAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EEE RID: 93934 RVA: 0x0062758C File Offset: 0x0062578C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IdleFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			string idleFacialAnimation;
			LuaObject.checkType(l, 2, out idleFacialAnimation);
			configDataUserGuideDialogInfo.IdleFacialAnimation = idleFacialAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EEF RID: 93935 RVA: 0x006275E4 File Offset: 0x006257E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Voice(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.Voice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EF0 RID: 93936 RVA: 0x00627638 File Offset: 0x00625838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Voice(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			string voice;
			LuaObject.checkType(l, 2, out voice);
			configDataUserGuideDialogInfo.Voice = voice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EF1 RID: 93937 RVA: 0x00627690 File Offset: 0x00625890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Words(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.Words);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EF2 RID: 93938 RVA: 0x006276E4 File Offset: 0x006258E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Words(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			string words;
			LuaObject.checkType(l, 2, out words);
			configDataUserGuideDialogInfo.Words = words;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EF3 RID: 93939 RVA: 0x0062773C File Offset: 0x0062593C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WordsKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideDialogInfo.WordsKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EF4 RID: 93940 RVA: 0x00627790 File Offset: 0x00625990
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_WordsKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = (ConfigDataUserGuideDialogInfo)LuaObject.checkSelf(l);
			string wordsKey;
			LuaObject.checkType(l, 2, out wordsKey);
			configDataUserGuideDialogInfo.WordsKey = wordsKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EF5 RID: 93941 RVA: 0x006277E8 File Offset: 0x006259E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataUserGuideDialogInfo");
		string name = "m_prevDialogInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_m_prevDialogInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_m_prevDialogInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1, true);
		string name2 = "m_nextDialogInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_m_nextDialogInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_m_nextDialogInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache3, true);
		string name3 = "m_charImageInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_m_charImageInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_m_charImageInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache5, true);
		string name4 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_ID);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_ID);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache7, true);
		string name5 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache9, true);
		string name6 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_NameStrKey);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheB, true);
		string name7 = "NextDialog_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_NextDialog_ID);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_NextDialog_ID);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheD, true);
		string name8 = "FrameType";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_FrameType);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_FrameType);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cacheF, true);
		string name9 = "CharName";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_CharName);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_CharName);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache11, true);
		string name10 = "CharImage_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_CharImage_ID);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_CharImage_ID);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache13, true);
		string name11 = "Position";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_Position);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_Position);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache15, true);
		string name12 = "EnterType";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_EnterType);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_EnterType);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache17, true);
		string name13 = "PreAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_PreAnimation);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_PreAnimation);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache19, true);
		string name14 = "PreFacialAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_PreFacialAnimation);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_PreFacialAnimation);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1B, true);
		string name15 = "IdleAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_IdleAnimation);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_IdleAnimation);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1D, true);
		string name16 = "IdleFacialAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_IdleFacialAnimation);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_IdleFacialAnimation);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache1F, true);
		string name17 = "Voice";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_Voice);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_Voice);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache21, true);
		string name18 = "Words";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_Words);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_Words);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache23, true);
		string name19 = "WordsKey";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.get_WordsKey);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.set_WordsKey);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache25, true);
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.<>f__mg$cache26, typeof(ConfigDataUserGuideDialogInfo));
	}

	// Token: 0x0400D5C6 RID: 54726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D5C7 RID: 54727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D5C8 RID: 54728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D5C9 RID: 54729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D5CA RID: 54730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D5CB RID: 54731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D5CC RID: 54732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D5CD RID: 54733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D5CE RID: 54734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D5CF RID: 54735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D5D0 RID: 54736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D5D1 RID: 54737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D5D2 RID: 54738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D5D3 RID: 54739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D5D4 RID: 54740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D5D5 RID: 54741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D5D6 RID: 54742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D5D7 RID: 54743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D5D8 RID: 54744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D5D9 RID: 54745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D5DA RID: 54746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D5DB RID: 54747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D5DC RID: 54748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D5DD RID: 54749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D5DE RID: 54750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D5DF RID: 54751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D5E0 RID: 54752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D5E1 RID: 54753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D5E2 RID: 54754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D5E3 RID: 54755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D5E4 RID: 54756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D5E5 RID: 54757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D5E6 RID: 54758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D5E7 RID: 54759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D5E8 RID: 54760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D5E9 RID: 54761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D5EA RID: 54762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D5EB RID: 54763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D5EC RID: 54764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;
}
