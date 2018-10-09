using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200134A RID: 4938
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_UISpineGraphic : LuaObject
{
	// Token: 0x0601A84D RID: 108621 RVA: 0x007DD5D8 File Offset: 0x007DB7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic o = new UISpineGraphic();
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

	// Token: 0x0601A84E RID: 108622 RVA: 0x007DD620 File Offset: 0x007DB820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Create(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			bool b = uispineGraphic.Create(assetName);
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

	// Token: 0x0601A84F RID: 108623 RVA: 0x007DD684 File Offset: 0x007DB884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Destroy(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			uispineGraphic.Destroy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A850 RID: 108624 RVA: 0x007DD6D0 File Offset: 0x007DB8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDirection(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			uispineGraphic.SetDirection(direction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A851 RID: 108625 RVA: 0x007DD728 File Offset: 0x007DB928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetParent(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 2, out parent);
			uispineGraphic.SetParent(parent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A852 RID: 108626 RVA: 0x007DD780 File Offset: 0x007DB980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPosition(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			Vector2 position;
			LuaObject.checkType(l, 2, out position);
			uispineGraphic.SetPosition(position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A853 RID: 108627 RVA: 0x007DD7D8 File Offset: 0x007DB9D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetScale(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			float scale;
			LuaObject.checkType(l, 2, out scale);
			uispineGraphic.SetScale(scale);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A854 RID: 108628 RVA: 0x007DD830 File Offset: 0x007DBA30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRectTransformSize(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			Vector2 rectTransformSize;
			LuaObject.checkType(l, 2, out rectTransformSize);
			uispineGraphic.SetRectTransformSize(rectTransformSize);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A855 RID: 108629 RVA: 0x007DD888 File Offset: 0x007DBA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetColor(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			Color color;
			LuaObject.checkType(l, 2, out color);
			uispineGraphic.SetColor(color);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A856 RID: 108630 RVA: 0x007DD8E0 File Offset: 0x007DBAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool loop;
			LuaObject.checkType(l, 3, out loop);
			int trackIndex;
			LuaObject.checkType(l, 4, out trackIndex);
			uispineGraphic.PlayAnimation(name, loop, trackIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A857 RID: 108631 RVA: 0x007DD954 File Offset: 0x007DBB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopAnimation(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			int trackIndex;
			LuaObject.checkType(l, 2, out trackIndex);
			uispineGraphic.StopAnimation(trackIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A858 RID: 108632 RVA: 0x007DD9AC File Offset: 0x007DBBAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLoop(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			int trackIndex;
			LuaObject.checkType(l, 2, out trackIndex);
			bool b = uispineGraphic.IsLoop(trackIndex);
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

	// Token: 0x0601A859 RID: 108633 RVA: 0x007DDA10 File Offset: 0x007DBC10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			int trackIndex;
			LuaObject.checkType(l, 2, out trackIndex);
			bool b = uispineGraphic.IsPlayAnimation(trackIndex);
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

	// Token: 0x0601A85A RID: 108634 RVA: 0x007DDA74 File Offset: 0x007DBC74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAnimationDuration(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
				int trackIndex;
				LuaObject.checkType(l, 2, out trackIndex);
				float animationDuration = uispineGraphic.GetAnimationDuration(trackIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, animationDuration);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				UISpineGraphic uispineGraphic2 = (UISpineGraphic)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float animationDuration2 = uispineGraphic2.GetAnimationDuration(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, animationDuration2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetAnimationDuration to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A85B RID: 108635 RVA: 0x007DDB60 File Offset: 0x007DBD60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAnimationTime(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			int trackIndex;
			LuaObject.checkType(l, 2, out trackIndex);
			float animationTime = uispineGraphic.GetAnimationTime(trackIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A85C RID: 108636 RVA: 0x007DDBC4 File Offset: 0x007DBDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAnimationTime(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			int trackIndex;
			LuaObject.checkType(l, 2, out trackIndex);
			float time;
			LuaObject.checkType(l, 3, out time);
			uispineGraphic.SetAnimationTime(trackIndex, time);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A85D RID: 108637 RVA: 0x007DDC28 File Offset: 0x007DBE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetReplaceAnimations(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			List<ReplaceAnim> replaceAnimations;
			LuaObject.checkType<List<ReplaceAnim>>(l, 2, out replaceAnimations);
			uispineGraphic.SetReplaceAnimations(replaceAnimations);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A85E RID: 108638 RVA: 0x007DDC80 File Offset: 0x007DBE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasAnimation(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool b = uispineGraphic.HasAnimation(name);
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

	// Token: 0x0601A85F RID: 108639 RVA: 0x007DDCE4 File Offset: 0x007DBEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAnimationSpeed(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			float animationSpeed;
			LuaObject.checkType(l, 2, out animationSpeed);
			uispineGraphic.SetAnimationSpeed(animationSpeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A860 RID: 108640 RVA: 0x007DDD3C File Offset: 0x007DBF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ForceUpdate(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			uispineGraphic.ForceUpdate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A861 RID: 108641 RVA: 0x007DDD88 File Offset: 0x007DBF88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSlot(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool show;
			LuaObject.checkType(l, 3, out show);
			uispineGraphic.ShowSlot(name, show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A862 RID: 108642 RVA: 0x007DDDEC File Offset: 0x007DBFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableCanvasGroupAlpha(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			uispineGraphic.EnableCanvasGroupAlpha(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A863 RID: 108643 RVA: 0x007DDE44 File Offset: 0x007DC044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GameObject(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uispineGraphic.GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A864 RID: 108644 RVA: 0x007DDE98 File Offset: 0x007DC098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AssetName(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic uispineGraphic = (UISpineGraphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uispineGraphic.AssetName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A865 RID: 108645 RVA: 0x007DDEEC File Offset: 0x007DC0EC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.UISpineGraphic");
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.Create);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.Destroy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.SetDirection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.SetParent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.SetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.SetScale);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.SetRectTransformSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.SetColor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.StopAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.IsLoop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.IsPlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.GetAnimationDuration);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.GetAnimationTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.SetAnimationTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.SetReplaceAnimations);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.HasAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.SetAnimationSpeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.ForceUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.ShowSlot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.EnableCanvasGroupAlpha);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache14);
		string name = "GameObject";
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.get_GameObject);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache15, null, true);
		string name2 = "AssetName";
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.get_AssetName);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache16, null, true);
		if (Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_UISpineGraphic.<>f__mg$cache17, typeof(UISpineGraphic));
	}

	// Token: 0x04010B9B RID: 68507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010B9C RID: 68508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010B9D RID: 68509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010B9E RID: 68510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010B9F RID: 68511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010BA0 RID: 68512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010BA1 RID: 68513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010BA2 RID: 68514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010BA3 RID: 68515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010BA4 RID: 68516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010BA5 RID: 68517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010BA6 RID: 68518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010BA7 RID: 68519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010BA8 RID: 68520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010BA9 RID: 68521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010BAA RID: 68522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010BAB RID: 68523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010BAC RID: 68524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010BAD RID: 68525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010BAE RID: 68526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010BAF RID: 68527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010BB0 RID: 68528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010BB1 RID: 68529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010BB2 RID: 68530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
