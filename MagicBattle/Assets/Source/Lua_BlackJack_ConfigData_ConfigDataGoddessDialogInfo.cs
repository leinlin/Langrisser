using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200114F RID: 4431
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo : LuaObject
{
	// Token: 0x06016822 RID: 92194 RVA: 0x005F608C File Offset: 0x005F428C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo o = new ConfigDataGoddessDialogInfo();
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

	// Token: 0x06016823 RID: 92195 RVA: 0x005F60D4 File Offset: 0x005F42D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nextDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.m_nextDialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016824 RID: 92196 RVA: 0x005F6128 File Offset: 0x005F4328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			ConfigDataGoddessDialogInfo nextDialogInfo;
			LuaObject.checkType<ConfigDataGoddessDialogInfo>(l, 2, out nextDialogInfo);
			configDataGoddessDialogInfo.m_nextDialogInfo = nextDialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016825 RID: 92197 RVA: 0x005F6180 File Offset: 0x005F4380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016826 RID: 92198 RVA: 0x005F61D4 File Offset: 0x005F43D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataGoddessDialogInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016827 RID: 92199 RVA: 0x005F622C File Offset: 0x005F442C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016828 RID: 92200 RVA: 0x005F6280 File Offset: 0x005F4480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataGoddessDialogInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016829 RID: 92201 RVA: 0x005F62D8 File Offset: 0x005F44D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601682A RID: 92202 RVA: 0x005F632C File Offset: 0x005F452C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataGoddessDialogInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601682B RID: 92203 RVA: 0x005F6384 File Offset: 0x005F4584
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NextDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.NextDialog_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601682C RID: 92204 RVA: 0x005F63D8 File Offset: 0x005F45D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NextDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			int nextDialog_ID;
			LuaObject.checkType(l, 2, out nextDialog_ID);
			configDataGoddessDialogInfo.NextDialog_ID = nextDialog_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601682D RID: 92205 RVA: 0x005F6430 File Offset: 0x005F4630
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PreAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.PreAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601682E RID: 92206 RVA: 0x005F6484 File Offset: 0x005F4684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PreAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string preAnimation;
			LuaObject.checkType(l, 2, out preAnimation);
			configDataGoddessDialogInfo.PreAnimation = preAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601682F RID: 92207 RVA: 0x005F64DC File Offset: 0x005F46DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PreFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.PreFacialAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016830 RID: 92208 RVA: 0x005F6530 File Offset: 0x005F4730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PreFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string preFacialAnimation;
			LuaObject.checkType(l, 2, out preFacialAnimation);
			configDataGoddessDialogInfo.PreFacialAnimation = preFacialAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016831 RID: 92209 RVA: 0x005F6588 File Offset: 0x005F4788
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IdleAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.IdleAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016832 RID: 92210 RVA: 0x005F65DC File Offset: 0x005F47DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IdleAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string idleAnimation;
			LuaObject.checkType(l, 2, out idleAnimation);
			configDataGoddessDialogInfo.IdleAnimation = idleAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016833 RID: 92211 RVA: 0x005F6634 File Offset: 0x005F4834
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IdleFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.IdleFacialAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016834 RID: 92212 RVA: 0x005F6688 File Offset: 0x005F4888
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IdleFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string idleFacialAnimation;
			LuaObject.checkType(l, 2, out idleFacialAnimation);
			configDataGoddessDialogInfo.IdleFacialAnimation = idleFacialAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016835 RID: 92213 RVA: 0x005F66E0 File Offset: 0x005F48E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Voice(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Voice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016836 RID: 92214 RVA: 0x005F6734 File Offset: 0x005F4934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Voice(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string voice;
			LuaObject.checkType(l, 2, out voice);
			configDataGoddessDialogInfo.Voice = voice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016837 RID: 92215 RVA: 0x005F678C File Offset: 0x005F498C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Words(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Words);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016838 RID: 92216 RVA: 0x005F67E0 File Offset: 0x005F49E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Words(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string words;
			LuaObject.checkType(l, 2, out words);
			configDataGoddessDialogInfo.Words = words;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016839 RID: 92217 RVA: 0x005F6838 File Offset: 0x005F4A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WordsKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.WordsKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601683A RID: 92218 RVA: 0x005F688C File Offset: 0x005F4A8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_WordsKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string wordsKey;
			LuaObject.checkType(l, 2, out wordsKey);
			configDataGoddessDialogInfo.WordsKey = wordsKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601683B RID: 92219 RVA: 0x005F68E4 File Offset: 0x005F4AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FeedbackVoice1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.FeedbackVoice1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601683C RID: 92220 RVA: 0x005F6938 File Offset: 0x005F4B38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FeedbackVoice1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string feedbackVoice;
			LuaObject.checkType(l, 2, out feedbackVoice);
			configDataGoddessDialogInfo.FeedbackVoice1 = feedbackVoice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601683D RID: 92221 RVA: 0x005F6990 File Offset: 0x005F4B90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FeedbackVoice2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.FeedbackVoice2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601683E RID: 92222 RVA: 0x005F69E4 File Offset: 0x005F4BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FeedbackVoice2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string feedbackVoice;
			LuaObject.checkType(l, 2, out feedbackVoice);
			configDataGoddessDialogInfo.FeedbackVoice2 = feedbackVoice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601683F RID: 92223 RVA: 0x005F6A3C File Offset: 0x005F4C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FeedbackVoice3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.FeedbackVoice3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016840 RID: 92224 RVA: 0x005F6A90 File Offset: 0x005F4C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FeedbackVoice3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string feedbackVoice;
			LuaObject.checkType(l, 2, out feedbackVoice);
			configDataGoddessDialogInfo.FeedbackVoice3 = feedbackVoice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016841 RID: 92225 RVA: 0x005F6AE8 File Offset: 0x005F4CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FeedbackText1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.FeedbackText1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016842 RID: 92226 RVA: 0x005F6B3C File Offset: 0x005F4D3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FeedbackText1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string feedbackText;
			LuaObject.checkType(l, 2, out feedbackText);
			configDataGoddessDialogInfo.FeedbackText1 = feedbackText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016843 RID: 92227 RVA: 0x005F6B94 File Offset: 0x005F4D94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FeedbackText2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.FeedbackText2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016844 RID: 92228 RVA: 0x005F6BE8 File Offset: 0x005F4DE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FeedbackText2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string feedbackText;
			LuaObject.checkType(l, 2, out feedbackText);
			configDataGoddessDialogInfo.FeedbackText2 = feedbackText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016845 RID: 92229 RVA: 0x005F6C40 File Offset: 0x005F4E40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FeedbackText3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.FeedbackText3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016846 RID: 92230 RVA: 0x005F6C94 File Offset: 0x005F4E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FeedbackText3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string feedbackText;
			LuaObject.checkType(l, 2, out feedbackText);
			configDataGoddessDialogInfo.FeedbackText3 = feedbackText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016847 RID: 92231 RVA: 0x005F6CEC File Offset: 0x005F4EEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Choice1Text(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Choice1Text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016848 RID: 92232 RVA: 0x005F6D40 File Offset: 0x005F4F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Choice1Text(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string choice1Text;
			LuaObject.checkType(l, 2, out choice1Text);
			configDataGoddessDialogInfo.Choice1Text = choice1Text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016849 RID: 92233 RVA: 0x005F6D98 File Offset: 0x005F4F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Choice1TextKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Choice1TextKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601684A RID: 92234 RVA: 0x005F6DEC File Offset: 0x005F4FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Choice1TextKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string choice1TextKey;
			LuaObject.checkType(l, 2, out choice1TextKey);
			configDataGoddessDialogInfo.Choice1TextKey = choice1TextKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601684B RID: 92235 RVA: 0x005F6E44 File Offset: 0x005F5044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Choice1NextDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Choice1NextDialog_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601684C RID: 92236 RVA: 0x005F6E98 File Offset: 0x005F5098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Choice1NextDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			int choice1NextDialog_ID;
			LuaObject.checkType(l, 2, out choice1NextDialog_ID);
			configDataGoddessDialogInfo.Choice1NextDialog_ID = choice1NextDialog_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601684D RID: 92237 RVA: 0x005F6EF0 File Offset: 0x005F50F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Choice1Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Choice1Value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601684E RID: 92238 RVA: 0x005F6F44 File Offset: 0x005F5144
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Choice2Text(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Choice2Text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601684F RID: 92239 RVA: 0x005F6F98 File Offset: 0x005F5198
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Choice2Text(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string choice2Text;
			LuaObject.checkType(l, 2, out choice2Text);
			configDataGoddessDialogInfo.Choice2Text = choice2Text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016850 RID: 92240 RVA: 0x005F6FF0 File Offset: 0x005F51F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Choice2TextKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Choice2TextKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016851 RID: 92241 RVA: 0x005F7044 File Offset: 0x005F5244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Choice2TextKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string choice2TextKey;
			LuaObject.checkType(l, 2, out choice2TextKey);
			configDataGoddessDialogInfo.Choice2TextKey = choice2TextKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016852 RID: 92242 RVA: 0x005F709C File Offset: 0x005F529C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Choice2NextDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Choice2NextDialog_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016853 RID: 92243 RVA: 0x005F70F0 File Offset: 0x005F52F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Choice2NextDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			int choice2NextDialog_ID;
			LuaObject.checkType(l, 2, out choice2NextDialog_ID);
			configDataGoddessDialogInfo.Choice2NextDialog_ID = choice2NextDialog_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016854 RID: 92244 RVA: 0x005F7148 File Offset: 0x005F5348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Choice2Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Choice2Value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016855 RID: 92245 RVA: 0x005F719C File Offset: 0x005F539C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Choice3Text(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Choice3Text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016856 RID: 92246 RVA: 0x005F71F0 File Offset: 0x005F53F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Choice3Text(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string choice3Text;
			LuaObject.checkType(l, 2, out choice3Text);
			configDataGoddessDialogInfo.Choice3Text = choice3Text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016857 RID: 92247 RVA: 0x005F7248 File Offset: 0x005F5448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Choice3TextKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Choice3TextKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016858 RID: 92248 RVA: 0x005F729C File Offset: 0x005F549C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Choice3TextKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			string choice3TextKey;
			LuaObject.checkType(l, 2, out choice3TextKey);
			configDataGoddessDialogInfo.Choice3TextKey = choice3TextKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016859 RID: 92249 RVA: 0x005F72F4 File Offset: 0x005F54F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Choice3NextDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Choice3NextDialog_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601685A RID: 92250 RVA: 0x005F7348 File Offset: 0x005F5548
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Choice3NextDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			int choice3NextDialog_ID;
			LuaObject.checkType(l, 2, out choice3NextDialog_ID);
			configDataGoddessDialogInfo.Choice3NextDialog_ID = choice3NextDialog_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601685B RID: 92251 RVA: 0x005F73A0 File Offset: 0x005F55A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Choice3Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGoddessDialogInfo.Choice3Value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601685C RID: 92252 RVA: 0x005F73F4 File Offset: 0x005F55F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FunctionType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataGoddessDialogInfo.FunctionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601685D RID: 92253 RVA: 0x005F7448 File Offset: 0x005F5648
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FunctionType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = (ConfigDataGoddessDialogInfo)LuaObject.checkSelf(l);
			GoddessDialogFuncType functionType;
			LuaObject.checkEnum<GoddessDialogFuncType>(l, 2, out functionType);
			configDataGoddessDialogInfo.FunctionType = functionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601685E RID: 92254 RVA: 0x005F74A0 File Offset: 0x005F56A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataGoddessDialogInfo");
		string name = "m_nextDialogInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_m_nextDialogInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_m_nextDialogInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache3, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache5, true);
		string name4 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_NameStrKey);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache7, true);
		string name5 = "NextDialog_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_NextDialog_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_NextDialog_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache9, true);
		string name6 = "PreAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_PreAnimation);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_PreAnimation);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheB, true);
		string name7 = "PreFacialAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_PreFacialAnimation);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_PreFacialAnimation);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheD, true);
		string name8 = "IdleAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_IdleAnimation);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_IdleAnimation);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cacheF, true);
		string name9 = "IdleFacialAnimation";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_IdleFacialAnimation);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_IdleFacialAnimation);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache11, true);
		string name10 = "Voice";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Voice);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_Voice);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache13, true);
		string name11 = "Words";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Words);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_Words);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache15, true);
		string name12 = "WordsKey";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_WordsKey);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_WordsKey);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache17, true);
		string name13 = "FeedbackVoice1";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_FeedbackVoice1);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_FeedbackVoice1);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache19, true);
		string name14 = "FeedbackVoice2";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_FeedbackVoice2);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_FeedbackVoice2);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1B, true);
		string name15 = "FeedbackVoice3";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_FeedbackVoice3);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_FeedbackVoice3);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1D, true);
		string name16 = "FeedbackText1";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_FeedbackText1);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_FeedbackText1);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache1F, true);
		string name17 = "FeedbackText2";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_FeedbackText2);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_FeedbackText2);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache21, true);
		string name18 = "FeedbackText3";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_FeedbackText3);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_FeedbackText3);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache23, true);
		string name19 = "Choice1Text";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Choice1Text);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_Choice1Text);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache25, true);
		string name20 = "Choice1TextKey";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Choice1TextKey);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_Choice1TextKey);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache27, true);
		string name21 = "Choice1NextDialog_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Choice1NextDialog_ID);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache28;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_Choice1NextDialog_ID);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache29, true);
		string name22 = "Choice1Value";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Choice1Value);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2A, null, true);
		string name23 = "Choice2Text";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Choice2Text);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2B;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_Choice2Text);
		}
		LuaObject.addMember(l, name23, get22, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2C, true);
		string name24 = "Choice2TextKey";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Choice2TextKey);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2D;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_Choice2TextKey);
		}
		LuaObject.addMember(l, name24, get23, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2E, true);
		string name25 = "Choice2NextDialog_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Choice2NextDialog_ID);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache2F;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_Choice2NextDialog_ID);
		}
		LuaObject.addMember(l, name25, get24, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache30, true);
		string name26 = "Choice2Value";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Choice2Value);
		}
		LuaObject.addMember(l, name26, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache31, null, true);
		string name27 = "Choice3Text";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Choice3Text);
		}
		LuaCSFunction get25 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache32;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_Choice3Text);
		}
		LuaObject.addMember(l, name27, get25, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache33, true);
		string name28 = "Choice3TextKey";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Choice3TextKey);
		}
		LuaCSFunction get26 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache34;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_Choice3TextKey);
		}
		LuaObject.addMember(l, name28, get26, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache35, true);
		string name29 = "Choice3NextDialog_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Choice3NextDialog_ID);
		}
		LuaCSFunction get27 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache36;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_Choice3NextDialog_ID);
		}
		LuaObject.addMember(l, name29, get27, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache37, true);
		string name30 = "Choice3Value";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_Choice3Value);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache38, null, true);
		string name31 = "FunctionType";
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.get_FunctionType);
		}
		LuaCSFunction get28 = Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache39;
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.set_FunctionType);
		}
		LuaObject.addMember(l, name31, get28, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache3A, true);
		if (Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.<>f__mg$cache3B, typeof(ConfigDataGoddessDialogInfo));
	}

	// Token: 0x0400CF66 RID: 53094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CF67 RID: 53095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CF68 RID: 53096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CF69 RID: 53097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CF6A RID: 53098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CF6B RID: 53099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CF6C RID: 53100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CF6D RID: 53101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CF6E RID: 53102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CF6F RID: 53103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CF70 RID: 53104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CF71 RID: 53105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CF72 RID: 53106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CF73 RID: 53107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CF74 RID: 53108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CF75 RID: 53109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CF76 RID: 53110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CF77 RID: 53111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CF78 RID: 53112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CF79 RID: 53113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CF7A RID: 53114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CF7B RID: 53115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CF7C RID: 53116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CF7D RID: 53117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CF7E RID: 53118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CF7F RID: 53119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CF80 RID: 53120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CF81 RID: 53121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CF82 RID: 53122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CF83 RID: 53123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CF84 RID: 53124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CF85 RID: 53125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CF86 RID: 53126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400CF87 RID: 53127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400CF88 RID: 53128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400CF89 RID: 53129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400CF8A RID: 53130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400CF8B RID: 53131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400CF8C RID: 53132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400CF8D RID: 53133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400CF8E RID: 53134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400CF8F RID: 53135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400CF90 RID: 53136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400CF91 RID: 53137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400CF92 RID: 53138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400CF93 RID: 53139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400CF94 RID: 53140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400CF95 RID: 53141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400CF96 RID: 53142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400CF97 RID: 53143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400CF98 RID: 53144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400CF99 RID: 53145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400CF9A RID: 53146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400CF9B RID: 53147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400CF9C RID: 53148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400CF9D RID: 53149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400CF9E RID: 53150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400CF9F RID: 53151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400CFA0 RID: 53152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400CFA1 RID: 53153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;
}
