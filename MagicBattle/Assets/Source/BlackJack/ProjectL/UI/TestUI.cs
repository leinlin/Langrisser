using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using FixMath.NET;
using SLua;
using UnityEngine;
using UnityEngine.Profiling;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F8C RID: 3980
	[HotFix]
	public class TestUI : MonoBehaviour
	{
		// Token: 0x06013EDC RID: 81628 RVA: 0x005133E0 File Offset: 0x005115E0
		private void Awake()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Awake_hotfix != null)
			{
				this.m_Awake_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_initScreenWidth = Screen.width;
			this.m_initScreenHeight = Screen.height;
		}

		// Token: 0x06013EDD RID: 81629 RVA: 0x00513458 File Offset: 0x00511658
		public void InitializeBattle(ClientBattle clientBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeBattleClientBattle_hotfix != null)
			{
				this.m_InitializeBattleClientBattle_hotfix.call(new object[]
				{
					this,
					clientBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattle = clientBattle;
		}

		// Token: 0x06013EDE RID: 81630 RVA: 0x005134D0 File Offset: 0x005116D0
		public void UninitializeBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitializeBattle_hotfix != null)
			{
				this.m_UninitializeBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattle = null;
		}

		// Token: 0x06013EDF RID: 81631 RVA: 0x00513538 File Offset: 0x00511738
		public void InitializeWorld(ClientWorld clientWorld)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeWorldClientWorld_hotfix != null)
			{
				this.m_InitializeWorldClientWorld_hotfix.call(new object[]
				{
					this,
					clientWorld
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientWorld = clientWorld;
		}

		// Token: 0x06013EE0 RID: 81632 RVA: 0x005135B0 File Offset: 0x005117B0
		public void UninitializeWorld()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitializeWorld_hotfix != null)
			{
				this.m_UninitializeWorld_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientWorld = null;
		}

		// Token: 0x06013EE1 RID: 81633 RVA: 0x00513618 File Offset: 0x00511818
		private void SetTimeScale(float ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTimeScaleSingle_hotfix != null)
			{
				this.m_SetTimeScaleSingle_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isTimePaused = (ts <= 0f);
			if (ts > 0f)
			{
				this.m_timeScale = ts;
			}
			if (this.m_clientBattle != null)
			{
				this.m_clientBattle.SetGlobalTimeScale(ts);
			}
			else if (this.m_clientWorld != null)
			{
				this.m_clientWorld.SetGlobalTimeScale(ts);
			}
			else
			{
				SystemUtility.SetTimeScale(ts);
			}
		}

		// Token: 0x06013EE2 RID: 81634 RVA: 0x005136EC File Offset: 0x005118EC
		private bool ToolButton(ref int x, ref int y, float size, string text)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ToolButtonInt32_Int32_SingleString_hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_ToolButton_Int32_Int32_Single_String(this, this.m_ToolButtonInt32_Int32_SingleString_hotfix, ref x, ref y, size, text);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = (int)((float)this.m_unit * size);
			bool result = GUI.Button(new Rect((float)x, (float)y, (float)num, (float)(this.m_unit * 2)), text, this.m_buttonStyle);
			x += num;
			return result;
		}

		// Token: 0x06013EE3 RID: 81635 RVA: 0x00513784 File Offset: 0x00511984
		private bool ToolToggle(ref int x, ref int y, float size, string text, bool oldValue)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ToolToggleInt32_Int32_SingleStringBoolean_hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_ToolToggle_Int32_Int32_Single_String_Boolean(this, this.m_ToolToggleInt32_Int32_SingleStringBoolean_hotfix, ref x, ref y, size, text, oldValue);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = (int)((float)this.m_unit * size);
			bool result = GUI.Toggle(new Rect((float)x, (float)y, (float)num, (float)(this.m_unit * 2)), oldValue, text, this.m_buttonStyle);
			x += num;
			return result;
		}

		// Token: 0x06013EE4 RID: 81636 RVA: 0x00513820 File Offset: 0x00511A20
		private void TextLine(int x, ref int y, string text)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TextLineInt32Int32_String_hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_TextLine_Int32_Int32_String(this, this.m_TextLineInt32Int32_String_hotfix, x, ref y, text);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GUI.Label(new Rect((float)x, (float)y, (float)(text.Length * this.m_unit), (float)this.m_unit), text, this.m_textStyle);
			y += this.m_unit;
		}

		// Token: 0x06013EE5 RID: 81637 RVA: 0x005138AC File Offset: 0x00511AAC
		private void GUIBattleTestTools()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUIBattleTestTools_hotfix != null)
			{
				this.m_GUIBattleTestTools_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			int num2 = Screen.height - this.m_unit;
			this.GUIToolToggle(ref num, ref num2);
			if (!this.m_isShowTestToolBar)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			num += this.m_unit * 2;
			this.GUISpeedToggle(ref num, ref num2);
			if (!projectLPlayerContext.IsInBattleRoom())
			{
				num += this.m_unit;
				if (this.m_clientBattle.State == ClientBattleState.Combat)
				{
					if (this.ToolButton(ref num, ref num2, 3f, "Restart"))
					{
						this.SetTimeScale(this.m_timeScale);
						this.m_clientBattle.Battle.RestartCombat();
					}
					if (this.ToolButton(ref num, ref num2, 3f, "Exit"))
					{
						this.SetTimeScale(this.m_timeScale);
						this.m_clientBattle.Battle.Combat.Stop();
					}
				}
				else if (this.m_clientBattle.State != ClientBattleState.Prepare)
				{
					if (this.ToolButton(ref num, ref num2, 3f, "Restart"))
					{
						this.SetTimeScale(this.m_timeScale);
						if (this.EventOnRestartBattle != null)
						{
							this.EventOnRestartBattle();
						}
					}
					if (this.ToolButton(ref num, ref num2, 3f, "Replay"))
					{
						this.SetTimeScale(this.m_timeScale);
						if (this.EventOnReplayBattle != null)
						{
							this.EventOnReplayBattle();
						}
					}
					if (this.ToolButton(ref num, ref num2, 3f, "Win"))
					{
						this.SetTimeScale(this.m_timeScale);
						if (this.EventOnStopBattle != null)
						{
							this.EventOnStopBattle(true);
						}
					}
				}
			}
			if (!this.m_isShowGMCommand)
			{
				num += this.m_unit;
				bool enableDebugDraw = this.m_clientBattle.EnableDebugDraw;
				if (this.ToolToggle(ref num, ref num2, 2f, "Line", enableDebugDraw) != enableDebugDraw)
				{
					this.m_clientBattle.EnableDebugDraw = !enableDebugDraw;
				}
				this.GUIAudioToggle(ref num, ref num2);
				this.GUIResolutionToggle(ref num, ref num2);
				this.GUITimeToggle(ref num, ref num2);
				this.GUILowMemoryTest(ref num, ref num2);
			}
			num += this.m_unit;
			this.GUIGMCommandToggle(ref num, ref num2);
			this.GUIGMReloginButton(ref num, ref num2);
		}

		// Token: 0x06013EE6 RID: 81638 RVA: 0x00513B48 File Offset: 0x00511D48
		private void GUIWorldTestTools()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUIWorldTestTools_hotfix != null)
			{
				this.m_GUIWorldTestTools_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			int num2 = Screen.height - this.m_unit;
			this.GUIToolToggle(ref num, ref num2);
			if (!this.m_isShowTestToolBar)
			{
				return;
			}
			num += this.m_unit * 2;
			this.GUISpeedToggle(ref num, ref num2);
			if (!this.m_isShowGMCommand)
			{
				num += this.m_unit;
				bool enableDebugDraw = this.m_clientWorld.EnableDebugDraw;
				if (this.ToolToggle(ref num, ref num2, 2f, "Line", enableDebugDraw) != enableDebugDraw)
				{
					this.m_clientWorld.EnableDebugDraw = !enableDebugDraw;
				}
				this.GUIAudioToggle(ref num, ref num2);
				this.GUIResolutionToggle(ref num, ref num2);
				this.GUITimeToggle(ref num, ref num2);
				this.GUILowMemoryTest(ref num, ref num2);
			}
			num += this.m_unit;
			this.GUIGMCommandToggle(ref num, ref num2);
			this.GUIGMReloginButton(ref num, ref num2);
		}

		// Token: 0x06013EE7 RID: 81639 RVA: 0x00513C74 File Offset: 0x00511E74
		private void GUIGMReloginButton(ref int x, ref int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUIGMReloginButtonInt32_Int32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_GUIGMReloginButton_Int32_Int32(this, this.m_GUIGMReloginButtonInt32_Int32__hotfix, ref x, ref y);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.ToolButton(ref x, ref y, 3f, "Relogin"))
			{
				LoginUITask.Relogin();
			}
		}

		// Token: 0x06013EE8 RID: 81640 RVA: 0x00513CE4 File Offset: 0x00511EE4
		private void GUIToolToggle(ref int x, ref int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUIToolToggleInt32_Int32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_GUIToolToggle_Int32_Int32(this, this.m_GUIToolToggleInt32_Int32__hotfix, ref x, ref y);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GUI.Label(new Rect((float)x, (float)y, (float)(this.m_unit * 10), (float)(this.m_unit * 2)), string.Format("FPS  {0:f1} ({1:f1})", this.m_fps, 1000f / this.m_fps), this.m_textStyle);
			y = Screen.height - this.m_unit * 2;
			bool flag = this.ToolToggle(ref x, ref y, 2f, "-", this.m_isShowTestToolBar);
			if (flag != this.m_isShowTestToolBar)
			{
				this.m_isShowTestToolBar = flag;
				this.UpdateTestUIBackground();
			}
			if (this.m_isShowTestToolToggle && GUI.Button(new Rect((float)x, (float)y, (float)this.m_unit * 0.8f, (float)this.m_unit * 0.8f), "x", this.m_buttonStyle))
			{
				LocalConfig.Instance.Data.IsDeveloper = (this.m_isShowTestToolToggle = (this.m_isShowTestToolBar = false));
				LocalConfig.Instance.Save();
				this.UpdateTestUIBackground();
			}
		}

		// Token: 0x06013EE9 RID: 81641 RVA: 0x00513E44 File Offset: 0x00512044
		private void GUISpeedToggle(ref int x, ref int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUISpeedToggleInt32_Int32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_GUISpeedToggle_Int32_Int32(this, this.m_GUISpeedToggleInt32_Int32__hotfix, ref x, ref y);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.ToolButton(ref x, ref y, 2f, ".1x"))
			{
				this.SetTimeScale(0.1f);
			}
			if (this.ToolButton(ref x, ref y, 2f, ".5x"))
			{
				this.SetTimeScale(0.5f);
			}
			if (this.ToolButton(ref x, ref y, 2f, "1x"))
			{
				this.SetTimeScale(1f);
			}
			if (this.ToolButton(ref x, ref y, 2f, "2x"))
			{
				this.SetTimeScale(2f);
			}
			if (this.ToolButton(ref x, ref y, 2f, "10x"))
			{
				this.SetTimeScale(10f);
			}
			if (this.ToolButton(ref x, ref y, 2f, "30x"))
			{
				this.SetTimeScale(30f);
			}
			if (this.ToolButton(ref x, ref y, 2f, "||"))
			{
				if (this.m_isTimePaused)
				{
					this.SetTimeScale(this.m_timeScale);
				}
				else
				{
					this.SetTimeScale(0f);
				}
			}
		}

		// Token: 0x06013EEA RID: 81642 RVA: 0x00513FA4 File Offset: 0x005121A4
		private void GUIAudioToggle(ref int x, ref int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUIAudioToggleInt32_Int32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_GUIAudioToggle_Int32_Int32(this, this.m_GUIAudioToggleInt32_Int32__hotfix, ref x, ref y);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = AudioUtility.GetVolume("Music_VolumeControl") > 0f;
			if (this.ToolToggle(ref x, ref y, 2.5f, "Music", flag) != flag)
			{
				AudioUtility.SetVolume("Music_VolumeControl", (float)((!flag) ? 1 : 0), true);
			}
			if (this.ToolButton(ref x, ref y, 1f, "+"))
			{
				AudioUtility.SetVolume("Music_VolumeControl", Mathf.Clamp01(AudioUtility.GetVolume("Music_VolumeControl") + 0.1f), true);
			}
			if (this.ToolButton(ref x, ref y, 1f, "-"))
			{
				AudioUtility.SetVolume("Music_VolumeControl", Mathf.Clamp01(AudioUtility.GetVolume("Music_VolumeControl") - 0.1f), true);
			}
		}

		// Token: 0x06013EEB RID: 81643 RVA: 0x005140AC File Offset: 0x005122AC
		private void GUITouchToggle(ref int x, ref int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUITouchToggleInt32_Int32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_GUITouchToggle_Int32_Int32(this, this.m_GUITouchToggleInt32_Int32__hotfix, ref x, ref y);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isShowTouches = this.ToolToggle(ref x, ref y, 2.5f, "Touch", this.m_isShowTouches);
			if (this.m_isShowTouches)
			{
				this.GUITouch();
			}
		}

		// Token: 0x06013EEC RID: 81644 RVA: 0x00514130 File Offset: 0x00512330
		private void GUIMultiTouchToggle(ref int x, ref int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUIMultiTouchToggleInt32_Int32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_GUIMultiTouchToggle_Int32_Int32(this, this.m_GUIMultiTouchToggleInt32_Int32__hotfix, ref x, ref y);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Input.multiTouchEnabled = this.ToolToggle(ref x, ref y, 3f, "MTouch", Input.multiTouchEnabled);
		}

		// Token: 0x06013EED RID: 81645 RVA: 0x005141A0 File Offset: 0x005123A0
		private void GUIResolutionToggle(ref int x, ref int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUIResolutionToggleInt32_Int32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_GUIResolutionToggle_Int32_Int32(this, this.m_GUIResolutionToggleInt32_Int32__hotfix, ref x, ref y);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_initScreenWidth;
			int num2 = this.m_initScreenHeight;
			bool isLowResolution = this.m_isLowResolution;
			int num3 = (!this.m_isLowResolution) ? num : (num / 2);
			int num4 = (!this.m_isLowResolution) ? num2 : (num2 / 2);
			this.m_isLowResolution = this.ToolToggle(ref x, ref y, 2.5f, num3 + "\nx" + num4, isLowResolution);
			if (this.m_isLowResolution != isLowResolution)
			{
				if (this.m_isLowResolution)
				{
					num /= 2;
					num2 /= 2;
				}
				Screen.SetResolution(num, num2, Screen.fullScreen);
			}
		}

		// Token: 0x06013EEE RID: 81646 RVA: 0x0051428C File Offset: 0x0051248C
		private void GUIFrameRateToggle(ref int x, ref int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUIFrameRateToggleInt32_Int32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_GUIFrameRateToggle_Int32_Int32(this, this.m_GUIFrameRateToggleInt32_Int32__hotfix, ref x, ref y);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool isFrameRateLimit = this.m_isFrameRateLimit;
			this.m_isFrameRateLimit = this.ToolToggle(ref x, ref y, 2.5f, ((!this.m_isFrameRateLimit) ? 60 : 30).ToString(), isFrameRateLimit);
			if (this.m_isFrameRateLimit != isFrameRateLimit)
			{
				int targetFrameRate = (!this.m_isFrameRateLimit) ? 60 : 30;
				Application.targetFrameRate = targetFrameRate;
			}
		}

		// Token: 0x06013EEF RID: 81647 RVA: 0x00514344 File Offset: 0x00512544
		private void GUITimeToggle(ref int x, ref int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUITimeToggleInt32_Int32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_GUITimeToggle_Int32_Int32(this, this.m_GUITimeToggleInt32_Int32__hotfix, ref x, ref y);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isShowTime = this.ToolToggle(ref x, ref y, 2.5f, "Time", this.m_isShowTime);
			if (this.m_isShowTime)
			{
				int x2 = this.m_unit * 5;
				int num = this.m_unit * 5;
				this.TextLine(x2, ref num, string.Format("Time.time {0}", Time.time));
				this.TextLine(x2, ref num, string.Format("Time.unscaledTime {0}", Time.unscaledTime));
				this.TextLine(x2, ref num, string.Format("Time.realtimeSinceStartup {0}", Time.realtimeSinceStartup));
				this.TextLine(x2, ref num, string.Format("Time.timeSinceLevelLoad {0}", Time.timeSinceLevelLoad));
				this.TextLine(x2, ref num, string.Format("Time.deltaTime {0}", Time.deltaTime));
				this.TextLine(x2, ref num, string.Format("Time.unscaledDeltaTime {0}", Time.unscaledDeltaTime));
				this.TextLine(x2, ref num, string.Format("Time.smoothDeltaTime {0}", Time.smoothDeltaTime));
				this.TextLine(x2, ref num, string.Format("Time.timeScale {0}", Time.timeScale));
				this.TextLine(x2, ref num, string.Format("DateTime.Now {0}", DateTime.Now));
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				if (projectLPlayerContext != null)
				{
					this.TextLine(x2, ref num, string.Format("PlayerContext.GetServerTime {0}", projectLPlayerContext.GetServerTime()));
				}
			}
		}

		// Token: 0x06013EF0 RID: 81648 RVA: 0x0051450C File Offset: 0x0051270C
		private void GUIMemoryToggle(ref int x, ref int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUIMemoryToggleInt32_Int32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_GUIMemoryToggle_Int32_Int32(this, this.m_GUIMemoryToggleInt32_Int32__hotfix, ref x, ref y);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isShowMemory = this.ToolToggle(ref x, ref y, 2.5f, "Mem", this.m_isShowMemory);
			if (this.m_isShowMemory)
			{
				int x2 = this.m_unit * 5;
				int num = this.m_unit * 5;
				float num2 = 9.536743E-07f;
				this.TextLine(x2, ref num, string.Format("MonoHeapSize {0:f2} MB", (float)Profiler.GetMonoHeapSizeLong() * num2));
				this.TextLine(x2, ref num, string.Format("MonoUsedSize {0:f2} MB", (float)Profiler.GetMonoUsedSizeLong() * num2));
				this.TextLine(x2, ref num, string.Format("TotalAllocatedMemory {0:f2} MB", (float)Profiler.GetTotalAllocatedMemoryLong() * num2));
				this.TextLine(x2, ref num, string.Format("TotalReservedMemory {0:f2} MB", (float)Profiler.GetTotalReservedMemoryLong() * num2));
			}
		}

		// Token: 0x06013EF1 RID: 81649 RVA: 0x00514624 File Offset: 0x00512824
		private void GUILowMemoryTest(ref int x, ref int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUILowMemoryTestInt32_Int32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_GUILowMemoryTest_Int32_Int32(this, this.m_GUILowMemoryTestInt32_Int32__hotfix, ref x, ref y);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.ToolButton(ref x, ref y, 3f, "LoMem"))
			{
				AssetUtility.Instance.TestMemoryWarning();
			}
		}

		// Token: 0x06013EF2 RID: 81650 RVA: 0x0051469C File Offset: 0x0051289C
		private void GUIGMCommandToggle(ref int x, ref int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUIGMCommandToggleInt32_Int32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_GUIGMCommandToggle_Int32_Int32(this, this.m_GUIGMCommandToggleInt32_Int32__hotfix, ref x, ref y);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isShowGMCommand = this.ToolToggle(ref x, ref y, 2.5f, "Cmd", this.m_isShowGMCommand);
			if (this.m_isShowGMCommand)
			{
				this.GUIGMCommand(ref x, ref y);
			}
		}

		// Token: 0x06013EF3 RID: 81651 RVA: 0x00514724 File Offset: 0x00512924
		private void GUIGMCommand(ref int x, ref int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUIGMCommandInt32_Int32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_TestUI_GUIGMCommand_Int32_Int32(this, this.m_GUIGMCommandInt32_Int32__hotfix, ref x, ref y);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_GMCommandStr = GUI.TextField(new Rect((float)x, (float)y, (float)(this.m_unit * 14), (float)(this.m_unit * 2)), this.m_GMCommandStr, this.m_textFieldStyle);
			x += this.m_unit * 14;
			if (this.ToolButton(ref x, ref y, 3f, "Send") && !string.IsNullOrEmpty(this.m_GMCommandStr))
			{
				TestUI.SendGMCommand(this.m_GMCommandStr);
				this.m_GMCommandStr = string.Empty;
			}
		}

		// Token: 0x06013EF4 RID: 81652 RVA: 0x005147F8 File Offset: 0x005129F8
		private void LogResources()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LogResources_hotfix != null)
			{
				this.m_LogResources_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			float num9 = 9.536743E-07f;
			List<TestUI.ObjectAndSize> list = new List<TestUI.ObjectAndSize>();
			foreach (UnityEngine.Object @object in Resources.FindObjectsOfTypeAll<UnityEngine.Object>())
			{
				int num10 = 0;
				num7++;
				num8 += num10;
				bool flag = false;
				if (num10 >= 262144)
				{
					flag = true;
				}
				if (@object as Texture != null)
				{
					if (@object as RenderTexture == null)
					{
						num++;
						num2 += num10;
					}
				}
				else if (@object as Mesh != null)
				{
					num3++;
					num4 += num10;
				}
				else if (@object as Material != null)
				{
					num5++;
					num6 += num10;
				}
				else if (@object as GameObject != null && @object.name.Contains("UIPrefab"))
				{
					flag = true;
				}
				if (flag)
				{
					TestUI.ObjectAndSize item = new TestUI.ObjectAndSize
					{
						m_object = @object,
						m_size = num10
					};
					list.Add(item);
				}
			}
			List<TestUI.ObjectAndSize> list2 = list;
			if (TestUI.<>f__mg$cache0 == null)
			{
				TestUI.<>f__mg$cache0 = new Comparison<TestUI.ObjectAndSize>(TestUI.CompareObjectRuntimeMemroySize);
			}
			list2.Sort(TestUI.<>f__mg$cache0);
			foreach (TestUI.ObjectAndSize objectAndSize in list)
			{
				Texture2D texture2D = objectAndSize.m_object as Texture2D;
				if (texture2D != null)
				{
					global::Debug.Log(string.Format("{0} {1}x{2} {3} {4:f3} MB", new object[]
					{
						texture2D.name,
						texture2D.width,
						texture2D.height,
						texture2D.format,
						(float)objectAndSize.m_size * num9
					}));
				}
				else
				{
					global::Debug.Log(string.Format("{0} {1:f3} MB", objectAndSize.m_object.ToString(), (float)objectAndSize.m_size * num9));
				}
			}
			global::Debug.Log(string.Format("Texture {0} / {1:f2} MB", num, (float)num2 * num9));
			global::Debug.Log(string.Format("Mesh {0} / {1:f2} MB", num3, (float)num4 * num9));
			global::Debug.Log(string.Format("Material {0} / {1:f2} MB", num5, (float)num6 * num9));
			global::Debug.Log(string.Format("Object {0} / {1:f2} MB", num7, (float)num8 * num9));
		}

		// Token: 0x06013EF5 RID: 81653 RVA: 0x00514B28 File Offset: 0x00512D28
		private static int CompareObjectRuntimeMemroySize(TestUI.ObjectAndSize os1, TestUI.ObjectAndSize os2)
		{
			return os2.m_size - os1.m_size;
		}

		// Token: 0x06013EF6 RID: 81654 RVA: 0x00514B3C File Offset: 0x00512D3C
		private Vector3 GridPositionToScreenPosition(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GridPositionToScreenPositionGridPosition_hotfix != null)
			{
				return (Vector3)this.m_GridPositionToScreenPositionGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Camera camera = this.m_clientBattle.BattleCamera.Camera;
			if (camera != null)
			{
				Vector2 v = this.m_clientBattle.GridPositionToWorldPosition(p);
				Vector2 v2 = camera.WorldToScreenPoint(v);
				v2.y = (float)Screen.height - v2.y;
				return v2;
			}
			return Vector3.zero;
		}

		// Token: 0x06013EF7 RID: 81655 RVA: 0x00514C18 File Offset: 0x00512E18
		private void GUIBattleActor(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUIBattleActorBattleActor_hotfix != null)
			{
				this.m_GUIBattleActorBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actor == null)
			{
				return;
			}
			Vector3 vector = this.GridPositionToScreenPosition(actor.Position);
			vector.y += (float)this.m_unit * 1.5f;
			string text = actor.Id.ToString();
			if (actor.HeroInfo != null)
			{
				text = text + "_" + actor.HeroInfo.ID;
			}
			GUI.Label(new Rect(vector.x, vector.y, (float)(this.m_unit * 10), (float)this.m_unit), text, this.m_textStyleSmall);
		}

		// Token: 0x06013EF8 RID: 81656 RVA: 0x00514D24 File Offset: 0x00512F24
		private void GUIBattleActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUIBattleActors_hotfix != null)
			{
				this.m_GUIBattleActors_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < 2; i++)
			{
				BattleTeam team = this.m_clientBattle.Battle.GetTeam(i);
				foreach (BattleActor battleActor in team.GetActors())
				{
					if (!battleActor.IsDeadOrRetreat())
					{
						this.GUIBattleActor(battleActor);
					}
				}
			}
		}

		// Token: 0x06013EF9 RID: 81657 RVA: 0x00514E04 File Offset: 0x00513004
		private void GUIBattleMap()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUIBattleMap_hotfix != null)
			{
				this.m_GUIBattleMap_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleMap map = this.m_clientBattle.Battle.Map;
			Color textColor = this.m_textStyleSmall.normal.textColor;
			for (int i = 0; i < map.Height; i++)
			{
				for (int j = 0; j < map.Width; j++)
				{
					GridPosition p = new GridPosition(j, i);
					Vector3 vector = this.GridPositionToScreenPosition(p);
					vector.x -= (float)this.m_unit;
					ConfigDataTerrainInfo terrain = map.GetTerrain(p);
					if (terrain != null)
					{
						this.m_textStyleSmall.normal.textColor = new Color((float)terrain.ColorR / 255f, (float)terrain.ColorG / 255f, (float)terrain.ColorB / 255f);
						GUI.Label(new Rect(vector.x, vector.y, (float)(this.m_unit * 2), (float)this.m_unit), terrain.Name, this.m_textStyleSmall);
					}
					else
					{
						this.m_textStyleSmall.normal.textColor = Color.black;
					}
					GUI.Label(new Rect(vector.x, vector.y - (float)this.m_unit, (float)(this.m_unit * 3), (float)this.m_unit), p.ToString(), this.m_textStyleSmall);
				}
			}
			this.m_textStyleSmall.normal.textColor = textColor;
		}

		// Token: 0x06013EFA RID: 81658 RVA: 0x00514FD0 File Offset: 0x005131D0
		private void GUITouch()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUITouch_hotfix != null)
			{
				this.m_GUITouch_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_unit * 4;
			int num2 = this.m_unit * 4;
			GUI.Label(new Rect((float)num, (float)num2, (float)(this.m_unit * 20), (float)this.m_unit), "Touch pressure supported " + Input.touchPressureSupported, this.m_textStyle);
			num2 += this.m_unit * 2;
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				string text = string.Format("Touch {0} ({1:f2},{2:f2})", touch.fingerId, touch.position.x, touch.position.y);
				GUI.Label(new Rect((float)num, (float)num2, (float)(this.m_unit * 10), (float)this.m_unit), text, this.m_textStyle);
				text = string.Format(" pressure {0:f2} / {1:f2}", touch.pressure, touch.maximumPossiblePressure);
				GUI.Label(new Rect((float)(num + this.m_unit * 10), (float)num2, (float)(this.m_unit * 10), (float)this.m_unit), text, this.m_textStyle);
				num2 += this.m_unit;
			}
		}

		// Token: 0x06013EFB RID: 81659 RVA: 0x0051516C File Offset: 0x0051336C
		private Vector3 CombatPositionToScreenPosition(Vector2i p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CombatPositionToScreenPositionVector2i_hotfix != null)
			{
				return (Vector3)this.m_CombatPositionToScreenPositionVector2i_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Camera camera = this.m_clientBattle.CombatCamera.Camera;
			if (camera != null)
			{
				Vector3 position = this.m_clientBattle.CombatPositionToWorldPosition(p, Fix64.Zero, false);
				Vector3 result = camera.WorldToScreenPoint(position);
				result.y = (float)Screen.height - result.y;
				return result;
			}
			return Vector3.zero;
		}

		// Token: 0x06013EFC RID: 81660 RVA: 0x0051523C File Offset: 0x0051343C
		private void GUICombatActor(CombatActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUICombatActorCombatActor_hotfix != null)
			{
				this.m_GUICombatActorCombatActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return;
			}
			Vector3 vector = this.CombatPositionToScreenPosition(a.Position);
			GUI.Label(new Rect(vector.x, vector.y, (float)(this.m_unit * 2), (float)this.m_unit), a.Id.ToString(), this.m_textStyleSmall);
		}

		// Token: 0x06013EFD RID: 81661 RVA: 0x00515304 File Offset: 0x00513504
		private void GUICombatActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GUICombatActors_hotfix != null)
			{
				this.m_GUICombatActors_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < 2; i++)
			{
				CombatTeam team = this.m_clientBattle.Battle.Combat.GetTeam(i);
				foreach (CombatActor a in team.GetActors())
				{
					this.GUICombatActor(a);
				}
			}
		}

		// Token: 0x06013EFE RID: 81662 RVA: 0x005153DC File Offset: 0x005135DC
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ComputeFps();
		}

		// Token: 0x06013EFF RID: 81663 RVA: 0x00515444 File Offset: 0x00513644
		private void TestMemoryWarnning()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestMemoryWarnning_hotfix != null)
			{
				this.m_TestMemoryWarnning_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (Time.unscaledTime >= this.m_lastMemoryWarningTime)
			{
				if (AssetUtility.Instance != null)
				{
					AssetUtility.Instance.TestMemoryWarning();
				}
				this.m_lastMemoryWarningTime = Time.unscaledTime + 0.5f;
			}
		}

		// Token: 0x06013F00 RID: 81664 RVA: 0x005154DC File Offset: 0x005136DC
		private void ComputeFps()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeFps_hotfix != null)
			{
				this.m_ComputeFps_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_updateCount++;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			float num = realtimeSinceStartup - this.m_lastFpsResetTime;
			if (num > 0.25f)
			{
				this.m_fps = (float)this.m_updateCount / num;
				this.m_updateCount = 0;
				this.m_lastFpsResetTime = realtimeSinceStartup;
			}
		}

		// Token: 0x06013F01 RID: 81665 RVA: 0x00515584 File Offset: 0x00513784
		private void UpdateTestUIBackground()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateTestUIBackground_hotfix != null)
			{
				this.m_UpdateTestUIBackground_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController instance = CommonUIController.Instance;
			if (instance != null)
			{
				instance.ShowTestUIBackground(this.m_isShowTestToolToggle, this.m_isShowTestToolBar);
			}
		}

		// Token: 0x06013F02 RID: 81666 RVA: 0x00515608 File Offset: 0x00513808
		private void OnGUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGUI_hotfix != null)
			{
				this.m_OnGUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool isDeveloper = LocalConfig.Instance.Data.IsDeveloper;
			if (isDeveloper != this.m_isShowTestToolToggle)
			{
				this.m_isShowTestToolToggle = isDeveloper;
				this.UpdateTestUIBackground();
			}
			if (!isDeveloper)
			{
				return;
			}
			int num = Screen.width / 50;
			if (num != this.m_unit)
			{
				this.m_unit = num;
				this.m_buttonStyle = new GUIStyle(GUI.skin.button);
				this.m_buttonStyle.fontSize = this.m_unit * 7 / 8;
				this.m_buttonStyle.padding = new RectOffset();
				this.m_textFieldStyle = new GUIStyle(GUI.skin.textField);
				this.m_textFieldStyle.fontSize = this.m_unit * 7 / 8;
				this.m_textFieldStyle.padding = new RectOffset();
				this.m_textStyle = new GUIStyle(GUI.skin.label);
				this.m_textStyle.normal.textColor = Color.white;
				this.m_textStyle.fontSize = this.m_unit * 7 / 8;
				this.m_textStyle.padding = new RectOffset();
				this.m_textStyleSmall = new GUIStyle(GUI.skin.label);
				this.m_textStyleSmall.normal.textColor = Color.white;
				this.m_textStyleSmall.fontSize = this.m_unit * 7 / 10;
				this.m_textStyleSmall.padding = new RectOffset();
			}
			if (this.m_clientBattle != null)
			{
				this.GUIBattleTestTools();
				if (this.m_clientBattle.EnableDebugDraw)
				{
					if (this.m_clientBattle.State == ClientBattleState.Combat)
					{
						this.GUICombatActors();
					}
					else
					{
						this.GUIBattleMap();
						this.GUIBattleActors();
					}
				}
			}
			else if (this.m_clientWorld != null)
			{
				this.GUIWorldTestTools();
			}
		}

		// Token: 0x06013F03 RID: 81667 RVA: 0x00515828 File Offset: 0x00513A28
		private static bool PreProcessGMCommand(string cmd)
		{
			if (cmd.ToLower() == "debugview")
			{
				DebugConsoleView.instance.IsSwitchOn = !DebugConsoleView.instance.IsSwitchOn;
				return true;
			}
			return false;
		}

		// Token: 0x06013F04 RID: 81668 RVA: 0x0051585C File Offset: 0x00513A5C
		public static void SendGMCommand(string cmd)
		{
			if (!LoginUITask.IsGMUser)
			{
				return;
			}
			if (string.IsNullOrEmpty(cmd))
			{
				return;
			}
			if (TestUI.PreProcessGMCommand(cmd))
			{
				return;
			}
			GmCommandNetTask gmCommandNetTask = new GmCommandNetTask(cmd);
			gmCommandNetTask.EventOnStop += delegate(Task task)
			{
				GmCommandNetTask gmCommandNetTask2 = task as GmCommandNetTask;
				if (gmCommandNetTask2.Result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(gmCommandNetTask2.Result, 2f, null, true);
				}
			};
			gmCommandNetTask.Start(null);
		}

		// Token: 0x14000461 RID: 1121
		// (add) Token: 0x06013F05 RID: 81669 RVA: 0x005158C0 File Offset: 0x00513AC0
		// (remove) Token: 0x06013F06 RID: 81670 RVA: 0x0051595C File Offset: 0x00513B5C
		public event Action EventOnExitBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnExitBattleAction_hotfix != null)
				{
					this.m_add_EventOnExitBattleAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnExitBattle;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnExitBattle, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnExitBattleAction_hotfix != null)
				{
					this.m_remove_EventOnExitBattleAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnExitBattle;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnExitBattle, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000462 RID: 1122
		// (add) Token: 0x06013F07 RID: 81671 RVA: 0x005159F8 File Offset: 0x00513BF8
		// (remove) Token: 0x06013F08 RID: 81672 RVA: 0x00515A94 File Offset: 0x00513C94
		public event Action EventOnRestartBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRestartBattleAction_hotfix != null)
				{
					this.m_add_EventOnRestartBattleAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRestartBattle;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRestartBattle, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRestartBattleAction_hotfix != null)
				{
					this.m_remove_EventOnRestartBattleAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRestartBattle;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRestartBattle, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000463 RID: 1123
		// (add) Token: 0x06013F09 RID: 81673 RVA: 0x00515B30 File Offset: 0x00513D30
		// (remove) Token: 0x06013F0A RID: 81674 RVA: 0x00515BCC File Offset: 0x00513DCC
		public event Action EventOnReplayBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReplayBattleAction_hotfix != null)
				{
					this.m_add_EventOnReplayBattleAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReplayBattle;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReplayBattle, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReplayBattleAction_hotfix != null)
				{
					this.m_remove_EventOnReplayBattleAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReplayBattle;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReplayBattle, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000464 RID: 1124
		// (add) Token: 0x06013F0B RID: 81675 RVA: 0x00515C68 File Offset: 0x00513E68
		// (remove) Token: 0x06013F0C RID: 81676 RVA: 0x00515D04 File Offset: 0x00513F04
		public event Action<bool> EventOnStopBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStopBattleAction`1_hotfix != null)
				{
					this.m_add_EventOnStopBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnStopBattle;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnStopBattle, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStopBattleAction`1_hotfix != null)
				{
					this.m_remove_EventOnStopBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnStopBattle;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnStopBattle, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003B81 RID: 15233
		// (get) Token: 0x06013F0D RID: 81677 RVA: 0x00515DA0 File Offset: 0x00513FA0
		// (set) Token: 0x06013F0E RID: 81678 RVA: 0x00515DC0 File Offset: 0x00513FC0
		[DoNotToLua]
		public TestUI.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TestUI.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013F0F RID: 81679 RVA: 0x00515DCC File Offset: 0x00513FCC
		private void __callDele_EventOnExitBattle()
		{
			Action eventOnExitBattle = this.EventOnExitBattle;
			if (eventOnExitBattle != null)
			{
				eventOnExitBattle();
			}
		}

		// Token: 0x06013F10 RID: 81680 RVA: 0x00515DEC File Offset: 0x00513FEC
		private void __clearDele_EventOnExitBattle()
		{
			this.EventOnExitBattle = null;
		}

		// Token: 0x06013F11 RID: 81681 RVA: 0x00515DF8 File Offset: 0x00513FF8
		private void __callDele_EventOnRestartBattle()
		{
			Action eventOnRestartBattle = this.EventOnRestartBattle;
			if (eventOnRestartBattle != null)
			{
				eventOnRestartBattle();
			}
		}

		// Token: 0x06013F12 RID: 81682 RVA: 0x00515E18 File Offset: 0x00514018
		private void __clearDele_EventOnRestartBattle()
		{
			this.EventOnRestartBattle = null;
		}

		// Token: 0x06013F13 RID: 81683 RVA: 0x00515E24 File Offset: 0x00514024
		private void __callDele_EventOnReplayBattle()
		{
			Action eventOnReplayBattle = this.EventOnReplayBattle;
			if (eventOnReplayBattle != null)
			{
				eventOnReplayBattle();
			}
		}

		// Token: 0x06013F14 RID: 81684 RVA: 0x00515E44 File Offset: 0x00514044
		private void __clearDele_EventOnReplayBattle()
		{
			this.EventOnReplayBattle = null;
		}

		// Token: 0x06013F15 RID: 81685 RVA: 0x00515E50 File Offset: 0x00514050
		private void __callDele_EventOnStopBattle(bool obj)
		{
			Action<bool> eventOnStopBattle = this.EventOnStopBattle;
			if (eventOnStopBattle != null)
			{
				eventOnStopBattle(obj);
			}
		}

		// Token: 0x06013F16 RID: 81686 RVA: 0x00515E74 File Offset: 0x00514074
		private void __clearDele_EventOnStopBattle(bool obj)
		{
			this.EventOnStopBattle = null;
		}

		// Token: 0x06013F18 RID: 81688 RVA: 0x00515EBC File Offset: 0x005140BC
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_Awake_hotfix = (luaObj.RawGet("Awake") as LuaFunction);
					this.m_InitializeBattleClientBattle_hotfix = (luaObj.RawGet("InitializeBattle") as LuaFunction);
					this.m_UninitializeBattle_hotfix = (luaObj.RawGet("UninitializeBattle") as LuaFunction);
					this.m_InitializeWorldClientWorld_hotfix = (luaObj.RawGet("InitializeWorld") as LuaFunction);
					this.m_UninitializeWorld_hotfix = (luaObj.RawGet("UninitializeWorld") as LuaFunction);
					this.m_SetTimeScaleSingle_hotfix = (luaObj.RawGet("SetTimeScale") as LuaFunction);
					this.m_ToolButtonInt32_Int32_SingleString_hotfix = (luaObj.RawGet("ToolButton") as LuaFunction);
					this.m_ToolToggleInt32_Int32_SingleStringBoolean_hotfix = (luaObj.RawGet("ToolToggle") as LuaFunction);
					this.m_TextLineInt32Int32_String_hotfix = (luaObj.RawGet("TextLine") as LuaFunction);
					this.m_GUIBattleTestTools_hotfix = (luaObj.RawGet("GUIBattleTestTools") as LuaFunction);
					this.m_GUIWorldTestTools_hotfix = (luaObj.RawGet("GUIWorldTestTools") as LuaFunction);
					this.m_GUIGMReloginButtonInt32_Int32__hotfix = (luaObj.RawGet("GUIGMReloginButton") as LuaFunction);
					this.m_GUIToolToggleInt32_Int32__hotfix = (luaObj.RawGet("GUIToolToggle") as LuaFunction);
					this.m_GUISpeedToggleInt32_Int32__hotfix = (luaObj.RawGet("GUISpeedToggle") as LuaFunction);
					this.m_GUIAudioToggleInt32_Int32__hotfix = (luaObj.RawGet("GUIAudioToggle") as LuaFunction);
					this.m_GUITouchToggleInt32_Int32__hotfix = (luaObj.RawGet("GUITouchToggle") as LuaFunction);
					this.m_GUIMultiTouchToggleInt32_Int32__hotfix = (luaObj.RawGet("GUIMultiTouchToggle") as LuaFunction);
					this.m_GUIResolutionToggleInt32_Int32__hotfix = (luaObj.RawGet("GUIResolutionToggle") as LuaFunction);
					this.m_GUIFrameRateToggleInt32_Int32__hotfix = (luaObj.RawGet("GUIFrameRateToggle") as LuaFunction);
					this.m_GUITimeToggleInt32_Int32__hotfix = (luaObj.RawGet("GUITimeToggle") as LuaFunction);
					this.m_GUIMemoryToggleInt32_Int32__hotfix = (luaObj.RawGet("GUIMemoryToggle") as LuaFunction);
					this.m_GUILowMemoryTestInt32_Int32__hotfix = (luaObj.RawGet("GUILowMemoryTest") as LuaFunction);
					this.m_GUIGMCommandToggleInt32_Int32__hotfix = (luaObj.RawGet("GUIGMCommandToggle") as LuaFunction);
					this.m_GUIGMCommandInt32_Int32__hotfix = (luaObj.RawGet("GUIGMCommand") as LuaFunction);
					this.m_LogResources_hotfix = (luaObj.RawGet("LogResources") as LuaFunction);
					this.m_GridPositionToScreenPositionGridPosition_hotfix = (luaObj.RawGet("GridPositionToScreenPosition") as LuaFunction);
					this.m_GUIBattleActorBattleActor_hotfix = (luaObj.RawGet("GUIBattleActor") as LuaFunction);
					this.m_GUIBattleActors_hotfix = (luaObj.RawGet("GUIBattleActors") as LuaFunction);
					this.m_GUIBattleMap_hotfix = (luaObj.RawGet("GUIBattleMap") as LuaFunction);
					this.m_GUITouch_hotfix = (luaObj.RawGet("GUITouch") as LuaFunction);
					this.m_CombatPositionToScreenPositionVector2i_hotfix = (luaObj.RawGet("CombatPositionToScreenPosition") as LuaFunction);
					this.m_GUICombatActorCombatActor_hotfix = (luaObj.RawGet("GUICombatActor") as LuaFunction);
					this.m_GUICombatActors_hotfix = (luaObj.RawGet("GUICombatActors") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_TestMemoryWarnning_hotfix = (luaObj.RawGet("TestMemoryWarnning") as LuaFunction);
					this.m_ComputeFps_hotfix = (luaObj.RawGet("ComputeFps") as LuaFunction);
					this.m_UpdateTestUIBackground_hotfix = (luaObj.RawGet("UpdateTestUIBackground") as LuaFunction);
					this.m_OnGUI_hotfix = (luaObj.RawGet("OnGUI") as LuaFunction);
					this.m_add_EventOnExitBattleAction_hotfix = (luaObj.RawGet("add_EventOnExitBattle") as LuaFunction);
					this.m_remove_EventOnExitBattleAction_hotfix = (luaObj.RawGet("remove_EventOnExitBattle") as LuaFunction);
					this.m_add_EventOnRestartBattleAction_hotfix = (luaObj.RawGet("add_EventOnRestartBattle") as LuaFunction);
					this.m_remove_EventOnRestartBattleAction_hotfix = (luaObj.RawGet("remove_EventOnRestartBattle") as LuaFunction);
					this.m_add_EventOnReplayBattleAction_hotfix = (luaObj.RawGet("add_EventOnReplayBattle") as LuaFunction);
					this.m_remove_EventOnReplayBattleAction_hotfix = (luaObj.RawGet("remove_EventOnReplayBattle") as LuaFunction);
					this.m_add_EventOnStopBattleAction`1_hotfix = (luaObj.RawGet("add_EventOnStopBattle") as LuaFunction);
					this.m_remove_EventOnStopBattleAction`1_hotfix = (luaObj.RawGet("remove_EventOnStopBattle") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013F19 RID: 81689 RVA: 0x005163EC File Offset: 0x005145EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TestUI));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B00C RID: 45068
		private ClientBattle m_clientBattle;

		// Token: 0x0400B00D RID: 45069
		private ClientWorld m_clientWorld;

		// Token: 0x0400B00E RID: 45070
		private int m_updateCount;

		// Token: 0x0400B00F RID: 45071
		private float m_fps;

		// Token: 0x0400B010 RID: 45072
		private float m_lastFpsResetTime;

		// Token: 0x0400B011 RID: 45073
		private float m_lastMemoryWarningTime;

		// Token: 0x0400B012 RID: 45074
		private float m_timeScale = 1f;

		// Token: 0x0400B013 RID: 45075
		private bool m_isTimePaused;

		// Token: 0x0400B014 RID: 45076
		private bool m_isShowTestToolToggle;

		// Token: 0x0400B015 RID: 45077
		private bool m_isShowTestToolBar;

		// Token: 0x0400B016 RID: 45078
		private bool m_isShowTouches;

		// Token: 0x0400B017 RID: 45079
		private bool m_isLowResolution;

		// Token: 0x0400B018 RID: 45080
		private bool m_isFrameRateLimit;

		// Token: 0x0400B019 RID: 45081
		private bool m_isShowTime;

		// Token: 0x0400B01A RID: 45082
		private bool m_isShowMemory;

		// Token: 0x0400B01B RID: 45083
		private bool m_isShowGMCommand;

		// Token: 0x0400B01C RID: 45084
		private int m_initScreenWidth;

		// Token: 0x0400B01D RID: 45085
		private int m_initScreenHeight;

		// Token: 0x0400B01E RID: 45086
		private string m_GMCommandStr = string.Empty;

		// Token: 0x0400B01F RID: 45087
		private int m_unit;

		// Token: 0x0400B020 RID: 45088
		private GUIStyle m_buttonStyle;

		// Token: 0x0400B021 RID: 45089
		private GUIStyle m_textFieldStyle;

		// Token: 0x0400B022 RID: 45090
		private GUIStyle m_textStyle;

		// Token: 0x0400B023 RID: 45091
		private GUIStyle m_textStyleSmall;

		// Token: 0x0400B024 RID: 45092
		[DoNotToLua]
		private TestUI.LuaExportHelper luaExportHelper;

		// Token: 0x0400B025 RID: 45093
		[CompilerGenerated]
		private static Comparison<TestUI.ObjectAndSize> <>f__mg$cache0;

		// Token: 0x0400B027 RID: 45095
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B028 RID: 45096
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B029 RID: 45097
		private LuaFunction m_Awake_hotfix;

		// Token: 0x0400B02A RID: 45098
		private LuaFunction m_InitializeBattleClientBattle_hotfix;

		// Token: 0x0400B02B RID: 45099
		private LuaFunction m_UninitializeBattle_hotfix;

		// Token: 0x0400B02C RID: 45100
		private LuaFunction m_InitializeWorldClientWorld_hotfix;

		// Token: 0x0400B02D RID: 45101
		private LuaFunction m_UninitializeWorld_hotfix;

		// Token: 0x0400B02E RID: 45102
		private LuaFunction m_SetTimeScaleSingle_hotfix;

		// Token: 0x0400B02F RID: 45103
		private LuaFunction m_ToolButtonInt32_Int32_SingleString_hotfix;

		// Token: 0x0400B030 RID: 45104
		private LuaFunction m_ToolToggleInt32_Int32_SingleStringBoolean_hotfix;

		// Token: 0x0400B031 RID: 45105
		private LuaFunction m_TextLineInt32Int32_String_hotfix;

		// Token: 0x0400B032 RID: 45106
		private LuaFunction m_GUIBattleTestTools_hotfix;

		// Token: 0x0400B033 RID: 45107
		private LuaFunction m_GUIWorldTestTools_hotfix;

		// Token: 0x0400B034 RID: 45108
		private LuaFunction m_GUIGMReloginButtonInt32_Int32__hotfix;

		// Token: 0x0400B035 RID: 45109
		private LuaFunction m_GUIToolToggleInt32_Int32__hotfix;

		// Token: 0x0400B036 RID: 45110
		private LuaFunction m_GUISpeedToggleInt32_Int32__hotfix;

		// Token: 0x0400B037 RID: 45111
		private LuaFunction m_GUIAudioToggleInt32_Int32__hotfix;

		// Token: 0x0400B038 RID: 45112
		private LuaFunction m_GUITouchToggleInt32_Int32__hotfix;

		// Token: 0x0400B039 RID: 45113
		private LuaFunction m_GUIMultiTouchToggleInt32_Int32__hotfix;

		// Token: 0x0400B03A RID: 45114
		private LuaFunction m_GUIResolutionToggleInt32_Int32__hotfix;

		// Token: 0x0400B03B RID: 45115
		private LuaFunction m_GUIFrameRateToggleInt32_Int32__hotfix;

		// Token: 0x0400B03C RID: 45116
		private LuaFunction m_GUITimeToggleInt32_Int32__hotfix;

		// Token: 0x0400B03D RID: 45117
		private LuaFunction m_GUIMemoryToggleInt32_Int32__hotfix;

		// Token: 0x0400B03E RID: 45118
		private LuaFunction m_GUILowMemoryTestInt32_Int32__hotfix;

		// Token: 0x0400B03F RID: 45119
		private LuaFunction m_GUIGMCommandToggleInt32_Int32__hotfix;

		// Token: 0x0400B040 RID: 45120
		private LuaFunction m_GUIGMCommandInt32_Int32__hotfix;

		// Token: 0x0400B041 RID: 45121
		private LuaFunction m_LogResources_hotfix;

		// Token: 0x0400B042 RID: 45122
		private LuaFunction m_GridPositionToScreenPositionGridPosition_hotfix;

		// Token: 0x0400B043 RID: 45123
		private LuaFunction m_GUIBattleActorBattleActor_hotfix;

		// Token: 0x0400B044 RID: 45124
		private LuaFunction m_GUIBattleActors_hotfix;

		// Token: 0x0400B045 RID: 45125
		private LuaFunction m_GUIBattleMap_hotfix;

		// Token: 0x0400B046 RID: 45126
		private LuaFunction m_GUITouch_hotfix;

		// Token: 0x0400B047 RID: 45127
		private LuaFunction m_CombatPositionToScreenPositionVector2i_hotfix;

		// Token: 0x0400B048 RID: 45128
		private LuaFunction m_GUICombatActorCombatActor_hotfix;

		// Token: 0x0400B049 RID: 45129
		private LuaFunction m_GUICombatActors_hotfix;

		// Token: 0x0400B04A RID: 45130
		private LuaFunction m_Update_hotfix;

		// Token: 0x0400B04B RID: 45131
		private LuaFunction m_TestMemoryWarnning_hotfix;

		// Token: 0x0400B04C RID: 45132
		private LuaFunction m_ComputeFps_hotfix;

		// Token: 0x0400B04D RID: 45133
		private LuaFunction m_UpdateTestUIBackground_hotfix;

		// Token: 0x0400B04E RID: 45134
		private LuaFunction m_OnGUI_hotfix;

		// Token: 0x0400B04F RID: 45135
		private LuaFunction m_add_EventOnExitBattleAction_hotfix;

		// Token: 0x0400B050 RID: 45136
		private LuaFunction m_remove_EventOnExitBattleAction_hotfix;

		// Token: 0x0400B051 RID: 45137
		private LuaFunction m_add_EventOnRestartBattleAction_hotfix;

		// Token: 0x0400B052 RID: 45138
		private LuaFunction m_remove_EventOnRestartBattleAction_hotfix;

		// Token: 0x0400B053 RID: 45139
		private LuaFunction m_add_EventOnReplayBattleAction_hotfix;

		// Token: 0x0400B054 RID: 45140
		private LuaFunction m_remove_EventOnReplayBattleAction_hotfix;

		// Token: 0x0400B055 RID: 45141
		private LuaFunction m_add_EventOnStopBattleAction;

		// Token: 0x0400B056 RID: 45142
		private LuaFunction m_remove_EventOnStopBattleAction;

		// Token: 0x02000F8D RID: 3981
		public struct ObjectAndSize
		{
			// Token: 0x0400B057 RID: 45143
			public UnityEngine.Object m_object;

			// Token: 0x0400B058 RID: 45144
			public int m_size;
		}

		// Token: 0x02000F8E RID: 3982
		public class LuaExportHelper
		{
			// Token: 0x06013F1A RID: 81690 RVA: 0x00516454 File Offset: 0x00514654
			public LuaExportHelper(TestUI owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013F1B RID: 81691 RVA: 0x00516464 File Offset: 0x00514664
			public void __callDele_EventOnExitBattle()
			{
				this.m_owner.__callDele_EventOnExitBattle();
			}

			// Token: 0x06013F1C RID: 81692 RVA: 0x00516474 File Offset: 0x00514674
			public void __clearDele_EventOnExitBattle()
			{
				this.m_owner.__clearDele_EventOnExitBattle();
			}

			// Token: 0x06013F1D RID: 81693 RVA: 0x00516484 File Offset: 0x00514684
			public void __callDele_EventOnRestartBattle()
			{
				this.m_owner.__callDele_EventOnRestartBattle();
			}

			// Token: 0x06013F1E RID: 81694 RVA: 0x00516494 File Offset: 0x00514694
			public void __clearDele_EventOnRestartBattle()
			{
				this.m_owner.__clearDele_EventOnRestartBattle();
			}

			// Token: 0x06013F1F RID: 81695 RVA: 0x005164A4 File Offset: 0x005146A4
			public void __callDele_EventOnReplayBattle()
			{
				this.m_owner.__callDele_EventOnReplayBattle();
			}

			// Token: 0x06013F20 RID: 81696 RVA: 0x005164B4 File Offset: 0x005146B4
			public void __clearDele_EventOnReplayBattle()
			{
				this.m_owner.__clearDele_EventOnReplayBattle();
			}

			// Token: 0x06013F21 RID: 81697 RVA: 0x005164C4 File Offset: 0x005146C4
			public void __callDele_EventOnStopBattle(bool obj)
			{
				this.m_owner.__callDele_EventOnStopBattle(obj);
			}

			// Token: 0x06013F22 RID: 81698 RVA: 0x005164D4 File Offset: 0x005146D4
			public void __clearDele_EventOnStopBattle(bool obj)
			{
				this.m_owner.__clearDele_EventOnStopBattle(obj);
			}

			// Token: 0x17003B82 RID: 15234
			// (get) Token: 0x06013F23 RID: 81699 RVA: 0x005164E4 File Offset: 0x005146E4
			// (set) Token: 0x06013F24 RID: 81700 RVA: 0x005164F4 File Offset: 0x005146F4
			public ClientBattle m_clientBattle
			{
				get
				{
					return this.m_owner.m_clientBattle;
				}
				set
				{
					this.m_owner.m_clientBattle = value;
				}
			}

			// Token: 0x17003B83 RID: 15235
			// (get) Token: 0x06013F25 RID: 81701 RVA: 0x00516504 File Offset: 0x00514704
			// (set) Token: 0x06013F26 RID: 81702 RVA: 0x00516514 File Offset: 0x00514714
			public ClientWorld m_clientWorld
			{
				get
				{
					return this.m_owner.m_clientWorld;
				}
				set
				{
					this.m_owner.m_clientWorld = value;
				}
			}

			// Token: 0x17003B84 RID: 15236
			// (get) Token: 0x06013F27 RID: 81703 RVA: 0x00516524 File Offset: 0x00514724
			// (set) Token: 0x06013F28 RID: 81704 RVA: 0x00516534 File Offset: 0x00514734
			public int m_updateCount
			{
				get
				{
					return this.m_owner.m_updateCount;
				}
				set
				{
					this.m_owner.m_updateCount = value;
				}
			}

			// Token: 0x17003B85 RID: 15237
			// (get) Token: 0x06013F29 RID: 81705 RVA: 0x00516544 File Offset: 0x00514744
			// (set) Token: 0x06013F2A RID: 81706 RVA: 0x00516554 File Offset: 0x00514754
			public float m_fps
			{
				get
				{
					return this.m_owner.m_fps;
				}
				set
				{
					this.m_owner.m_fps = value;
				}
			}

			// Token: 0x17003B86 RID: 15238
			// (get) Token: 0x06013F2B RID: 81707 RVA: 0x00516564 File Offset: 0x00514764
			// (set) Token: 0x06013F2C RID: 81708 RVA: 0x00516574 File Offset: 0x00514774
			public float m_lastFpsResetTime
			{
				get
				{
					return this.m_owner.m_lastFpsResetTime;
				}
				set
				{
					this.m_owner.m_lastFpsResetTime = value;
				}
			}

			// Token: 0x17003B87 RID: 15239
			// (get) Token: 0x06013F2D RID: 81709 RVA: 0x00516584 File Offset: 0x00514784
			// (set) Token: 0x06013F2E RID: 81710 RVA: 0x00516594 File Offset: 0x00514794
			public float m_lastMemoryWarningTime
			{
				get
				{
					return this.m_owner.m_lastMemoryWarningTime;
				}
				set
				{
					this.m_owner.m_lastMemoryWarningTime = value;
				}
			}

			// Token: 0x17003B88 RID: 15240
			// (get) Token: 0x06013F2F RID: 81711 RVA: 0x005165A4 File Offset: 0x005147A4
			// (set) Token: 0x06013F30 RID: 81712 RVA: 0x005165B4 File Offset: 0x005147B4
			public float m_timeScale
			{
				get
				{
					return this.m_owner.m_timeScale;
				}
				set
				{
					this.m_owner.m_timeScale = value;
				}
			}

			// Token: 0x17003B89 RID: 15241
			// (get) Token: 0x06013F31 RID: 81713 RVA: 0x005165C4 File Offset: 0x005147C4
			// (set) Token: 0x06013F32 RID: 81714 RVA: 0x005165D4 File Offset: 0x005147D4
			public bool m_isTimePaused
			{
				get
				{
					return this.m_owner.m_isTimePaused;
				}
				set
				{
					this.m_owner.m_isTimePaused = value;
				}
			}

			// Token: 0x17003B8A RID: 15242
			// (get) Token: 0x06013F33 RID: 81715 RVA: 0x005165E4 File Offset: 0x005147E4
			// (set) Token: 0x06013F34 RID: 81716 RVA: 0x005165F4 File Offset: 0x005147F4
			public bool m_isShowTestToolToggle
			{
				get
				{
					return this.m_owner.m_isShowTestToolToggle;
				}
				set
				{
					this.m_owner.m_isShowTestToolToggle = value;
				}
			}

			// Token: 0x17003B8B RID: 15243
			// (get) Token: 0x06013F35 RID: 81717 RVA: 0x00516604 File Offset: 0x00514804
			// (set) Token: 0x06013F36 RID: 81718 RVA: 0x00516614 File Offset: 0x00514814
			public bool m_isShowTestToolBar
			{
				get
				{
					return this.m_owner.m_isShowTestToolBar;
				}
				set
				{
					this.m_owner.m_isShowTestToolBar = value;
				}
			}

			// Token: 0x17003B8C RID: 15244
			// (get) Token: 0x06013F37 RID: 81719 RVA: 0x00516624 File Offset: 0x00514824
			// (set) Token: 0x06013F38 RID: 81720 RVA: 0x00516634 File Offset: 0x00514834
			public bool m_isShowTouches
			{
				get
				{
					return this.m_owner.m_isShowTouches;
				}
				set
				{
					this.m_owner.m_isShowTouches = value;
				}
			}

			// Token: 0x17003B8D RID: 15245
			// (get) Token: 0x06013F39 RID: 81721 RVA: 0x00516644 File Offset: 0x00514844
			// (set) Token: 0x06013F3A RID: 81722 RVA: 0x00516654 File Offset: 0x00514854
			public bool m_isLowResolution
			{
				get
				{
					return this.m_owner.m_isLowResolution;
				}
				set
				{
					this.m_owner.m_isLowResolution = value;
				}
			}

			// Token: 0x17003B8E RID: 15246
			// (get) Token: 0x06013F3B RID: 81723 RVA: 0x00516664 File Offset: 0x00514864
			// (set) Token: 0x06013F3C RID: 81724 RVA: 0x00516674 File Offset: 0x00514874
			public bool m_isFrameRateLimit
			{
				get
				{
					return this.m_owner.m_isFrameRateLimit;
				}
				set
				{
					this.m_owner.m_isFrameRateLimit = value;
				}
			}

			// Token: 0x17003B8F RID: 15247
			// (get) Token: 0x06013F3D RID: 81725 RVA: 0x00516684 File Offset: 0x00514884
			// (set) Token: 0x06013F3E RID: 81726 RVA: 0x00516694 File Offset: 0x00514894
			public bool m_isShowTime
			{
				get
				{
					return this.m_owner.m_isShowTime;
				}
				set
				{
					this.m_owner.m_isShowTime = value;
				}
			}

			// Token: 0x17003B90 RID: 15248
			// (get) Token: 0x06013F3F RID: 81727 RVA: 0x005166A4 File Offset: 0x005148A4
			// (set) Token: 0x06013F40 RID: 81728 RVA: 0x005166B4 File Offset: 0x005148B4
			public bool m_isShowMemory
			{
				get
				{
					return this.m_owner.m_isShowMemory;
				}
				set
				{
					this.m_owner.m_isShowMemory = value;
				}
			}

			// Token: 0x17003B91 RID: 15249
			// (get) Token: 0x06013F41 RID: 81729 RVA: 0x005166C4 File Offset: 0x005148C4
			// (set) Token: 0x06013F42 RID: 81730 RVA: 0x005166D4 File Offset: 0x005148D4
			public bool m_isShowGMCommand
			{
				get
				{
					return this.m_owner.m_isShowGMCommand;
				}
				set
				{
					this.m_owner.m_isShowGMCommand = value;
				}
			}

			// Token: 0x17003B92 RID: 15250
			// (get) Token: 0x06013F43 RID: 81731 RVA: 0x005166E4 File Offset: 0x005148E4
			// (set) Token: 0x06013F44 RID: 81732 RVA: 0x005166F4 File Offset: 0x005148F4
			public int m_initScreenWidth
			{
				get
				{
					return this.m_owner.m_initScreenWidth;
				}
				set
				{
					this.m_owner.m_initScreenWidth = value;
				}
			}

			// Token: 0x17003B93 RID: 15251
			// (get) Token: 0x06013F45 RID: 81733 RVA: 0x00516704 File Offset: 0x00514904
			// (set) Token: 0x06013F46 RID: 81734 RVA: 0x00516714 File Offset: 0x00514914
			public int m_initScreenHeight
			{
				get
				{
					return this.m_owner.m_initScreenHeight;
				}
				set
				{
					this.m_owner.m_initScreenHeight = value;
				}
			}

			// Token: 0x17003B94 RID: 15252
			// (get) Token: 0x06013F47 RID: 81735 RVA: 0x00516724 File Offset: 0x00514924
			// (set) Token: 0x06013F48 RID: 81736 RVA: 0x00516734 File Offset: 0x00514934
			public string m_GMCommandStr
			{
				get
				{
					return this.m_owner.m_GMCommandStr;
				}
				set
				{
					this.m_owner.m_GMCommandStr = value;
				}
			}

			// Token: 0x17003B95 RID: 15253
			// (get) Token: 0x06013F49 RID: 81737 RVA: 0x00516744 File Offset: 0x00514944
			// (set) Token: 0x06013F4A RID: 81738 RVA: 0x00516754 File Offset: 0x00514954
			public int m_unit
			{
				get
				{
					return this.m_owner.m_unit;
				}
				set
				{
					this.m_owner.m_unit = value;
				}
			}

			// Token: 0x17003B96 RID: 15254
			// (get) Token: 0x06013F4B RID: 81739 RVA: 0x00516764 File Offset: 0x00514964
			// (set) Token: 0x06013F4C RID: 81740 RVA: 0x00516774 File Offset: 0x00514974
			public GUIStyle m_buttonStyle
			{
				get
				{
					return this.m_owner.m_buttonStyle;
				}
				set
				{
					this.m_owner.m_buttonStyle = value;
				}
			}

			// Token: 0x17003B97 RID: 15255
			// (get) Token: 0x06013F4D RID: 81741 RVA: 0x00516784 File Offset: 0x00514984
			// (set) Token: 0x06013F4E RID: 81742 RVA: 0x00516794 File Offset: 0x00514994
			public GUIStyle m_textFieldStyle
			{
				get
				{
					return this.m_owner.m_textFieldStyle;
				}
				set
				{
					this.m_owner.m_textFieldStyle = value;
				}
			}

			// Token: 0x17003B98 RID: 15256
			// (get) Token: 0x06013F4F RID: 81743 RVA: 0x005167A4 File Offset: 0x005149A4
			// (set) Token: 0x06013F50 RID: 81744 RVA: 0x005167B4 File Offset: 0x005149B4
			public GUIStyle m_textStyle
			{
				get
				{
					return this.m_owner.m_textStyle;
				}
				set
				{
					this.m_owner.m_textStyle = value;
				}
			}

			// Token: 0x17003B99 RID: 15257
			// (get) Token: 0x06013F51 RID: 81745 RVA: 0x005167C4 File Offset: 0x005149C4
			// (set) Token: 0x06013F52 RID: 81746 RVA: 0x005167D4 File Offset: 0x005149D4
			public GUIStyle m_textStyleSmall
			{
				get
				{
					return this.m_owner.m_textStyleSmall;
				}
				set
				{
					this.m_owner.m_textStyleSmall = value;
				}
			}

			// Token: 0x06013F53 RID: 81747 RVA: 0x005167E4 File Offset: 0x005149E4
			public void Awake()
			{
				this.m_owner.Awake();
			}

			// Token: 0x06013F54 RID: 81748 RVA: 0x005167F4 File Offset: 0x005149F4
			public void SetTimeScale(float ts)
			{
				this.m_owner.SetTimeScale(ts);
			}

			// Token: 0x06013F55 RID: 81749 RVA: 0x00516804 File Offset: 0x00514A04
			public bool ToolButton(ref int x, ref int y, float size, string text)
			{
				return this.m_owner.ToolButton(ref x, ref y, size, text);
			}

			// Token: 0x06013F56 RID: 81750 RVA: 0x00516818 File Offset: 0x00514A18
			public bool ToolToggle(ref int x, ref int y, float size, string text, bool oldValue)
			{
				return this.m_owner.ToolToggle(ref x, ref y, size, text, oldValue);
			}

			// Token: 0x06013F57 RID: 81751 RVA: 0x0051682C File Offset: 0x00514A2C
			public void TextLine(int x, ref int y, string text)
			{
				this.m_owner.TextLine(x, ref y, text);
			}

			// Token: 0x06013F58 RID: 81752 RVA: 0x0051683C File Offset: 0x00514A3C
			public void GUIBattleTestTools()
			{
				this.m_owner.GUIBattleTestTools();
			}

			// Token: 0x06013F59 RID: 81753 RVA: 0x0051684C File Offset: 0x00514A4C
			public void GUIWorldTestTools()
			{
				this.m_owner.GUIWorldTestTools();
			}

			// Token: 0x06013F5A RID: 81754 RVA: 0x0051685C File Offset: 0x00514A5C
			public void GUIGMReloginButton(ref int x, ref int y)
			{
				this.m_owner.GUIGMReloginButton(ref x, ref y);
			}

			// Token: 0x06013F5B RID: 81755 RVA: 0x0051686C File Offset: 0x00514A6C
			public void GUIToolToggle(ref int x, ref int y)
			{
				this.m_owner.GUIToolToggle(ref x, ref y);
			}

			// Token: 0x06013F5C RID: 81756 RVA: 0x0051687C File Offset: 0x00514A7C
			public void GUISpeedToggle(ref int x, ref int y)
			{
				this.m_owner.GUISpeedToggle(ref x, ref y);
			}

			// Token: 0x06013F5D RID: 81757 RVA: 0x0051688C File Offset: 0x00514A8C
			public void GUIAudioToggle(ref int x, ref int y)
			{
				this.m_owner.GUIAudioToggle(ref x, ref y);
			}

			// Token: 0x06013F5E RID: 81758 RVA: 0x0051689C File Offset: 0x00514A9C
			public void GUITouchToggle(ref int x, ref int y)
			{
				this.m_owner.GUITouchToggle(ref x, ref y);
			}

			// Token: 0x06013F5F RID: 81759 RVA: 0x005168AC File Offset: 0x00514AAC
			public void GUIMultiTouchToggle(ref int x, ref int y)
			{
				this.m_owner.GUIMultiTouchToggle(ref x, ref y);
			}

			// Token: 0x06013F60 RID: 81760 RVA: 0x005168BC File Offset: 0x00514ABC
			public void GUIResolutionToggle(ref int x, ref int y)
			{
				this.m_owner.GUIResolutionToggle(ref x, ref y);
			}

			// Token: 0x06013F61 RID: 81761 RVA: 0x005168CC File Offset: 0x00514ACC
			public void GUIFrameRateToggle(ref int x, ref int y)
			{
				this.m_owner.GUIFrameRateToggle(ref x, ref y);
			}

			// Token: 0x06013F62 RID: 81762 RVA: 0x005168DC File Offset: 0x00514ADC
			public void GUITimeToggle(ref int x, ref int y)
			{
				this.m_owner.GUITimeToggle(ref x, ref y);
			}

			// Token: 0x06013F63 RID: 81763 RVA: 0x005168EC File Offset: 0x00514AEC
			public void GUIMemoryToggle(ref int x, ref int y)
			{
				this.m_owner.GUIMemoryToggle(ref x, ref y);
			}

			// Token: 0x06013F64 RID: 81764 RVA: 0x005168FC File Offset: 0x00514AFC
			public void GUILowMemoryTest(ref int x, ref int y)
			{
				this.m_owner.GUILowMemoryTest(ref x, ref y);
			}

			// Token: 0x06013F65 RID: 81765 RVA: 0x0051690C File Offset: 0x00514B0C
			public void GUIGMCommandToggle(ref int x, ref int y)
			{
				this.m_owner.GUIGMCommandToggle(ref x, ref y);
			}

			// Token: 0x06013F66 RID: 81766 RVA: 0x0051691C File Offset: 0x00514B1C
			public void GUIGMCommand(ref int x, ref int y)
			{
				this.m_owner.GUIGMCommand(ref x, ref y);
			}

			// Token: 0x06013F67 RID: 81767 RVA: 0x0051692C File Offset: 0x00514B2C
			public void LogResources()
			{
				this.m_owner.LogResources();
			}

			// Token: 0x06013F68 RID: 81768 RVA: 0x0051693C File Offset: 0x00514B3C
			public static int CompareObjectRuntimeMemroySize(TestUI.ObjectAndSize os1, TestUI.ObjectAndSize os2)
			{
				return TestUI.CompareObjectRuntimeMemroySize(os1, os2);
			}

			// Token: 0x06013F69 RID: 81769 RVA: 0x00516948 File Offset: 0x00514B48
			public Vector3 GridPositionToScreenPosition(GridPosition p)
			{
				return this.m_owner.GridPositionToScreenPosition(p);
			}

			// Token: 0x06013F6A RID: 81770 RVA: 0x00516958 File Offset: 0x00514B58
			public void GUIBattleActor(BattleActor actor)
			{
				this.m_owner.GUIBattleActor(actor);
			}

			// Token: 0x06013F6B RID: 81771 RVA: 0x00516968 File Offset: 0x00514B68
			public void GUIBattleActors()
			{
				this.m_owner.GUIBattleActors();
			}

			// Token: 0x06013F6C RID: 81772 RVA: 0x00516978 File Offset: 0x00514B78
			public void GUIBattleMap()
			{
				this.m_owner.GUIBattleMap();
			}

			// Token: 0x06013F6D RID: 81773 RVA: 0x00516988 File Offset: 0x00514B88
			public void GUITouch()
			{
				this.m_owner.GUITouch();
			}

			// Token: 0x06013F6E RID: 81774 RVA: 0x00516998 File Offset: 0x00514B98
			public Vector3 CombatPositionToScreenPosition(Vector2i p)
			{
				return this.m_owner.CombatPositionToScreenPosition(p);
			}

			// Token: 0x06013F6F RID: 81775 RVA: 0x005169A8 File Offset: 0x00514BA8
			public void GUICombatActor(CombatActor a)
			{
				this.m_owner.GUICombatActor(a);
			}

			// Token: 0x06013F70 RID: 81776 RVA: 0x005169B8 File Offset: 0x00514BB8
			public void GUICombatActors()
			{
				this.m_owner.GUICombatActors();
			}

			// Token: 0x06013F71 RID: 81777 RVA: 0x005169C8 File Offset: 0x00514BC8
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x06013F72 RID: 81778 RVA: 0x005169D8 File Offset: 0x00514BD8
			public void TestMemoryWarnning()
			{
				this.m_owner.TestMemoryWarnning();
			}

			// Token: 0x06013F73 RID: 81779 RVA: 0x005169E8 File Offset: 0x00514BE8
			public void ComputeFps()
			{
				this.m_owner.ComputeFps();
			}

			// Token: 0x06013F74 RID: 81780 RVA: 0x005169F8 File Offset: 0x00514BF8
			public void UpdateTestUIBackground()
			{
				this.m_owner.UpdateTestUIBackground();
			}

			// Token: 0x06013F75 RID: 81781 RVA: 0x00516A08 File Offset: 0x00514C08
			public void OnGUI()
			{
				this.m_owner.OnGUI();
			}

			// Token: 0x06013F76 RID: 81782 RVA: 0x00516A18 File Offset: 0x00514C18
			public static bool PreProcessGMCommand(string cmd)
			{
				return TestUI.PreProcessGMCommand(cmd);
			}

			// Token: 0x0400B059 RID: 45145
			private TestUI m_owner;
		}
	}
}
