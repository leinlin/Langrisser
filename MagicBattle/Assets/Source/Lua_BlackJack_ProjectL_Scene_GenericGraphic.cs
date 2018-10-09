using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using FixMath.NET;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001343 RID: 4931
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_GenericGraphic : LuaObject
{
	// Token: 0x0601A7B6 RID: 108470 RVA: 0x007D9294 File Offset: 0x007D7494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic o = new GenericGraphic();
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

	// Token: 0x0601A7B7 RID: 108471 RVA: 0x007D92DC File Offset: 0x007D74DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Create(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			bool isFx;
			LuaObject.checkType(l, 3, out isFx);
			bool b = genericGraphic.Create(assetName, isFx);
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

	// Token: 0x0601A7B8 RID: 108472 RVA: 0x007D934C File Offset: 0x007D754C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Destroy(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			genericGraphic.Destroy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7B9 RID: 108473 RVA: 0x007D9398 File Offset: 0x007D7598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetActive(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			bool active;
			LuaObject.checkType(l, 2, out active);
			genericGraphic.SetActive(active);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7BA RID: 108474 RVA: 0x007D93F0 File Offset: 0x007D75F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetParent(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 2, out parent);
			genericGraphic.SetParent(parent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7BB RID: 108475 RVA: 0x007D9448 File Offset: 0x007D7648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayer(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			int layer;
			LuaObject.checkType(l, 2, out layer);
			genericGraphic.SetLayer(layer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7BC RID: 108476 RVA: 0x007D94A0 File Offset: 0x007D76A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSortingOrder(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			int sortingOrder;
			LuaObject.checkType(l, 2, out sortingOrder);
			genericGraphic.SetSortingOrder(sortingOrder);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7BD RID: 108477 RVA: 0x007D94F8 File Offset: 0x007D76F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPrefab(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			GameObject prefab = genericGraphic.GetPrefab();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7BE RID: 108478 RVA: 0x007D954C File Offset: 0x007D774C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetContainer(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			IGenericGraphicContainer container;
			LuaObject.checkType<IGenericGraphicContainer>(l, 2, out container);
			genericGraphic.SetContainer(container);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7BF RID: 108479 RVA: 0x007D95A4 File Offset: 0x007D77A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFxPlayer(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			FxPlayer fxPlayer;
			LuaObject.checkType<FxPlayer>(l, 2, out fxPlayer);
			genericGraphic.SetFxPlayer(fxPlayer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7C0 RID: 108480 RVA: 0x007D95FC File Offset: 0x007D77FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool loop;
			LuaObject.checkType(l, 3, out loop);
			genericGraphic.PlayAnimation(name, loop);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7C1 RID: 108481 RVA: 0x007D9660 File Offset: 0x007D7860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayDeathAnimation(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			int deathType;
			LuaObject.checkType(l, 2, out deathType);
			genericGraphic.PlayDeathAnimation(deathType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7C2 RID: 108482 RVA: 0x007D96B8 File Offset: 0x007D78B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAnimationDuration(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			float animationDuration = genericGraphic.GetAnimationDuration(name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationDuration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7C3 RID: 108483 RVA: 0x007D971C File Offset: 0x007D791C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			int trackIndex;
			LuaObject.checkType(l, 2, out trackIndex);
			bool b = genericGraphic.IsPlayAnimation(trackIndex);
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

	// Token: 0x0601A7C4 RID: 108484 RVA: 0x007D9780 File Offset: 0x007D7980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayFx(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int tag;
			LuaObject.checkType(l, 3, out tag);
			genericGraphic.PlayFx(name, tag);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7C5 RID: 108485 RVA: 0x007D97E4 File Offset: 0x007D79E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetReplaceAnimations(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			List<ReplaceAnim> replaceAnimations;
			LuaObject.checkType<List<ReplaceAnim>>(l, 2, out replaceAnimations);
			genericGraphic.SetReplaceAnimations(replaceAnimations);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7C6 RID: 108486 RVA: 0x007D983C File Offset: 0x007D7A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeight(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			float height;
			LuaObject.checkType(l, 2, out height);
			float footHeight;
			LuaObject.checkType(l, 3, out footHeight);
			genericGraphic.SetHeight(height, footHeight);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7C7 RID: 108487 RVA: 0x007D98A0 File Offset: 0x007D7AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCombatPosition(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			Vector2i pos;
			LuaObject.checkValueType<Vector2i>(l, 2, out pos);
			Fix64 z;
			LuaObject.checkValueType<Fix64>(l, 3, out z);
			int zoffset;
			LuaObject.checkType(l, 4, out zoffset);
			genericGraphic.SetCombatPosition(pos, z, zoffset);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7C8 RID: 108488 RVA: 0x007D9914 File Offset: 0x007D7B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCombatDirection(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
				int combatDirection;
				LuaObject.checkType(l, 2, out combatDirection);
				genericGraphic.SetCombatDirection(combatDirection);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				GenericGraphic genericGraphic2 = (GenericGraphic)LuaObject.checkSelf(l);
				Vector2i front;
				LuaObject.checkValueType<Vector2i>(l, 2, out front);
				Fix64 frontZ;
				LuaObject.checkValueType<Fix64>(l, 3, out frontZ);
				genericGraphic2.SetCombatDirection(front, frontZ);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetCombatDirection to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7C9 RID: 108489 RVA: 0x007D99D8 File Offset: 0x007D7BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDirection(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			genericGraphic.SetDirection(direction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7CA RID: 108490 RVA: 0x007D9A30 File Offset: 0x007D7C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRotationZ(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			float rotationZ;
			LuaObject.checkType(l, 2, out rotationZ);
			genericGraphic.SetRotationZ(rotationZ);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7CB RID: 108491 RVA: 0x007D9A88 File Offset: 0x007D7C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRotation(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			Quaternion rotation;
			LuaObject.checkType(l, 2, out rotation);
			genericGraphic.SetRotation(rotation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7CC RID: 108492 RVA: 0x007D9AE0 File Offset: 0x007D7CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPrefabScale(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(float)))
			{
				GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
				float prefabScale;
				LuaObject.checkType(l, 2, out prefabScale);
				genericGraphic.SetPrefabScale(prefabScale);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Vector3)))
			{
				GenericGraphic genericGraphic2 = (GenericGraphic)LuaObject.checkSelf(l);
				Vector3 prefabScale2;
				LuaObject.checkType(l, 2, out prefabScale2);
				genericGraphic2.SetPrefabScale(prefabScale2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetPrefabScale to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7CD RID: 108493 RVA: 0x007D9BB8 File Offset: 0x007D7DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetName(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			genericGraphic.SetName(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7CE RID: 108494 RVA: 0x007D9C10 File Offset: 0x007D7E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVisible(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			bool visible;
			LuaObject.checkType(l, 2, out visible);
			genericGraphic.SetVisible(visible);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7CF RID: 108495 RVA: 0x007D9C68 File Offset: 0x007D7E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetColor(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			Colori color;
			LuaObject.checkValueType<Colori>(l, 2, out color);
			genericGraphic.SetColor(color);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7D0 RID: 108496 RVA: 0x007D9CC0 File Offset: 0x007D7EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIntensity(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			float intensity;
			LuaObject.checkType(l, 2, out intensity);
			genericGraphic.SetIntensity(intensity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7D1 RID: 108497 RVA: 0x007D9D18 File Offset: 0x007D7F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSaturation(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			float saturation;
			LuaObject.checkType(l, 2, out saturation);
			genericGraphic.SetSaturation(saturation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7D2 RID: 108498 RVA: 0x007D9D70 File Offset: 0x007D7F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEffect(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			GraphicEffect e;
			LuaObject.checkEnum<GraphicEffect>(l, 2, out e);
			float param;
			LuaObject.checkType(l, 3, out param);
			float param2;
			LuaObject.checkType(l, 4, out param2);
			genericGraphic.SetEffect(e, param, param2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A7D3 RID: 108499 RVA: 0x007D9DE4 File Offset: 0x007D7FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearEffect(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			GraphicEffect e;
			LuaObject.checkEnum<GraphicEffect>(l, 2, out e);
			genericGraphic.ClearEffect(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A7D4 RID: 108500 RVA: 0x007D9E3C File Offset: 0x007D803C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAttachFxs(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			int tagMask;
			LuaObject.checkType(l, 2, out tagMask);
			genericGraphic.ClearAttachFxs(tagMask);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7D5 RID: 108501 RVA: 0x007D9E94 File Offset: 0x007D8094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Pause(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			genericGraphic.Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7D6 RID: 108502 RVA: 0x007D9EEC File Offset: 0x007D80EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ForceUpdateSpine(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			genericGraphic.ForceUpdateSpine();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7D7 RID: 108503 RVA: 0x007D9F38 File Offset: 0x007D8138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			genericGraphic.Tick(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7D8 RID: 108504 RVA: 0x007D9F90 File Offset: 0x007D8190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FxStop(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			bool fadeOut;
			LuaObject.checkType(l, 2, out fadeOut);
			genericGraphic.FxStop(fadeOut);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7D9 RID: 108505 RVA: 0x007D9FE8 File Offset: 0x007D81E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFxLifeEnd(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			bool b = genericGraphic.IsFxLifeEnd();
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

	// Token: 0x0601A7DA RID: 108506 RVA: 0x007DA03C File Offset: 0x007D823C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPosition(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			genericGraphic.SetPosition(position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7DB RID: 108507 RVA: 0x007DA094 File Offset: 0x007D8294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPosition(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			Vector3 position = genericGraphic.GetPosition();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7DC RID: 108508 RVA: 0x007DA0E8 File Offset: 0x007D82E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAnchoredPosition(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			Vector3 anchoredPosition;
			LuaObject.checkType(l, 2, out anchoredPosition);
			genericGraphic.SetAnchoredPosition(anchoredPosition);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7DD RID: 108509 RVA: 0x007DA140 File Offset: 0x007D8340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsCulled(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			bool b = genericGraphic.IsCulled();
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

	// Token: 0x0601A7DE RID: 108510 RVA: 0x007DA194 File Offset: 0x007D8394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsVisible(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			bool b = genericGraphic.IsVisible();
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

	// Token: 0x0601A7DF RID: 108511 RVA: 0x007DA1E8 File Offset: 0x007D83E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearGhosts(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			genericGraphic.ClearGhosts();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7E0 RID: 108512 RVA: 0x007DA234 File Offset: 0x007D8434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AutoDelete(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			bool autoDelete;
			LuaObject.checkType(l, 2, out autoDelete);
			genericGraphic.AutoDelete(autoDelete);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7E1 RID: 108513 RVA: 0x007DA28C File Offset: 0x007D848C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeleteMe(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			genericGraphic.DeleteMe();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7E2 RID: 108514 RVA: 0x007DA2D8 File Offset: 0x007D84D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AssetName(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, genericGraphic.AssetName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7E3 RID: 108515 RVA: 0x007DA32C File Offset: 0x007D852C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsDeleteMe(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, genericGraphic.IsDeleteMe);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7E4 RID: 108516 RVA: 0x007DA380 File Offset: 0x007D8580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsAutoDelete(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic genericGraphic = (GenericGraphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, genericGraphic.IsAutoDelete);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7E5 RID: 108517 RVA: 0x007DA3D4 File Offset: 0x007D85D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.GenericGraphic");
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.Create);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.Destroy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetParent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetLayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetSortingOrder);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.GetPrefab);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetContainer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetFxPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.PlayDeathAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.GetAnimationDuration);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.IsPlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.PlayFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetReplaceAnimations);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetHeight);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetCombatPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetCombatDirection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetDirection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetRotationZ);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetRotation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetPrefabScale);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetColor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetIntensity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetSaturation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.ClearEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.ClearAttachFxs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.ForceUpdateSpine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.FxStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.IsFxLifeEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.GetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.SetAnchoredPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.IsCulled);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.IsVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.ClearGhosts);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.AutoDelete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.DeleteMe);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2A);
		string name = "AssetName";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.get_AssetName);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2B, null, true);
		string name2 = "IsDeleteMe";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.get_IsDeleteMe);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2C, null, true);
		string name3 = "IsAutoDelete";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.get_IsAutoDelete);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2D, null, true);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic.<>f__mg$cache2E, typeof(GenericGraphic));
	}

	// Token: 0x04010B12 RID: 68370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010B13 RID: 68371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010B14 RID: 68372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010B15 RID: 68373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010B16 RID: 68374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010B17 RID: 68375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010B18 RID: 68376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010B19 RID: 68377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010B1A RID: 68378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010B1B RID: 68379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010B1C RID: 68380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010B1D RID: 68381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010B1E RID: 68382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010B1F RID: 68383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010B20 RID: 68384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010B21 RID: 68385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010B22 RID: 68386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010B23 RID: 68387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010B24 RID: 68388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010B25 RID: 68389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010B26 RID: 68390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010B27 RID: 68391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010B28 RID: 68392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010B29 RID: 68393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010B2A RID: 68394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010B2B RID: 68395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010B2C RID: 68396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010B2D RID: 68397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010B2E RID: 68398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010B2F RID: 68399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010B30 RID: 68400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010B31 RID: 68401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010B32 RID: 68402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010B33 RID: 68403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010B34 RID: 68404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010B35 RID: 68405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010B36 RID: 68406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010B37 RID: 68407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010B38 RID: 68408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010B39 RID: 68409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010B3A RID: 68410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010B3B RID: 68411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010B3C RID: 68412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010B3D RID: 68413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010B3E RID: 68414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010B3F RID: 68415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010B40 RID: 68416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;
}
