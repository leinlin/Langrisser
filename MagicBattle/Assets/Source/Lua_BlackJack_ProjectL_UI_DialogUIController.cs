using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001416 RID: 5142
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DialogUIController : LuaObject
{
	// Token: 0x0601D164 RID: 119140 RVA: 0x009244EC File Offset: 0x009226EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDialog(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfo);
			bool needBGChangeTween;
			LuaObject.checkType(l, 3, out needBGChangeTween);
			dialogUIController.ShowDialog(dialogInfo, needBGChangeTween);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D165 RID: 119141 RVA: 0x00924550 File Offset: 0x00922750
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CloseDialog(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.CloseDialog();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D166 RID: 119142 RVA: 0x0092459C File Offset: 0x0092279C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D167 RID: 119143 RVA: 0x009245F0 File Offset: 0x009227F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D168 RID: 119144 RVA: 0x00924644 File Offset: 0x00922844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D169 RID: 119145 RVA: 0x00924698 File Offset: 0x00922898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowDialog(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfo);
			bool needBGChangeTween;
			LuaObject.checkType(l, 3, out needBGChangeTween);
			IEnumerator o = dialogUIController.m_luaExportHelper.Co_ShowDialog(dialogInfo, needBGChangeTween);
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

	// Token: 0x0601D16A RID: 119146 RVA: 0x0092470C File Offset: 0x0092290C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_CharLeavePlay(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfo);
			Action onEndAction;
			LuaObject.checkDelegate<Action>(l, 3, out onEndAction);
			IEnumerator o = dialogUIController.m_luaExportHelper.Co_CharLeavePlay(dialogInfo, onEndAction);
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

	// Token: 0x0601D16B RID: 119147 RVA: 0x00924780 File Offset: 0x00922980
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Co_BGChangeTweenPlay(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfo);
			IEnumerator o = dialogUIController.m_luaExportHelper.Co_BGChangeTweenPlay(dialogInfo);
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

	// Token: 0x0601D16C RID: 119148 RVA: 0x009247E8 File Offset: 0x009229E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_SetBGChangeLeaveShowUIState(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfo);
			string state;
			LuaObject.checkType(l, 3, out state);
			IEnumerator o = dialogUIController.m_luaExportHelper.Co_SetBGChangeLeaveShowUIState(dialogInfo, state);
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

	// Token: 0x0601D16D RID: 119149 RVA: 0x0092485C File Offset: 0x00922A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_SetBGChangeEnterShowUIState(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string state;
			LuaObject.checkType(l, 2, out state);
			IEnumerator o = dialogUIController.m_luaExportHelper.Co_SetBGChangeEnterShowUIState(state);
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

	// Token: 0x0601D16E RID: 119150 RVA: 0x009248C4 File Offset: 0x00922AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_CreateCharEnter(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfo);
			DialogCharUIController c;
			LuaObject.checkType<DialogCharUIController>(l, 3, out c);
			IEnumerator o = dialogUIController.m_luaExportHelper.Co_CreateCharEnter(dialogInfo, c);
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

	// Token: 0x0601D16F RID: 119151 RVA: 0x00924938 File Offset: 0x00922B38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayBGMInDialog(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfo);
			dialogUIController.m_luaExportHelper.PlayBGMInDialog(dialogInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D170 RID: 119152 RVA: 0x00924994 File Offset: 0x00922B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_CloseDialog(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			IEnumerator o = dialogUIController.m_luaExportHelper.Co_CloseDialog();
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

	// Token: 0x0601D171 RID: 119153 RVA: 0x009249F0 File Offset: 0x00922BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDialogBox(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.ShowDialogBox();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D172 RID: 119154 RVA: 0x00924A44 File Offset: 0x00922C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateBackgroundGraphic(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			dialogUIController.m_luaExportHelper.CreateBackgroundGraphic(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D173 RID: 119155 RVA: 0x00924AA0 File Offset: 0x00922CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyBackgroundGraphic(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.DestroyBackgroundGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D174 RID: 119156 RVA: 0x00924AF4 File Offset: 0x00922CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_CreateBeforeEnterEffectGroup(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			IEnumerator o = dialogUIController.m_luaExportHelper.Co_CreateBeforeEnterEffectGroup();
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

	// Token: 0x0601D175 RID: 119157 RVA: 0x00924B50 File Offset: 0x00922D50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Co_CreateBeforeTalkEffectGroup(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			IEnumerator o = dialogUIController.m_luaExportHelper.Co_CreateBeforeTalkEffectGroup();
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

	// Token: 0x0601D176 RID: 119158 RVA: 0x00924BAC File Offset: 0x00922DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_AfterTalkEffectAndLeave(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfo);
			IEnumerator o = dialogUIController.m_luaExportHelper.Co_AfterTalkEffectAndLeave(dialogInfo);
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

	// Token: 0x0601D177 RID: 119159 RVA: 0x00924C14 File Offset: 0x00922E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_CreateAfterTalkEffectGroup(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfo);
			IEnumerator o = dialogUIController.m_luaExportHelper.Co_CreateAfterTalkEffectGroup(dialogInfo);
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

	// Token: 0x0601D178 RID: 119160 RVA: 0x00924C7C File Offset: 0x00922E7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateEffectGroupLeaveTogether(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfo);
			List<int> effectGroup;
			LuaObject.checkType<List<int>>(l, 3, out effectGroup);
			GameObject parentGameObject;
			LuaObject.checkType<GameObject>(l, 4, out parentGameObject);
			Action onEndAction;
			LuaObject.checkDelegate<Action>(l, 5, out onEndAction);
			dialogUIController.m_luaExportHelper.CreateEffectGroupLeaveTogether(dialogInfo, effectGroup, parentGameObject, onEndAction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D179 RID: 119161 RVA: 0x00924D00 File Offset: 0x00922F00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateEffectGroup(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			List<int> effectGroup;
			LuaObject.checkType<List<int>>(l, 2, out effectGroup);
			GameObject parentGameObject;
			LuaObject.checkType<GameObject>(l, 3, out parentGameObject);
			Action onEndAction;
			LuaObject.checkDelegate<Action>(l, 4, out onEndAction);
			dialogUIController.m_luaExportHelper.CreateEffectGroup(effectGroup, parentGameObject, onEndAction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D17A RID: 119162 RVA: 0x00924D78 File Offset: 0x00922F78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayEffectGroup(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			List<int> effectGroup;
			LuaObject.checkType<List<int>>(l, 2, out effectGroup);
			GameObject parentGameObject;
			LuaObject.checkType<GameObject>(l, 3, out parentGameObject);
			Action onEndAction;
			LuaObject.checkDelegate<Action>(l, 4, out onEndAction);
			dialogUIController.m_luaExportHelper.PlayEffectGroup(effectGroup, parentGameObject, onEndAction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D17B RID: 119163 RVA: 0x00924DF0 File Offset: 0x00922FF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateEffect(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			ConfigDataPrefabStateInfo prefabStateConfig;
			LuaObject.checkType<ConfigDataPrefabStateInfo>(l, 2, out prefabStateConfig);
			GameObject parentGameObject;
			LuaObject.checkType<GameObject>(l, 3, out parentGameObject);
			Action onEndAction;
			LuaObject.checkDelegate<Action>(l, 4, out onEndAction);
			dialogUIController.m_luaExportHelper.CreateEffect(prefabStateConfig, parentGameObject, onEndAction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D17C RID: 119164 RVA: 0x00924E68 File Offset: 0x00923068
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateEffectInGroup(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string s;
			LuaObject.checkType(l, 2, out s);
			ConfigDataPrefabStateInfo prefabStateConfig;
			LuaObject.checkType<ConfigDataPrefabStateInfo>(l, 3, out prefabStateConfig);
			GameObject parentGameObject;
			LuaObject.checkType<GameObject>(l, 4, out parentGameObject);
			Action onEndAction;
			LuaObject.checkDelegate<Action>(l, 5, out onEndAction);
			dialogUIController.m_luaExportHelper.CreateEffectInGroup(ref s, prefabStateConfig, parentGameObject, onEndAction);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D17D RID: 119165 RVA: 0x00924EF4 File Offset: 0x009230F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateInsertEffect(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			int prefabStateID;
			LuaObject.checkType(l, 2, out prefabStateID);
			Action onEndAction;
			LuaObject.checkDelegate<Action>(l, 3, out onEndAction);
			dialogUIController.m_luaExportHelper.CreateInsertEffect(prefabStateID, onEndAction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D17E RID: 119166 RVA: 0x00924F60 File Offset: 0x00923160
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBackgroundImage(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string backgroundImage;
			LuaObject.checkType(l, 2, out backgroundImage);
			dialogUIController.m_luaExportHelper.SetBackgroundImage(backgroundImage);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D17F RID: 119167 RVA: 0x00924FBC File Offset: 0x009231BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearBackgroundImage(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.ClearBackgroundImage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D180 RID: 119168 RVA: 0x00925010 File Offset: 0x00923210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayVoice(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			IAudioPlayback o = dialogUIController.m_luaExportHelper.PlayVoice(name);
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

	// Token: 0x0601D181 RID: 119169 RVA: 0x00925078 File Offset: 0x00923278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopVoice(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.StopVoice();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D182 RID: 119170 RVA: 0x009250CC File Offset: 0x009232CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_NextDialog(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			IEnumerator o = dialogUIController.m_luaExportHelper.Co_NextDialog();
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

	// Token: 0x0601D183 RID: 119171 RVA: 0x00925128 File Offset: 0x00923328
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSkipButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.OnSkipButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D184 RID: 119172 RVA: 0x0092517C File Offset: 0x0092337C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D185 RID: 119173 RVA: 0x009251D0 File Offset: 0x009233D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			dialogUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D186 RID: 119174 RVA: 0x0092523C File Offset: 0x0092343C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D187 RID: 119175 RVA: 0x00925290 File Offset: 0x00923490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D188 RID: 119176 RVA: 0x009252E4 File Offset: 0x009234E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			Type fieldType;
			LuaObject.checkType(l, 2, out fieldType);
			string path;
			LuaObject.checkType(l, 3, out path);
			AutoBindAttribute.InitState initState;
			LuaObject.checkEnum<AutoBindAttribute.InitState>(l, 4, out initState);
			string fieldName;
			LuaObject.checkType(l, 5, out fieldName);
			string ctrlName;
			LuaObject.checkType(l, 6, out ctrlName);
			bool optional;
			LuaObject.checkType(l, 7, out optional);
			UnityEngine.Object o = dialogUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D189 RID: 119177 RVA: 0x0092538C File Offset: 0x0092358C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D18A RID: 119178 RVA: 0x009253E0 File Offset: 0x009235E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			dialogUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D18B RID: 119179 RVA: 0x0092544C File Offset: 0x0092364C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				dialogUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				DialogUIController dialogUIController2 = (DialogUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				dialogUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetButtonClickListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D18C RID: 119180 RVA: 0x0092555C File Offset: 0x0092375C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dialogUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D18D RID: 119181 RVA: 0x009255C8 File Offset: 0x009237C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D18E RID: 119182 RVA: 0x00925634 File Offset: 0x00923834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D18F RID: 119183 RVA: 0x009256A0 File Offset: 0x009238A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D190 RID: 119184 RVA: 0x0092570C File Offset: 0x0092390C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				dialogUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				DialogUIController dialogUIController2 = (DialogUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				dialogUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetToggleValueChangedListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D191 RID: 119185 RVA: 0x0092581C File Offset: 0x00923A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string s = dialogUIController.m_luaExportHelper.__callBase_ToString();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D192 RID: 119186 RVA: 0x00925878 File Offset: 0x00923A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSkip(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.__callDele_EventOnSkip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D193 RID: 119187 RVA: 0x009258CC File Offset: 0x00923ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSkip(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.__clearDele_EventOnSkip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D194 RID: 119188 RVA: 0x00925920 File Offset: 0x00923B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			dialogUIController.m_luaExportHelper.__callDele_EventOnNext(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D195 RID: 119189 RVA: 0x0092597C File Offset: 0x00923B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			dialogUIController.m_luaExportHelper.__clearDele_EventOnNext(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D196 RID: 119190 RVA: 0x009259D8 File Offset: 0x00923BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D197 RID: 119191 RVA: 0x00925A2C File Offset: 0x00923C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			dialogUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D198 RID: 119192 RVA: 0x00925A80 File Offset: 0x00923C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSkip(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					dialogUIController.EventOnSkip += value;
				}
				else if (num == 2)
				{
					dialogUIController.EventOnSkip -= value;
				}
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

	// Token: 0x0601D199 RID: 119193 RVA: 0x00925B00 File Offset: 0x00923D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					dialogUIController.EventOnNext += value;
				}
				else if (num == 2)
				{
					dialogUIController.EventOnNext -= value;
				}
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

	// Token: 0x0601D19A RID: 119194 RVA: 0x00925B80 File Offset: 0x00923D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					dialogUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					dialogUIController.EventOnClose -= value;
				}
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

	// Token: 0x0601D19B RID: 119195 RVA: 0x00925C00 File Offset: 0x00923E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skipButton(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_skipButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D19C RID: 119196 RVA: 0x00925C58 File Offset: 0x00923E58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_skipButton(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			Button skipButton;
			LuaObject.checkType<Button>(l, 2, out skipButton);
			dialogUIController.m_luaExportHelper.m_skipButton = skipButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D19D RID: 119197 RVA: 0x00925CB4 File Offset: 0x00923EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundUIStateController(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_backgroundUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D19E RID: 119198 RVA: 0x00925D0C File Offset: 0x00923F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundUIStateController(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			CommonUIStateController backgroundUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out backgroundUIStateController);
			dialogUIController.m_luaExportHelper.m_backgroundUIStateController = backgroundUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D19F RID: 119199 RVA: 0x00925D68 File Offset: 0x00923F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundGraphicGameObject(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_backgroundGraphicGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1A0 RID: 119200 RVA: 0x00925DC0 File Offset: 0x00923FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundGraphicGameObject(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			GameObject backgroundGraphicGameObject;
			LuaObject.checkType<GameObject>(l, 2, out backgroundGraphicGameObject);
			dialogUIController.m_luaExportHelper.m_backgroundGraphicGameObject = backgroundGraphicGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1A1 RID: 119201 RVA: 0x00925E1C File Offset: 0x0092401C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundImage(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_backgroundImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1A2 RID: 119202 RVA: 0x00925E74 File Offset: 0x00924074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundImage(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			Image backgroundImage;
			LuaObject.checkType<Image>(l, 2, out backgroundImage);
			dialogUIController.m_luaExportHelper.m_backgroundImage = backgroundImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1A3 RID: 119203 RVA: 0x00925ED0 File Offset: 0x009240D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1A4 RID: 119204 RVA: 0x00925F28 File Offset: 0x00924128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			dialogUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1A5 RID: 119205 RVA: 0x00925F84 File Offset: 0x00924184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_placeGameObject(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_placeGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1A6 RID: 119206 RVA: 0x00925FDC File Offset: 0x009241DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_placeGameObject(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			GameObject placeGameObject;
			LuaObject.checkType<GameObject>(l, 2, out placeGameObject);
			dialogUIController.m_luaExportHelper.m_placeGameObject = placeGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1A7 RID: 119207 RVA: 0x00926038 File Offset: 0x00924238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_placeText(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_placeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1A8 RID: 119208 RVA: 0x00926090 File Offset: 0x00924290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_placeText(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			Text placeText;
			LuaObject.checkType<Text>(l, 2, out placeText);
			dialogUIController.m_luaExportHelper.m_placeText = placeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1A9 RID: 119209 RVA: 0x009260EC File Offset: 0x009242EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordsGameObject(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_wordsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1AA RID: 119210 RVA: 0x00926144 File Offset: 0x00924344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordsGameObject(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			GameObject wordsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out wordsGameObject);
			dialogUIController.m_luaExportHelper.m_wordsGameObject = wordsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1AB RID: 119211 RVA: 0x009261A0 File Offset: 0x009243A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char0GameObject(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_char0GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1AC RID: 119212 RVA: 0x009261F8 File Offset: 0x009243F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_char0GameObject(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			GameObject char0GameObject;
			LuaObject.checkType<GameObject>(l, 2, out char0GameObject);
			dialogUIController.m_luaExportHelper.m_char0GameObject = char0GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1AD RID: 119213 RVA: 0x00926254 File Offset: 0x00924454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char1GameObject(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_char1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1AE RID: 119214 RVA: 0x009262AC File Offset: 0x009244AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_char1GameObject(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			GameObject char1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out char1GameObject);
			dialogUIController.m_luaExportHelper.m_char1GameObject = char1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1AF RID: 119215 RVA: 0x00926308 File Offset: 0x00924508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char2GameObject(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_char2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1B0 RID: 119216 RVA: 0x00926360 File Offset: 0x00924560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_char2GameObject(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			GameObject char2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out char2GameObject);
			dialogUIController.m_luaExportHelper.m_char2GameObject = char2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1B1 RID: 119217 RVA: 0x009263BC File Offset: 0x009245BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_effectGroup1(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_effectGroup1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1B2 RID: 119218 RVA: 0x00926414 File Offset: 0x00924614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_effectGroup1(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			GameObject effectGroup;
			LuaObject.checkType<GameObject>(l, 2, out effectGroup);
			dialogUIController.m_luaExportHelper.m_effectGroup1 = effectGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1B3 RID: 119219 RVA: 0x00926470 File Offset: 0x00924670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_effectGroup2(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_effectGroup2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1B4 RID: 119220 RVA: 0x009264C8 File Offset: 0x009246C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_effectGroup2(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			GameObject effectGroup;
			LuaObject.checkType<GameObject>(l, 2, out effectGroup);
			dialogUIController.m_luaExportHelper.m_effectGroup2 = effectGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1B5 RID: 119221 RVA: 0x00926524 File Offset: 0x00924724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_effectGroup3(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_effectGroup3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1B6 RID: 119222 RVA: 0x0092657C File Offset: 0x0092477C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_effectGroup3(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			GameObject effectGroup;
			LuaObject.checkType<GameObject>(l, 2, out effectGroup);
			dialogUIController.m_luaExportHelper.m_effectGroup3 = effectGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1B7 RID: 119223 RVA: 0x009265D8 File Offset: 0x009247D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_insertEffect(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_insertEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1B8 RID: 119224 RVA: 0x00926630 File Offset: 0x00924830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_insertEffect(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			GameObject insertEffect;
			LuaObject.checkType<GameObject>(l, 2, out insertEffect);
			dialogUIController.m_luaExportHelper.m_insertEffect = insertEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1B9 RID: 119225 RVA: 0x0092668C File Offset: 0x0092488C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeBGTweenUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_changeBGTweenUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1BA RID: 119226 RVA: 0x009266E4 File Offset: 0x009248E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeBGTweenUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			CommonUIStateController changeBGTweenUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out changeBGTweenUIStateCtrl);
			dialogUIController.m_luaExportHelper.m_changeBGTweenUIStateCtrl = changeBGTweenUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1BB RID: 119227 RVA: 0x00926740 File Offset: 0x00924940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogCharUIControllers(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_dialogCharUIControllers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1BC RID: 119228 RVA: 0x00926798 File Offset: 0x00924998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogCharUIControllers(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			DialogCharUIController[] dialogCharUIControllers;
			LuaObject.checkArray<DialogCharUIController>(l, 2, out dialogCharUIControllers);
			dialogUIController.m_luaExportHelper.m_dialogCharUIControllers = dialogCharUIControllers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1BD RID: 119229 RVA: 0x009267F4 File Offset: 0x009249F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogBoxUIController(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_dialogBoxUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1BE RID: 119230 RVA: 0x0092684C File Offset: 0x00924A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogBoxUIController(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			DialogBoxUIController dialogBoxUIController;
			LuaObject.checkType<DialogBoxUIController>(l, 2, out dialogBoxUIController);
			dialogUIController.m_luaExportHelper.m_dialogBoxUIController = dialogBoxUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1BF RID: 119231 RVA: 0x009268A8 File Offset: 0x00924AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundGraphic(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_backgroundGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1C0 RID: 119232 RVA: 0x00926900 File Offset: 0x00924B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundGraphic(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			UISpineGraphic backgroundGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out backgroundGraphic);
			dialogUIController.m_luaExportHelper.m_backgroundGraphic = backgroundGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1C1 RID: 119233 RVA: 0x0092695C File Offset: 0x00924B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_group1PrefabName(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_group1PrefabName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1C2 RID: 119234 RVA: 0x009269B4 File Offset: 0x00924BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_group1PrefabName(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string group1PrefabName;
			LuaObject.checkType(l, 2, out group1PrefabName);
			dialogUIController.m_luaExportHelper.m_group1PrefabName = group1PrefabName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1C3 RID: 119235 RVA: 0x00926A10 File Offset: 0x00924C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_group2PrefabName(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_group2PrefabName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1C4 RID: 119236 RVA: 0x00926A68 File Offset: 0x00924C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_group2PrefabName(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string group2PrefabName;
			LuaObject.checkType(l, 2, out group2PrefabName);
			dialogUIController.m_luaExportHelper.m_group2PrefabName = group2PrefabName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1C5 RID: 119237 RVA: 0x00926AC4 File Offset: 0x00924CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_group3PrefabName(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_group3PrefabName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1C6 RID: 119238 RVA: 0x00926B1C File Offset: 0x00924D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_group3PrefabName(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string group3PrefabName;
			LuaObject.checkType(l, 2, out group3PrefabName);
			dialogUIController.m_luaExportHelper.m_group3PrefabName = group3PrefabName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1C7 RID: 119239 RVA: 0x00926B78 File Offset: 0x00924D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1C8 RID: 119240 RVA: 0x00926BD0 File Offset: 0x00924DD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			dialogUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1C9 RID: 119241 RVA: 0x00926C2C File Offset: 0x00924E2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_currentAudio(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_currentAudio);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1CA RID: 119242 RVA: 0x00926C84 File Offset: 0x00924E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentAudio(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			IAudioPlayback currentAudio;
			LuaObject.checkType<IAudioPlayback>(l, 2, out currentAudio);
			dialogUIController.m_luaExportHelper.m_currentAudio = currentAudio;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1CB RID: 119243 RVA: 0x00926CE0 File Offset: 0x00924EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogInfo(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_dialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1CC RID: 119244 RVA: 0x00926D38 File Offset: 0x00924F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogInfo(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfo);
			dialogUIController.m_luaExportHelper.m_dialogInfo = dialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1CD RID: 119245 RVA: 0x00926D94 File Offset: 0x00924F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundAssetName(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_backgroundAssetName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1CE RID: 119246 RVA: 0x00926DEC File Offset: 0x00924FEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_backgroundAssetName(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			string backgroundAssetName;
			LuaObject.checkType(l, 2, out backgroundAssetName);
			dialogUIController.m_luaExportHelper.m_backgroundAssetName = backgroundAssetName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1CF RID: 119247 RVA: 0x00926E48 File Offset: 0x00925048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needBGChangeTween(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUIController.m_luaExportHelper.m_needBGChangeTween);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1D0 RID: 119248 RVA: 0x00926EA0 File Offset: 0x009250A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needBGChangeTween(IntPtr l)
	{
		int result;
		try
		{
			DialogUIController dialogUIController = (DialogUIController)LuaObject.checkSelf(l);
			bool needBGChangeTween;
			LuaObject.checkType(l, 2, out needBGChangeTween);
			dialogUIController.m_luaExportHelper.m_needBGChangeTween = needBGChangeTween;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1D1 RID: 119249 RVA: 0x00926EFC File Offset: 0x009250FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DialogUIController");
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.ShowDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.CloseDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.Co_ShowDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.Co_CharLeavePlay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.Co_BGChangeTweenPlay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.Co_SetBGChangeLeaveShowUIState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.Co_SetBGChangeEnterShowUIState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.Co_CreateCharEnter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.PlayBGMInDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.Co_CloseDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.ShowDialogBox);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.CreateBackgroundGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.DestroyBackgroundGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.Co_CreateBeforeEnterEffectGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.Co_CreateBeforeTalkEffectGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.Co_AfterTalkEffectAndLeave);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.Co_CreateAfterTalkEffectGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.CreateEffectGroupLeaveTogether);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.CreateEffectGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.PlayEffectGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.CreateEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.CreateEffectInGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.CreateInsertEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.SetBackgroundImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.ClearBackgroundImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.PlayVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.StopVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.Co_NextDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.OnSkipButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callDele_EventOnSkip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__clearDele_EventOnSkip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callDele_EventOnNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__clearDele_EventOnNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache33);
		string name = "EventOnSkip";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_EventOnSkip);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache34, true);
		string name2 = "EventOnNext";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_EventOnNext);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache35, true);
		string name3 = "EventOnClose";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache36, true);
		string name4 = "m_skipButton";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_skipButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_skipButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache38, true);
		string name5 = "m_backgroundUIStateController";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_backgroundUIStateController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_backgroundUIStateController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3A, true);
		string name6 = "m_backgroundGraphicGameObject";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_backgroundGraphicGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_backgroundGraphicGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3C, true);
		string name7 = "m_backgroundImage";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_backgroundImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_backgroundImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3E, true);
		string name8 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_backgroundButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache40, true);
		string name9 = "m_placeGameObject";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_placeGameObject);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_placeGameObject);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache42, true);
		string name10 = "m_placeText";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_placeText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_placeText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache44, true);
		string name11 = "m_wordsGameObject";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_wordsGameObject);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_wordsGameObject);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache46, true);
		string name12 = "m_char0GameObject";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_char0GameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_char0GameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache48, true);
		string name13 = "m_char1GameObject";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_char1GameObject);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_char1GameObject);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4A, true);
		string name14 = "m_char2GameObject";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_char2GameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_char2GameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4C, true);
		string name15 = "m_effectGroup1";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_effectGroup1);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_effectGroup1);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4E, true);
		string name16 = "m_effectGroup2";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_effectGroup2);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_effectGroup2);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache50, true);
		string name17 = "m_effectGroup3";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_effectGroup3);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_effectGroup3);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache52, true);
		string name18 = "m_insertEffect";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_insertEffect);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_insertEffect);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache54, true);
		string name19 = "m_changeBGTweenUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_changeBGTweenUIStateCtrl);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_changeBGTweenUIStateCtrl);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache56, true);
		string name20 = "m_dialogCharUIControllers";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_dialogCharUIControllers);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_dialogCharUIControllers);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache58, true);
		string name21 = "m_dialogBoxUIController";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_dialogBoxUIController);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_dialogBoxUIController);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5A, true);
		string name22 = "m_backgroundGraphic";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_backgroundGraphic);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_backgroundGraphic);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5C, true);
		string name23 = "m_group1PrefabName";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_group1PrefabName);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_group1PrefabName);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5E, true);
		string name24 = "m_group2PrefabName";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_group2PrefabName);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_group2PrefabName);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache60, true);
		string name25 = "m_group3PrefabName";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_group3PrefabName);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_group3PrefabName);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache62, true);
		string name26 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_configDataLoader);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache64, true);
		string name27 = "m_currentAudio";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_currentAudio);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_currentAudio);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache66, true);
		string name28 = "m_dialogInfo";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_dialogInfo);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_dialogInfo);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache68, true);
		string name29 = "m_backgroundAssetName";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_backgroundAssetName);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_backgroundAssetName);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache6A, true);
		string name30 = "m_needBGChangeTween";
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.get_m_needBGChangeTween);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUIController.set_m_needBGChangeTween);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_DialogUIController.<>f__mg$cache6C, true);
		LuaObject.createTypeMetatable(l, null, typeof(DialogUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401331A RID: 78618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401331B RID: 78619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401331C RID: 78620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401331D RID: 78621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401331E RID: 78622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401331F RID: 78623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013320 RID: 78624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013321 RID: 78625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013322 RID: 78626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013323 RID: 78627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013324 RID: 78628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013325 RID: 78629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013326 RID: 78630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013327 RID: 78631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013328 RID: 78632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013329 RID: 78633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401332A RID: 78634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401332B RID: 78635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401332C RID: 78636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401332D RID: 78637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401332E RID: 78638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401332F RID: 78639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013330 RID: 78640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013331 RID: 78641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013332 RID: 78642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013333 RID: 78643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013334 RID: 78644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013335 RID: 78645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013336 RID: 78646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013337 RID: 78647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013338 RID: 78648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013339 RID: 78649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401333A RID: 78650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401333B RID: 78651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401333C RID: 78652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401333D RID: 78653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401333E RID: 78654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401333F RID: 78655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013340 RID: 78656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013341 RID: 78657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04013342 RID: 78658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04013343 RID: 78659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04013344 RID: 78660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04013345 RID: 78661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04013346 RID: 78662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013347 RID: 78663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013348 RID: 78664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013349 RID: 78665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401334A RID: 78666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401334B RID: 78667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401334C RID: 78668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401334D RID: 78669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401334E RID: 78670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401334F RID: 78671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013350 RID: 78672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04013351 RID: 78673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04013352 RID: 78674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04013353 RID: 78675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04013354 RID: 78676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04013355 RID: 78677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04013356 RID: 78678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04013357 RID: 78679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04013358 RID: 78680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04013359 RID: 78681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401335A RID: 78682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401335B RID: 78683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401335C RID: 78684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401335D RID: 78685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401335E RID: 78686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401335F RID: 78687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04013360 RID: 78688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04013361 RID: 78689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04013362 RID: 78690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04013363 RID: 78691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04013364 RID: 78692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04013365 RID: 78693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04013366 RID: 78694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04013367 RID: 78695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04013368 RID: 78696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04013369 RID: 78697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0401336A RID: 78698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0401336B RID: 78699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0401336C RID: 78700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0401336D RID: 78701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401336E RID: 78702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0401336F RID: 78703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04013370 RID: 78704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04013371 RID: 78705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04013372 RID: 78706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04013373 RID: 78707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04013374 RID: 78708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04013375 RID: 78709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04013376 RID: 78710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04013377 RID: 78711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04013378 RID: 78712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04013379 RID: 78713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0401337A RID: 78714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0401337B RID: 78715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0401337C RID: 78716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0401337D RID: 78717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0401337E RID: 78718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0401337F RID: 78719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04013380 RID: 78720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04013381 RID: 78721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04013382 RID: 78722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04013383 RID: 78723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04013384 RID: 78724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04013385 RID: 78725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04013386 RID: 78726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;
}
