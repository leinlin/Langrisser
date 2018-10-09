using System;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.TaskNs
{
	// Token: 0x020000CF RID: 207
	[CustomLuaClassWithProtected]
	public class NetWorkTransactionTask : Task
	{
		// Token: 0x0600079B RID: 1947 RVA: 0x000233E0 File Offset: 0x000215E0
		public NetWorkTransactionTask(float timeout = 10f, UITaskBase blockedUITask = null, bool autoRetry = false) : base(null)
		{
			this.m_timeout = timeout;
			if ((double)this.m_timeout > 0.001)
			{
				if (Application.isEditor)
				{
					this.m_timeoutTime = new DateTime?(Timer.m_currTime.AddSeconds(60.0));
				}
				else
				{
					this.m_timeoutTime = new DateTime?(Timer.m_currTime.AddSeconds((double)this.m_timeout));
				}
			}
			this.m_blockedUITask = blockedUITask;
			this.m_showWaitingUITime = Timer.m_currTime.AddSeconds((double)NetWorkTransactionTask.m_delayTimeForUIWaiting);
			this.m_autoRetry = autoRetry;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00023480 File Offset: 0x00021680
		protected override bool OnStart(object param)
		{
			global::Debug.Log(string.Format("{0}::OnStart", base.GetType().Name));
			this.RegisterNetworkEvent();
			if (this.m_blockedUITask != null)
			{
				this.m_blockedUITask.EnableUIInput(false, null);
			}
			if (!this.StartNetWorking())
			{
				this.OnNetworkError();
			}
			UIManager.Instance.EventReturnToLoginUI += this.OnUIManagerReturnToLoginUI;
			return true;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000234F8 File Offset: 0x000216F8
		protected override void OnStop()
		{
			global::Debug.Log(string.Format("{0}::OnStop", base.GetType().Name));
			this.UnregisterNetworkEvent();
			if (this.m_blockedUITask != null)
			{
				this.m_blockedUITask.EnableUIInput(true, null);
			}
			if (this.m_isUIWaitingShown)
			{
				this.m_isUIWaitingShown = false;
				NetWorkTransactionTask.EventShowUIWaiting(false);
			}
			UIManager.Instance.EventReturnToLoginUI -= this.OnUIManagerReturnToLoginUI;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0002357C File Offset: 0x0002177C
		protected override void OnPause()
		{
			global::Debug.Log(string.Format("{0}::OnPause", base.GetType().Name));
			if (this.m_blockedUITask != null)
			{
				this.m_blockedUITask.EnableUIInput(true, null);
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000235C4 File Offset: 0x000217C4
		protected override bool OnResume(object param = null)
		{
			if (this.m_blockedUITask != null)
			{
				this.m_blockedUITask.EnableUIInput(false, null);
			}
			return base.OnResume(param);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000235F8 File Offset: 0x000217F8
		protected virtual bool StartNetWorking()
		{
			return true;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000235FC File Offset: 0x000217FC
		protected virtual void OnTransactionComplete()
		{
			base.Stop();
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00023604 File Offset: 0x00021804
		protected virtual void RegisterNetworkEvent()
		{
			GameManager.Instance.PlayerContext.EventOnGameServerDisconnected += this.OnGameServerDisconnected;
			GameManager.Instance.PlayerContext.EventOnGameServerNetworkError += this.OnGameServerNetworkError;
			GameManager.Instance.PlayerContext.EventOnGameServerDataUnsyncNotify += this.OnGameServerDataUnsyncNotify;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00023668 File Offset: 0x00021868
		protected virtual void UnregisterNetworkEvent()
		{
			if (GameManager.Instance.PlayerContext != null)
			{
				GameManager.Instance.PlayerContext.EventOnGameServerDisconnected -= this.OnGameServerDisconnected;
				GameManager.Instance.PlayerContext.EventOnGameServerNetworkError -= this.OnGameServerNetworkError;
				GameManager.Instance.PlayerContext.EventOnGameServerDataUnsyncNotify -= this.OnGameServerDataUnsyncNotify;
			}
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000236D8 File Offset: 0x000218D8
		protected override void OnTick()
		{
			if (this.m_isReturnToLoginByDirtyData)
			{
				return;
			}
			if (!this.m_isUIWaitingShown && Timer.m_currTime > this.m_showWaitingUITime)
			{
				this.m_isUIWaitingShown = true;
				if (NetWorkTransactionTask.EventShowUIWaiting != null)
				{
					NetWorkTransactionTask.EventShowUIWaiting(true);
				}
			}
			if (!this.m_isTimeOuted)
			{
				DateTime? timeoutTime = this.m_timeoutTime;
				if (timeoutTime != null)
				{
					DateTime? timeoutTime2 = this.m_timeoutTime;
					if (Timer.m_currTime > timeoutTime2)
					{
						this.m_isTimeOuted = true;
						this.OnTimeOut();
						return;
					}
				}
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00023788 File Offset: 0x00021988
		protected virtual void OnTimeOut()
		{
			this.OnNetworkError();
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00023790 File Offset: 0x00021990
		protected virtual void OnGameServerDataUnsyncNotify()
		{
			this.m_isReturnToLoginByDirtyData = true;
			base.Stop();
			if (NetWorkTransactionTask.EventReturnToLoginUI != null)
			{
				NetWorkTransactionTask.EventReturnToLoginUI(true);
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000237B4 File Offset: 0x000219B4
		protected virtual void OnGameServerNetworkError()
		{
			this.OnNetworkError();
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000237BC File Offset: 0x000219BC
		protected virtual void OnGameServerDisconnected()
		{
			this.OnNetworkError();
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000237C4 File Offset: 0x000219C4
		protected void OnNetworkError()
		{
			if (base.State == Task.TaskState.Paused || base.State == Task.TaskState.Stopped)
			{
				return;
			}
			if (this.m_isLaunchedReloginUITask)
			{
				return;
			}
			if (!this.m_autoRetry)
			{
				base.Stop();
				this.m_isLaunchedReloginUITask = true;
				if (NetWorkTransactionTask.EventReLoginBySession != null)
				{
					NetWorkTransactionTask.EventReLoginBySession(null);
				}
				return;
			}
			base.Pause();
			if (this.m_isUIWaitingShown)
			{
				this.m_isUIWaitingShown = false;
				NetWorkTransactionTask.EventShowUIWaiting(false);
			}
			this.UnregisterNetworkEvent();
			this.m_isLaunchedReloginUITask = true;
			if (NetWorkTransactionTask.EventReLoginBySession != null)
			{
				NetWorkTransactionTask.EventReLoginBySession(new Action(this.OnReLoginSuccess));
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00023878 File Offset: 0x00021A78
		protected virtual void OnReLoginSuccess()
		{
			this.m_isLaunchedReloginUITask = false;
			base.Resume(null);
			this.m_isTimeOuted = false;
			if ((double)this.m_timeout > 0.001)
			{
				this.m_timeoutTime = new DateTime?(Timer.m_currTime.AddSeconds((double)this.m_timeout));
			}
			if (this.m_isUIWaitingShown)
			{
				this.m_isUIWaitingShown = false;
				if (NetWorkTransactionTask.EventShowUIWaiting != null)
				{
					NetWorkTransactionTask.EventShowUIWaiting(false);
				}
			}
			this.m_showWaitingUITime = Timer.m_currTime.AddSeconds((double)NetWorkTransactionTask.m_delayTimeForUIWaiting);
			this.RegisterNetworkEvent();
			if (!this.StartNetWorking())
			{
				if (this.m_autoRetry)
				{
					base.ExecAfterTicks(new Action(this.OnNetworkError), 1UL);
				}
				this.m_autoRetry = false;
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00023940 File Offset: 0x00021B40
		protected virtual void OnUIManagerReturnToLoginUI(bool obj)
		{
			base.Stop();
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060007AC RID: 1964 RVA: 0x00023948 File Offset: 0x00021B48
		// (remove) Token: 0x060007AD RID: 1965 RVA: 0x0002397C File Offset: 0x00021B7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<bool> EventShowUIWaiting;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x060007AE RID: 1966 RVA: 0x000239B0 File Offset: 0x00021BB0
		// (remove) Token: 0x060007AF RID: 1967 RVA: 0x000239E4 File Offset: 0x00021BE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<bool> EventReturnToLoginUI;

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x060007B0 RID: 1968 RVA: 0x00023A18 File Offset: 0x00021C18
		// (remove) Token: 0x060007B1 RID: 1969 RVA: 0x00023A4C File Offset: 0x00021C4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<Action> EventReLoginBySession;

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x00023A80 File Offset: 0x00021C80
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x00023AA0 File Offset: 0x00021CA0
		[DoNotToLua]
		public new NetWorkTransactionTask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new NetWorkTransactionTask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00023AAC File Offset: 0x00021CAC
		private bool __callBase_Start(object param)
		{
			return base.Start(param);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00023AB8 File Offset: 0x00021CB8
		private void __callBase_Stop()
		{
			base.Stop();
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00023AC0 File Offset: 0x00021CC0
		private void __callBase_Pause()
		{
			base.Pause();
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00023AC8 File Offset: 0x00021CC8
		private bool __callBase_Resume(object param)
		{
			return base.Resume(param);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00023AD4 File Offset: 0x00021CD4
		private void __callBase_ClearOnStopEvent()
		{
			base.ClearOnStopEvent();
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00023ADC File Offset: 0x00021CDC
		private void __callBase_ExecAfterTicks(Action action, ulong delayTickCount)
		{
			base.ExecAfterTicks(action, delayTickCount);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00023AE8 File Offset: 0x00021CE8
		private bool __callBase_OnStart(object param)
		{
			return base.OnStart(param);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00023AF4 File Offset: 0x00021CF4
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00023AFC File Offset: 0x00021CFC
		private bool __callBase_OnResume(object param)
		{
			return base.OnResume(param);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00023B08 File Offset: 0x00021D08
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00023B10 File Offset: 0x00021D10
		private void __callBase_OnTick()
		{
			base.OnTick();
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00023B18 File Offset: 0x00021D18
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00023B20 File Offset: 0x00021D20
		private static void __callDele_EventShowUIWaiting(bool obj)
		{
			Action<bool> eventShowUIWaiting = NetWorkTransactionTask.EventShowUIWaiting;
			if (eventShowUIWaiting != null)
			{
				eventShowUIWaiting(obj);
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00023B40 File Offset: 0x00021D40
		private static void __clearDele_EventShowUIWaiting(bool obj)
		{
			NetWorkTransactionTask.EventShowUIWaiting = null;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00023B48 File Offset: 0x00021D48
		private static void __callDele_EventReturnToLoginUI(bool obj)
		{
			Action<bool> eventReturnToLoginUI = NetWorkTransactionTask.EventReturnToLoginUI;
			if (eventReturnToLoginUI != null)
			{
				eventReturnToLoginUI(obj);
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00023B68 File Offset: 0x00021D68
		private static void __clearDele_EventReturnToLoginUI(bool obj)
		{
			NetWorkTransactionTask.EventReturnToLoginUI = null;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00023B70 File Offset: 0x00021D70
		private static void __callDele_EventReLoginBySession(Action obj)
		{
			Action<Action> eventReLoginBySession = NetWorkTransactionTask.EventReLoginBySession;
			if (eventReLoginBySession != null)
			{
				eventReLoginBySession(obj);
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00023B90 File Offset: 0x00021D90
		private static void __clearDele_EventReLoginBySession(Action obj)
		{
			NetWorkTransactionTask.EventReLoginBySession = null;
		}

		// Token: 0x0400050B RID: 1291
		protected UITaskBase m_blockedUITask;

		// Token: 0x0400050C RID: 1292
		protected bool m_autoRetry;

		// Token: 0x0400050D RID: 1293
		protected float m_timeout;

		// Token: 0x0400050E RID: 1294
		protected bool m_isTimeOuted;

		// Token: 0x0400050F RID: 1295
		protected DateTime? m_timeoutTime;

		// Token: 0x04000510 RID: 1296
		protected DateTime m_showWaitingUITime;

		// Token: 0x04000511 RID: 1297
		protected bool m_isUIWaitingShown;

		// Token: 0x04000512 RID: 1298
		protected bool m_isReturnToLoginByDirtyData;

		// Token: 0x04000513 RID: 1299
		protected bool m_isLaunchedReloginUITask;

		// Token: 0x04000514 RID: 1300
		public static int m_delayTimeForUIWaiting = 1;

		// Token: 0x04000515 RID: 1301
		public const float TimeOutForEditor = 60f;

		// Token: 0x04000519 RID: 1305
		[DoNotToLua]
		private NetWorkTransactionTask.LuaExportHelper luaExportHelper;

		// Token: 0x020000D0 RID: 208
		public new class LuaExportHelper
		{
			// Token: 0x060007C7 RID: 1991 RVA: 0x00023BA0 File Offset: 0x00021DA0
			public LuaExportHelper(NetWorkTransactionTask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060007C8 RID: 1992 RVA: 0x00023BB0 File Offset: 0x00021DB0
			public bool __callBase_Start(object param)
			{
				return this.m_owner.__callBase_Start(param);
			}

			// Token: 0x060007C9 RID: 1993 RVA: 0x00023BC0 File Offset: 0x00021DC0
			public void __callBase_Stop()
			{
				this.m_owner.__callBase_Stop();
			}

			// Token: 0x060007CA RID: 1994 RVA: 0x00023BD0 File Offset: 0x00021DD0
			public void __callBase_Pause()
			{
				this.m_owner.__callBase_Pause();
			}

			// Token: 0x060007CB RID: 1995 RVA: 0x00023BE0 File Offset: 0x00021DE0
			public bool __callBase_Resume(object param)
			{
				return this.m_owner.__callBase_Resume(param);
			}

			// Token: 0x060007CC RID: 1996 RVA: 0x00023BF0 File Offset: 0x00021DF0
			public void __callBase_ClearOnStopEvent()
			{
				this.m_owner.__callBase_ClearOnStopEvent();
			}

			// Token: 0x060007CD RID: 1997 RVA: 0x00023C00 File Offset: 0x00021E00
			public void __callBase_ExecAfterTicks(Action action, ulong delayTickCount)
			{
				this.m_owner.__callBase_ExecAfterTicks(action, delayTickCount);
			}

			// Token: 0x060007CE RID: 1998 RVA: 0x00023C10 File Offset: 0x00021E10
			public bool __callBase_OnStart(object param)
			{
				return this.m_owner.__callBase_OnStart(param);
			}

			// Token: 0x060007CF RID: 1999 RVA: 0x00023C20 File Offset: 0x00021E20
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060007D0 RID: 2000 RVA: 0x00023C30 File Offset: 0x00021E30
			public bool __callBase_OnResume(object param)
			{
				return this.m_owner.__callBase_OnResume(param);
			}

			// Token: 0x060007D1 RID: 2001 RVA: 0x00023C40 File Offset: 0x00021E40
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x060007D2 RID: 2002 RVA: 0x00023C50 File Offset: 0x00021E50
			public void __callBase_OnTick()
			{
				this.m_owner.__callBase_OnTick();
			}

			// Token: 0x060007D3 RID: 2003 RVA: 0x00023C60 File Offset: 0x00021E60
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060007D4 RID: 2004 RVA: 0x00023C70 File Offset: 0x00021E70
			public static void __callDele_EventShowUIWaiting(bool obj)
			{
				NetWorkTransactionTask.__callDele_EventShowUIWaiting(obj);
			}

			// Token: 0x060007D5 RID: 2005 RVA: 0x00023C78 File Offset: 0x00021E78
			public static void __clearDele_EventShowUIWaiting(bool obj)
			{
				NetWorkTransactionTask.__clearDele_EventShowUIWaiting(obj);
			}

			// Token: 0x060007D6 RID: 2006 RVA: 0x00023C80 File Offset: 0x00021E80
			public static void __callDele_EventReturnToLoginUI(bool obj)
			{
				NetWorkTransactionTask.__callDele_EventReturnToLoginUI(obj);
			}

			// Token: 0x060007D7 RID: 2007 RVA: 0x00023C88 File Offset: 0x00021E88
			public static void __clearDele_EventReturnToLoginUI(bool obj)
			{
				NetWorkTransactionTask.__clearDele_EventReturnToLoginUI(obj);
			}

			// Token: 0x060007D8 RID: 2008 RVA: 0x00023C90 File Offset: 0x00021E90
			public static void __callDele_EventReLoginBySession(Action obj)
			{
				NetWorkTransactionTask.__callDele_EventReLoginBySession(obj);
			}

			// Token: 0x060007D9 RID: 2009 RVA: 0x00023C98 File Offset: 0x00021E98
			public static void __clearDele_EventReLoginBySession(Action obj)
			{
				NetWorkTransactionTask.__clearDele_EventReLoginBySession(obj);
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x060007DA RID: 2010 RVA: 0x00023CA0 File Offset: 0x00021EA0
			// (set) Token: 0x060007DB RID: 2011 RVA: 0x00023CB0 File Offset: 0x00021EB0
			public UITaskBase m_blockedUITask
			{
				get
				{
					return this.m_owner.m_blockedUITask;
				}
				set
				{
					this.m_owner.m_blockedUITask = value;
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x060007DC RID: 2012 RVA: 0x00023CC0 File Offset: 0x00021EC0
			// (set) Token: 0x060007DD RID: 2013 RVA: 0x00023CD0 File Offset: 0x00021ED0
			public bool m_autoRetry
			{
				get
				{
					return this.m_owner.m_autoRetry;
				}
				set
				{
					this.m_owner.m_autoRetry = value;
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x060007DE RID: 2014 RVA: 0x00023CE0 File Offset: 0x00021EE0
			// (set) Token: 0x060007DF RID: 2015 RVA: 0x00023CF0 File Offset: 0x00021EF0
			public float m_timeout
			{
				get
				{
					return this.m_owner.m_timeout;
				}
				set
				{
					this.m_owner.m_timeout = value;
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00023D00 File Offset: 0x00021F00
			// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00023D10 File Offset: 0x00021F10
			public bool m_isTimeOuted
			{
				get
				{
					return this.m_owner.m_isTimeOuted;
				}
				set
				{
					this.m_owner.m_isTimeOuted = value;
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00023D20 File Offset: 0x00021F20
			// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00023D30 File Offset: 0x00021F30
			public DateTime? m_timeoutTime
			{
				get
				{
					return this.m_owner.m_timeoutTime;
				}
				set
				{
					this.m_owner.m_timeoutTime = value;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00023D40 File Offset: 0x00021F40
			// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00023D50 File Offset: 0x00021F50
			public DateTime m_showWaitingUITime
			{
				get
				{
					return this.m_owner.m_showWaitingUITime;
				}
				set
				{
					this.m_owner.m_showWaitingUITime = value;
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00023D60 File Offset: 0x00021F60
			// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00023D70 File Offset: 0x00021F70
			public bool m_isUIWaitingShown
			{
				get
				{
					return this.m_owner.m_isUIWaitingShown;
				}
				set
				{
					this.m_owner.m_isUIWaitingShown = value;
				}
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00023D80 File Offset: 0x00021F80
			// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00023D90 File Offset: 0x00021F90
			public bool m_isReturnToLoginByDirtyData
			{
				get
				{
					return this.m_owner.m_isReturnToLoginByDirtyData;
				}
				set
				{
					this.m_owner.m_isReturnToLoginByDirtyData = value;
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x060007EA RID: 2026 RVA: 0x00023DA0 File Offset: 0x00021FA0
			// (set) Token: 0x060007EB RID: 2027 RVA: 0x00023DB0 File Offset: 0x00021FB0
			public bool m_isLaunchedReloginUITask
			{
				get
				{
					return this.m_owner.m_isLaunchedReloginUITask;
				}
				set
				{
					this.m_owner.m_isLaunchedReloginUITask = value;
				}
			}

			// Token: 0x060007EC RID: 2028 RVA: 0x00023DC0 File Offset: 0x00021FC0
			public bool OnStart(object param)
			{
				return this.m_owner.OnStart(param);
			}

			// Token: 0x060007ED RID: 2029 RVA: 0x00023DD0 File Offset: 0x00021FD0
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x060007EE RID: 2030 RVA: 0x00023DE0 File Offset: 0x00021FE0
			public void OnPause()
			{
				this.m_owner.OnPause();
			}

			// Token: 0x060007EF RID: 2031 RVA: 0x00023DF0 File Offset: 0x00021FF0
			public bool OnResume(object param)
			{
				return this.m_owner.OnResume(param);
			}

			// Token: 0x060007F0 RID: 2032 RVA: 0x00023E00 File Offset: 0x00022000
			public bool StartNetWorking()
			{
				return this.m_owner.StartNetWorking();
			}

			// Token: 0x060007F1 RID: 2033 RVA: 0x00023E10 File Offset: 0x00022010
			public void OnTransactionComplete()
			{
				this.m_owner.OnTransactionComplete();
			}

			// Token: 0x060007F2 RID: 2034 RVA: 0x00023E20 File Offset: 0x00022020
			public void RegisterNetworkEvent()
			{
				this.m_owner.RegisterNetworkEvent();
			}

			// Token: 0x060007F3 RID: 2035 RVA: 0x00023E30 File Offset: 0x00022030
			public void UnregisterNetworkEvent()
			{
				this.m_owner.UnregisterNetworkEvent();
			}

			// Token: 0x060007F4 RID: 2036 RVA: 0x00023E40 File Offset: 0x00022040
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x060007F5 RID: 2037 RVA: 0x00023E50 File Offset: 0x00022050
			public void OnTimeOut()
			{
				this.m_owner.OnTimeOut();
			}

			// Token: 0x060007F6 RID: 2038 RVA: 0x00023E60 File Offset: 0x00022060
			public void OnGameServerDataUnsyncNotify()
			{
				this.m_owner.OnGameServerDataUnsyncNotify();
			}

			// Token: 0x060007F7 RID: 2039 RVA: 0x00023E70 File Offset: 0x00022070
			public void OnGameServerNetworkError()
			{
				this.m_owner.OnGameServerNetworkError();
			}

			// Token: 0x060007F8 RID: 2040 RVA: 0x00023E80 File Offset: 0x00022080
			public void OnGameServerDisconnected()
			{
				this.m_owner.OnGameServerDisconnected();
			}

			// Token: 0x060007F9 RID: 2041 RVA: 0x00023E90 File Offset: 0x00022090
			public void OnNetworkError()
			{
				this.m_owner.OnNetworkError();
			}

			// Token: 0x060007FA RID: 2042 RVA: 0x00023EA0 File Offset: 0x000220A0
			public void OnReLoginSuccess()
			{
				this.m_owner.OnReLoginSuccess();
			}

			// Token: 0x060007FB RID: 2043 RVA: 0x00023EB0 File Offset: 0x000220B0
			public void OnUIManagerReturnToLoginUI(bool obj)
			{
				this.m_owner.OnUIManagerReturnToLoginUI(obj);
			}

			// Token: 0x0400051A RID: 1306
			private NetWorkTransactionTask m_owner;
		}
	}
}
