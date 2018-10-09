using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001147 RID: 4423
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataCharImageInfo : LuaObject
{
	// Token: 0x060166B9 RID: 91833 RVA: 0x005EBBA8 File Offset: 0x005E9DA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo o = new ConfigDataCharImageInfo();
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

	// Token: 0x060166BA RID: 91834 RVA: 0x005EBBF0 File Offset: 0x005E9DF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_skillCutsceneInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.m_skillCutsceneInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166BB RID: 91835 RVA: 0x005EBC44 File Offset: 0x005E9E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillCutsceneInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			ConfigDataCutsceneInfo skillCutsceneInfo;
			LuaObject.checkType<ConfigDataCutsceneInfo>(l, 2, out skillCutsceneInfo);
			configDataCharImageInfo.m_skillCutsceneInfo = skillCutsceneInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166BC RID: 91836 RVA: 0x005EBC9C File Offset: 0x005E9E9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166BD RID: 91837 RVA: 0x005EBCF0 File Offset: 0x005E9EF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataCharImageInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166BE RID: 91838 RVA: 0x005EBD48 File Offset: 0x005E9F48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166BF RID: 91839 RVA: 0x005EBD9C File Offset: 0x005E9F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataCharImageInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166C0 RID: 91840 RVA: 0x005EBDF4 File Offset: 0x005E9FF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Spine(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.Spine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166C1 RID: 91841 RVA: 0x005EBE48 File Offset: 0x005EA048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Spine(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			string spine;
			LuaObject.checkType(l, 2, out spine);
			configDataCharImageInfo.Spine = spine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166C2 RID: 91842 RVA: 0x005EBEA0 File Offset: 0x005EA0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroPainting(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.HeroPainting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166C3 RID: 91843 RVA: 0x005EBEF4 File Offset: 0x005EA0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroPainting(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			string heroPainting;
			LuaObject.checkType(l, 2, out heroPainting);
			configDataCharImageInfo.HeroPainting = heroPainting;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166C4 RID: 91844 RVA: 0x005EBF4C File Offset: 0x005EA14C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Image(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166C5 RID: 91845 RVA: 0x005EBFA0 File Offset: 0x005EA1A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Image(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			string image;
			LuaObject.checkType(l, 2, out image);
			configDataCharImageInfo.Image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166C6 RID: 91846 RVA: 0x005EBFF8 File Offset: 0x005EA1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Direction(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.Direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166C7 RID: 91847 RVA: 0x005EC04C File Offset: 0x005EA24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Direction(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			configDataCharImageInfo.Direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166C8 RID: 91848 RVA: 0x005EC0A4 File Offset: 0x005EA2A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CVName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.CVName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166C9 RID: 91849 RVA: 0x005EC0F8 File Offset: 0x005EA2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CVName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			string cvname;
			LuaObject.checkType(l, 2, out cvname);
			configDataCharImageInfo.CVName = cvname;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166CA RID: 91850 RVA: 0x005EC150 File Offset: 0x005EA350
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroDetailScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.HeroDetailScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166CB RID: 91851 RVA: 0x005EC1A4 File Offset: 0x005EA3A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroDetailScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			int heroDetailScale;
			LuaObject.checkType(l, 2, out heroDetailScale);
			configDataCharImageInfo.HeroDetailScale = heroDetailScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166CC RID: 91852 RVA: 0x005EC1FC File Offset: 0x005EA3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroDetailYOffset(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.HeroDetailYOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166CD RID: 91853 RVA: 0x005EC250 File Offset: 0x005EA450
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroDetailYOffset(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			int heroDetailYOffset;
			LuaObject.checkType(l, 2, out heroDetailYOffset);
			configDataCharImageInfo.HeroDetailYOffset = heroDetailYOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166CE RID: 91854 RVA: 0x005EC2A8 File Offset: 0x005EA4A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroFetterYOffset(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.HeroFetterYOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166CF RID: 91855 RVA: 0x005EC2FC File Offset: 0x005EA4FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroFetterYOffset(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			int heroFetterYOffset;
			LuaObject.checkType(l, 2, out heroFetterYOffset);
			configDataCharImageInfo.HeroFetterYOffset = heroFetterYOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166D0 RID: 91856 RVA: 0x005EC354 File Offset: 0x005EA554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CombatScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.CombatScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166D1 RID: 91857 RVA: 0x005EC3A8 File Offset: 0x005EA5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CombatScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			int combatScale;
			LuaObject.checkType(l, 2, out combatScale);
			configDataCharImageInfo.CombatScale = combatScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166D2 RID: 91858 RVA: 0x005EC400 File Offset: 0x005EA600
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CombatYOffset(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.CombatYOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166D3 RID: 91859 RVA: 0x005EC454 File Offset: 0x005EA654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CombatYOffset(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			int combatYOffset;
			LuaObject.checkType(l, 2, out combatYOffset);
			configDataCharImageInfo.CombatYOffset = combatYOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166D4 RID: 91860 RVA: 0x005EC4AC File Offset: 0x005EA6AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleDialogScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.BattleDialogScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166D5 RID: 91861 RVA: 0x005EC500 File Offset: 0x005EA700
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleDialogScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			int battleDialogScale;
			LuaObject.checkType(l, 2, out battleDialogScale);
			configDataCharImageInfo.BattleDialogScale = battleDialogScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166D6 RID: 91862 RVA: 0x005EC558 File Offset: 0x005EA758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleDialogYOffset(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.BattleDialogYOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166D7 RID: 91863 RVA: 0x005EC5AC File Offset: 0x005EA7AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleDialogYOffset(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			int battleDialogYOffset;
			LuaObject.checkType(l, 2, out battleDialogYOffset);
			configDataCharImageInfo.BattleDialogYOffset = battleDialogYOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166D8 RID: 91864 RVA: 0x005EC604 File Offset: 0x005EA804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DialogScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.DialogScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166D9 RID: 91865 RVA: 0x005EC658 File Offset: 0x005EA858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DialogScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			int dialogScale;
			LuaObject.checkType(l, 2, out dialogScale);
			configDataCharImageInfo.DialogScale = dialogScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166DA RID: 91866 RVA: 0x005EC6B0 File Offset: 0x005EA8B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DialogYOffset(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.DialogYOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166DB RID: 91867 RVA: 0x005EC704 File Offset: 0x005EA904
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DialogYOffset(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			int dialogYOffset;
			LuaObject.checkType(l, 2, out dialogYOffset);
			configDataCharImageInfo.DialogYOffset = dialogYOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166DC RID: 91868 RVA: 0x005EC75C File Offset: 0x005EA95C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RoundHeadImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.RoundHeadImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166DD RID: 91869 RVA: 0x005EC7B0 File Offset: 0x005EA9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RoundHeadImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			string roundHeadImage;
			LuaObject.checkType(l, 2, out roundHeadImage);
			configDataCharImageInfo.RoundHeadImage = roundHeadImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166DE RID: 91870 RVA: 0x005EC808 File Offset: 0x005EAA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SummonHeadImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.SummonHeadImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166DF RID: 91871 RVA: 0x005EC85C File Offset: 0x005EAA5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SummonHeadImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			string summonHeadImage;
			LuaObject.checkType(l, 2, out summonHeadImage);
			configDataCharImageInfo.SummonHeadImage = summonHeadImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166E0 RID: 91872 RVA: 0x005EC8B4 File Offset: 0x005EAAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CardHeadImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.CardHeadImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166E1 RID: 91873 RVA: 0x005EC908 File Offset: 0x005EAB08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CardHeadImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			string cardHeadImage;
			LuaObject.checkType(l, 2, out cardHeadImage);
			configDataCharImageInfo.CardHeadImage = cardHeadImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166E2 RID: 91874 RVA: 0x005EC960 File Offset: 0x005EAB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SmallHeadImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.SmallHeadImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166E3 RID: 91875 RVA: 0x005EC9B4 File Offset: 0x005EABB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SmallHeadImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			string smallHeadImage;
			LuaObject.checkType(l, 2, out smallHeadImage);
			configDataCharImageInfo.SmallHeadImage = smallHeadImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166E4 RID: 91876 RVA: 0x005ECA0C File Offset: 0x005EAC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkillCutscene_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.SkillCutscene_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166E5 RID: 91877 RVA: 0x005ECA60 File Offset: 0x005EAC60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SkillCutscene_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			int skillCutscene_ID;
			LuaObject.checkType(l, 2, out skillCutscene_ID);
			configDataCharImageInfo.SkillCutscene_ID = skillCutscene_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166E6 RID: 91878 RVA: 0x005ECAB8 File Offset: 0x005EACB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Sound_Die(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.Sound_Die);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166E7 RID: 91879 RVA: 0x005ECB0C File Offset: 0x005EAD0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Sound_Die(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			string sound_Die;
			LuaObject.checkType(l, 2, out sound_Die);
			configDataCharImageInfo.Sound_Die = sound_Die;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166E8 RID: 91880 RVA: 0x005ECB64 File Offset: 0x005EAD64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Performances(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.Performances);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166E9 RID: 91881 RVA: 0x005ECBB8 File Offset: 0x005EADB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BreakPerformances(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.BreakPerformances);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166EA RID: 91882 RVA: 0x005ECC0C File Offset: 0x005EAE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SummonPerformances(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.SummonPerformances);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166EB RID: 91883 RVA: 0x005ECC60 File Offset: 0x005EAE60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobTransferPerformances(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.JobTransferPerformances);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166EC RID: 91884 RVA: 0x005ECCB4 File Offset: 0x005EAEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleActionVoice1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.BattleActionVoice1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166ED RID: 91885 RVA: 0x005ECD08 File Offset: 0x005EAF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleActionVoice1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			string battleActionVoice;
			LuaObject.checkType(l, 2, out battleActionVoice);
			configDataCharImageInfo.BattleActionVoice1 = battleActionVoice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166EE RID: 91886 RVA: 0x005ECD60 File Offset: 0x005EAF60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleActionVoice2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.BattleActionVoice2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166EF RID: 91887 RVA: 0x005ECDB4 File Offset: 0x005EAFB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleActionVoice2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			string battleActionVoice;
			LuaObject.checkType(l, 2, out battleActionVoice);
			configDataCharImageInfo.BattleActionVoice2 = battleActionVoice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166F0 RID: 91888 RVA: 0x005ECE0C File Offset: 0x005EB00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleActionVoice3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.BattleActionVoice3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166F1 RID: 91889 RVA: 0x005ECE60 File Offset: 0x005EB060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleActionVoice3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			string battleActionVoice;
			LuaObject.checkType(l, 2, out battleActionVoice);
			configDataCharImageInfo.BattleActionVoice3 = battleActionVoice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166F2 RID: 91890 RVA: 0x005ECEB8 File Offset: 0x005EB0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NewPerformances(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.NewPerformances);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166F3 RID: 91891 RVA: 0x005ECF0C File Offset: 0x005EB10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NewBreakPerformances(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.NewBreakPerformances);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166F4 RID: 91892 RVA: 0x005ECF60 File Offset: 0x005EB160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NewSummonPerformances(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.NewSummonPerformances);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166F5 RID: 91893 RVA: 0x005ECFB4 File Offset: 0x005EB1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NewJobTransferPerformances(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCharImageInfo configDataCharImageInfo = (ConfigDataCharImageInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCharImageInfo.NewJobTransferPerformances);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166F6 RID: 91894 RVA: 0x005ED008 File Offset: 0x005EB208
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataCharImageInfo");
		string name = "m_skillCutsceneInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_m_skillCutsceneInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_m_skillCutsceneInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache3, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache5, true);
		string name4 = "Spine";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_Spine);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_Spine);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache7, true);
		string name5 = "HeroPainting";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_HeroPainting);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_HeroPainting);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache9, true);
		string name6 = "Image";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_Image);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_Image);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheB, true);
		string name7 = "Direction";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_Direction);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_Direction);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheD, true);
		string name8 = "CVName";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_CVName);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_CVName);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cacheF, true);
		string name9 = "HeroDetailScale";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_HeroDetailScale);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_HeroDetailScale);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache11, true);
		string name10 = "HeroDetailYOffset";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_HeroDetailYOffset);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_HeroDetailYOffset);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache13, true);
		string name11 = "HeroFetterYOffset";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_HeroFetterYOffset);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_HeroFetterYOffset);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache15, true);
		string name12 = "CombatScale";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_CombatScale);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_CombatScale);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache17, true);
		string name13 = "CombatYOffset";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_CombatYOffset);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_CombatYOffset);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache19, true);
		string name14 = "BattleDialogScale";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_BattleDialogScale);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_BattleDialogScale);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1B, true);
		string name15 = "BattleDialogYOffset";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_BattleDialogYOffset);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_BattleDialogYOffset);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1D, true);
		string name16 = "DialogScale";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_DialogScale);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_DialogScale);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache1F, true);
		string name17 = "DialogYOffset";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_DialogYOffset);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_DialogYOffset);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache21, true);
		string name18 = "RoundHeadImage";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_RoundHeadImage);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_RoundHeadImage);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache23, true);
		string name19 = "SummonHeadImage";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_SummonHeadImage);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_SummonHeadImage);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache25, true);
		string name20 = "CardHeadImage";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_CardHeadImage);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_CardHeadImage);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache27, true);
		string name21 = "SmallHeadImage";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_SmallHeadImage);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache28;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_SmallHeadImage);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache29, true);
		string name22 = "SkillCutscene_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_SkillCutscene_ID);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2A;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_SkillCutscene_ID);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2B, true);
		string name23 = "Sound_Die";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_Sound_Die);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2C;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_Sound_Die);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2D, true);
		string name24 = "Performances";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_Performances);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2E, null, true);
		string name25 = "BreakPerformances";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_BreakPerformances);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache2F, null, true);
		string name26 = "SummonPerformances";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_SummonPerformances);
		}
		LuaObject.addMember(l, name26, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache30, null, true);
		string name27 = "JobTransferPerformances";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_JobTransferPerformances);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache31, null, true);
		string name28 = "BattleActionVoice1";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_BattleActionVoice1);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache32;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_BattleActionVoice1);
		}
		LuaObject.addMember(l, name28, get24, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache33, true);
		string name29 = "BattleActionVoice2";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_BattleActionVoice2);
		}
		LuaCSFunction get25 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache34;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_BattleActionVoice2);
		}
		LuaObject.addMember(l, name29, get25, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache35, true);
		string name30 = "BattleActionVoice3";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_BattleActionVoice3);
		}
		LuaCSFunction get26 = Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache36;
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.set_BattleActionVoice3);
		}
		LuaObject.addMember(l, name30, get26, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache37, true);
		string name31 = "NewPerformances";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_NewPerformances);
		}
		LuaObject.addMember(l, name31, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache38, null, true);
		string name32 = "NewBreakPerformances";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_NewBreakPerformances);
		}
		LuaObject.addMember(l, name32, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache39, null, true);
		string name33 = "NewSummonPerformances";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_NewSummonPerformances);
		}
		LuaObject.addMember(l, name33, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache3A, null, true);
		string name34 = "NewJobTransferPerformances";
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.get_NewJobTransferPerformances);
		}
		LuaObject.addMember(l, name34, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache3B, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.<>f__mg$cache3C, typeof(ConfigDataCharImageInfo));
	}

	// Token: 0x0400CE0D RID: 52749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CE0E RID: 52750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CE0F RID: 52751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CE10 RID: 52752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CE11 RID: 52753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CE12 RID: 52754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CE13 RID: 52755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CE14 RID: 52756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CE15 RID: 52757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CE16 RID: 52758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CE17 RID: 52759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CE18 RID: 52760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CE19 RID: 52761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CE1A RID: 52762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CE1B RID: 52763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CE1C RID: 52764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CE1D RID: 52765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CE1E RID: 52766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CE1F RID: 52767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CE20 RID: 52768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CE21 RID: 52769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CE22 RID: 52770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CE23 RID: 52771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CE24 RID: 52772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CE25 RID: 52773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CE26 RID: 52774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CE27 RID: 52775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CE28 RID: 52776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CE29 RID: 52777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CE2A RID: 52778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CE2B RID: 52779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CE2C RID: 52780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CE2D RID: 52781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400CE2E RID: 52782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400CE2F RID: 52783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400CE30 RID: 52784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400CE31 RID: 52785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400CE32 RID: 52786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400CE33 RID: 52787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400CE34 RID: 52788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400CE35 RID: 52789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400CE36 RID: 52790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400CE37 RID: 52791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400CE38 RID: 52792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400CE39 RID: 52793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400CE3A RID: 52794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400CE3B RID: 52795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400CE3C RID: 52796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400CE3D RID: 52797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400CE3E RID: 52798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400CE3F RID: 52799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400CE40 RID: 52800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400CE41 RID: 52801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400CE42 RID: 52802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400CE43 RID: 52803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400CE44 RID: 52804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400CE45 RID: 52805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400CE46 RID: 52806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400CE47 RID: 52807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400CE48 RID: 52808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400CE49 RID: 52809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;
}
