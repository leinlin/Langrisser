using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200160E RID: 5646
[Preserve]
public class Lua_UnityEngine_Animation : LuaObject
{
	// Token: 0x060229F1 RID: 141809 RVA: 0x00BEC8A0 File Offset: 0x00BEAAA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Stop(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Animation animation = (Animation)LuaObject.checkSelf(l);
				animation.Stop();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				Animation animation2 = (Animation)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				animation2.Stop(name);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Stop to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229F2 RID: 141810 RVA: 0x00BEC948 File Offset: 0x00BEAB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Rewind(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Animation animation = (Animation)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				animation.Rewind(name);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 1)
			{
				Animation animation2 = (Animation)LuaObject.checkSelf(l);
				animation2.Rewind();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Rewind to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229F3 RID: 141811 RVA: 0x00BEC9F4 File Offset: 0x00BEABF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Sample(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			animation.Sample();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229F4 RID: 141812 RVA: 0x00BECA40 File Offset: 0x00BEAC40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsPlaying(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool b = animation.IsPlaying(name);
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

	// Token: 0x060229F5 RID: 141813 RVA: 0x00BECAA4 File Offset: 0x00BEACA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Play(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Animation animation = (Animation)LuaObject.checkSelf(l);
				bool b = animation.Play();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(PlayMode)))
			{
				Animation animation2 = (Animation)LuaObject.checkSelf(l);
				PlayMode mode;
				LuaObject.checkEnum<PlayMode>(l, 2, out mode);
				bool b2 = animation2.Play(mode);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string)))
			{
				Animation animation3 = (Animation)LuaObject.checkSelf(l);
				string animation4;
				LuaObject.checkType(l, 2, out animation4);
				bool b3 = animation3.Play(animation4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				result = 2;
			}
			else if (num == 3)
			{
				Animation animation5 = (Animation)LuaObject.checkSelf(l);
				string animation6;
				LuaObject.checkType(l, 2, out animation6);
				PlayMode mode2;
				LuaObject.checkEnum<PlayMode>(l, 3, out mode2);
				bool b4 = animation5.Play(animation6, mode2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Play to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229F6 RID: 141814 RVA: 0x00BECC18 File Offset: 0x00BEAE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CrossFade(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Animation animation = (Animation)LuaObject.checkSelf(l);
				string animation2;
				LuaObject.checkType(l, 2, out animation2);
				animation.CrossFade(animation2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Animation animation3 = (Animation)LuaObject.checkSelf(l);
				string animation4;
				LuaObject.checkType(l, 2, out animation4);
				float fadeLength;
				LuaObject.checkType(l, 3, out fadeLength);
				animation3.CrossFade(animation4, fadeLength);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Animation animation5 = (Animation)LuaObject.checkSelf(l);
				string animation6;
				LuaObject.checkType(l, 2, out animation6);
				float fadeLength2;
				LuaObject.checkType(l, 3, out fadeLength2);
				PlayMode mode;
				LuaObject.checkEnum<PlayMode>(l, 4, out mode);
				animation5.CrossFade(animation6, fadeLength2, mode);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CrossFade to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229F7 RID: 141815 RVA: 0x00BECD28 File Offset: 0x00BEAF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Blend(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Animation animation = (Animation)LuaObject.checkSelf(l);
				string animation2;
				LuaObject.checkType(l, 2, out animation2);
				animation.Blend(animation2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Animation animation3 = (Animation)LuaObject.checkSelf(l);
				string animation4;
				LuaObject.checkType(l, 2, out animation4);
				float targetWeight;
				LuaObject.checkType(l, 3, out targetWeight);
				animation3.Blend(animation4, targetWeight);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Animation animation5 = (Animation)LuaObject.checkSelf(l);
				string animation6;
				LuaObject.checkType(l, 2, out animation6);
				float targetWeight2;
				LuaObject.checkType(l, 3, out targetWeight2);
				float fadeLength;
				LuaObject.checkType(l, 4, out fadeLength);
				animation5.Blend(animation6, targetWeight2, fadeLength);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Blend to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229F8 RID: 141816 RVA: 0x00BECE38 File Offset: 0x00BEB038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CrossFadeQueued(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Animation animation = (Animation)LuaObject.checkSelf(l);
				string animation2;
				LuaObject.checkType(l, 2, out animation2);
				AnimationState o = animation.CrossFadeQueued(animation2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				Animation animation3 = (Animation)LuaObject.checkSelf(l);
				string animation4;
				LuaObject.checkType(l, 2, out animation4);
				float fadeLength;
				LuaObject.checkType(l, 3, out fadeLength);
				AnimationState o2 = animation3.CrossFadeQueued(animation4, fadeLength);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (num == 4)
			{
				Animation animation5 = (Animation)LuaObject.checkSelf(l);
				string animation6;
				LuaObject.checkType(l, 2, out animation6);
				float fadeLength2;
				LuaObject.checkType(l, 3, out fadeLength2);
				QueueMode queue;
				LuaObject.checkEnum<QueueMode>(l, 4, out queue);
				AnimationState o3 = animation5.CrossFadeQueued(animation6, fadeLength2, queue);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else if (num == 5)
			{
				Animation animation7 = (Animation)LuaObject.checkSelf(l);
				string animation8;
				LuaObject.checkType(l, 2, out animation8);
				float fadeLength3;
				LuaObject.checkType(l, 3, out fadeLength3);
				QueueMode queue2;
				LuaObject.checkEnum<QueueMode>(l, 4, out queue2);
				PlayMode mode;
				LuaObject.checkEnum<PlayMode>(l, 5, out mode);
				AnimationState o4 = animation7.CrossFadeQueued(animation8, fadeLength3, queue2, mode);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CrossFadeQueued to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229F9 RID: 141817 RVA: 0x00BECFD8 File Offset: 0x00BEB1D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayQueued(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Animation animation = (Animation)LuaObject.checkSelf(l);
				string animation2;
				LuaObject.checkType(l, 2, out animation2);
				AnimationState o = animation.PlayQueued(animation2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				Animation animation3 = (Animation)LuaObject.checkSelf(l);
				string animation4;
				LuaObject.checkType(l, 2, out animation4);
				QueueMode queue;
				LuaObject.checkEnum<QueueMode>(l, 3, out queue);
				AnimationState o2 = animation3.PlayQueued(animation4, queue);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (num == 4)
			{
				Animation animation5 = (Animation)LuaObject.checkSelf(l);
				string animation6;
				LuaObject.checkType(l, 2, out animation6);
				QueueMode queue2;
				LuaObject.checkEnum<QueueMode>(l, 3, out queue2);
				PlayMode mode;
				LuaObject.checkEnum<PlayMode>(l, 4, out mode);
				AnimationState o3 = animation5.PlayQueued(animation6, queue2, mode);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function PlayQueued to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229FA RID: 141818 RVA: 0x00BED114 File Offset: 0x00BEB314
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddClip(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Animation animation = (Animation)LuaObject.checkSelf(l);
				AnimationClip clip;
				LuaObject.checkType<AnimationClip>(l, 2, out clip);
				string newName;
				LuaObject.checkType(l, 3, out newName);
				animation.AddClip(clip, newName);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				Animation animation2 = (Animation)LuaObject.checkSelf(l);
				AnimationClip clip2;
				LuaObject.checkType<AnimationClip>(l, 2, out clip2);
				string newName2;
				LuaObject.checkType(l, 3, out newName2);
				int firstFrame;
				LuaObject.checkType(l, 4, out firstFrame);
				int lastFrame;
				LuaObject.checkType(l, 5, out lastFrame);
				animation2.AddClip(clip2, newName2, firstFrame, lastFrame);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				Animation animation3 = (Animation)LuaObject.checkSelf(l);
				AnimationClip clip3;
				LuaObject.checkType<AnimationClip>(l, 2, out clip3);
				string newName3;
				LuaObject.checkType(l, 3, out newName3);
				int firstFrame2;
				LuaObject.checkType(l, 4, out firstFrame2);
				int lastFrame2;
				LuaObject.checkType(l, 5, out lastFrame2);
				bool addLoopFrame;
				LuaObject.checkType(l, 6, out addLoopFrame);
				animation3.AddClip(clip3, newName3, firstFrame2, lastFrame2, addLoopFrame);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddClip to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229FB RID: 141819 RVA: 0x00BED270 File Offset: 0x00BEB470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveClip(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(AnimationClip)))
			{
				Animation animation = (Animation)LuaObject.checkSelf(l);
				AnimationClip clip;
				LuaObject.checkType<AnimationClip>(l, 2, out clip);
				animation.RemoveClip(clip);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				Animation animation2 = (Animation)LuaObject.checkSelf(l);
				string clipName;
				LuaObject.checkType(l, 2, out clipName);
				animation2.RemoveClip(clipName);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function RemoveClip to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229FC RID: 141820 RVA: 0x00BED348 File Offset: 0x00BEB548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetClipCount(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			int clipCount = animation.GetClipCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clipCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229FD RID: 141821 RVA: 0x00BED39C File Offset: 0x00BEB59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SyncLayer(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			int layer;
			LuaObject.checkType(l, 2, out layer);
			animation.SyncLayer(layer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229FE RID: 141822 RVA: 0x00BED3F4 File Offset: 0x00BEB5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetClip(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			AnimationClip clip = animation.GetClip(name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229FF RID: 141823 RVA: 0x00BED458 File Offset: 0x00BEB658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clip(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animation.clip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A00 RID: 141824 RVA: 0x00BED4AC File Offset: 0x00BEB6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_clip(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			AnimationClip clip;
			LuaObject.checkType<AnimationClip>(l, 2, out clip);
			animation.clip = clip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A01 RID: 141825 RVA: 0x00BED504 File Offset: 0x00BEB704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_playAutomatically(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animation.playAutomatically);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A02 RID: 141826 RVA: 0x00BED558 File Offset: 0x00BEB758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_playAutomatically(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			bool playAutomatically;
			LuaObject.checkType(l, 2, out playAutomatically);
			animation.playAutomatically = playAutomatically;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A03 RID: 141827 RVA: 0x00BED5B0 File Offset: 0x00BEB7B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_wrapMode(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)animation.wrapMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A04 RID: 141828 RVA: 0x00BED604 File Offset: 0x00BEB804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_wrapMode(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			WrapMode wrapMode;
			LuaObject.checkEnum<WrapMode>(l, 2, out wrapMode);
			animation.wrapMode = wrapMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A05 RID: 141829 RVA: 0x00BED65C File Offset: 0x00BEB85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isPlaying(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animation.isPlaying);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A06 RID: 141830 RVA: 0x00BED6B0 File Offset: 0x00BEB8B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_animatePhysics(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animation.animatePhysics);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A07 RID: 141831 RVA: 0x00BED704 File Offset: 0x00BEB904
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_animatePhysics(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			bool animatePhysics;
			LuaObject.checkType(l, 2, out animatePhysics);
			animation.animatePhysics = animatePhysics;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A08 RID: 141832 RVA: 0x00BED75C File Offset: 0x00BEB95C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_cullingType(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)animation.cullingType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A09 RID: 141833 RVA: 0x00BED7B0 File Offset: 0x00BEB9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cullingType(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			AnimationCullingType cullingType;
			LuaObject.checkEnum<AnimationCullingType>(l, 2, out cullingType);
			animation.cullingType = cullingType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A0A RID: 141834 RVA: 0x00BED808 File Offset: 0x00BEBA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_localBounds(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animation.localBounds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A0B RID: 141835 RVA: 0x00BED860 File Offset: 0x00BEBA60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_localBounds(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			Bounds localBounds;
			LuaObject.checkValueType<Bounds>(l, 2, out localBounds);
			animation.localBounds = localBounds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A0C RID: 141836 RVA: 0x00BED8B8 File Offset: 0x00BEBAB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			Animation animation = (Animation)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			AnimationState o = animation[name];
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

	// Token: 0x06022A0D RID: 141837 RVA: 0x00BED91C File Offset: 0x00BEBB1C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Animation");
		if (Lua_UnityEngine_Animation.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Animation.Stop);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cache0);
		if (Lua_UnityEngine_Animation.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Animation.Rewind);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cache1);
		if (Lua_UnityEngine_Animation.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Animation.Sample);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cache2);
		if (Lua_UnityEngine_Animation.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Animation.IsPlaying);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cache3);
		if (Lua_UnityEngine_Animation.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Animation.Play);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cache4);
		if (Lua_UnityEngine_Animation.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Animation.CrossFade);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cache5);
		if (Lua_UnityEngine_Animation.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Animation.Blend);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cache6);
		if (Lua_UnityEngine_Animation.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Animation.CrossFadeQueued);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cache7);
		if (Lua_UnityEngine_Animation.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Animation.PlayQueued);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cache8);
		if (Lua_UnityEngine_Animation.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Animation.AddClip);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cache9);
		if (Lua_UnityEngine_Animation.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Animation.RemoveClip);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cacheA);
		if (Lua_UnityEngine_Animation.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Animation.GetClipCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cacheB);
		if (Lua_UnityEngine_Animation.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Animation.SyncLayer);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cacheC);
		if (Lua_UnityEngine_Animation.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Animation.GetClip);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cacheD);
		if (Lua_UnityEngine_Animation.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Animation.getItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animation.<>f__mg$cacheE);
		string name = "clip";
		if (Lua_UnityEngine_Animation.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Animation.get_clip);
		}
		LuaCSFunction get = Lua_UnityEngine_Animation.<>f__mg$cacheF;
		if (Lua_UnityEngine_Animation.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Animation.set_clip);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Animation.<>f__mg$cache10, true);
		string name2 = "playAutomatically";
		if (Lua_UnityEngine_Animation.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Animation.get_playAutomatically);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Animation.<>f__mg$cache11;
		if (Lua_UnityEngine_Animation.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Animation.set_playAutomatically);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Animation.<>f__mg$cache12, true);
		string name3 = "wrapMode";
		if (Lua_UnityEngine_Animation.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Animation.get_wrapMode);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Animation.<>f__mg$cache13;
		if (Lua_UnityEngine_Animation.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Animation.set_wrapMode);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Animation.<>f__mg$cache14, true);
		string name4 = "isPlaying";
		if (Lua_UnityEngine_Animation.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Animation.get_isPlaying);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Animation.<>f__mg$cache15, null, true);
		string name5 = "animatePhysics";
		if (Lua_UnityEngine_Animation.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Animation.get_animatePhysics);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Animation.<>f__mg$cache16;
		if (Lua_UnityEngine_Animation.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Animation.set_animatePhysics);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_Animation.<>f__mg$cache17, true);
		string name6 = "cullingType";
		if (Lua_UnityEngine_Animation.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Animation.get_cullingType);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Animation.<>f__mg$cache18;
		if (Lua_UnityEngine_Animation.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Animation.set_cullingType);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_Animation.<>f__mg$cache19, true);
		string name7 = "localBounds";
		if (Lua_UnityEngine_Animation.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Animation.get_localBounds);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Animation.<>f__mg$cache1A;
		if (Lua_UnityEngine_Animation.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Animation.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Animation.set_localBounds);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_Animation.<>f__mg$cache1B, true);
		LuaObject.createTypeMetatable(l, null, typeof(Animation), typeof(Behaviour));
	}

	// Token: 0x04018A33 RID: 100915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018A34 RID: 100916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018A35 RID: 100917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018A36 RID: 100918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018A37 RID: 100919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018A38 RID: 100920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018A39 RID: 100921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018A3A RID: 100922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018A3B RID: 100923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018A3C RID: 100924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018A3D RID: 100925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018A3E RID: 100926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018A3F RID: 100927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018A40 RID: 100928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018A41 RID: 100929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018A42 RID: 100930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018A43 RID: 100931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018A44 RID: 100932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018A45 RID: 100933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018A46 RID: 100934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018A47 RID: 100935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018A48 RID: 100936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018A49 RID: 100937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018A4A RID: 100938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018A4B RID: 100939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018A4C RID: 100940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018A4D RID: 100941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018A4E RID: 100942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;
}
