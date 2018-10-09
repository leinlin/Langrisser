using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using SLua;

namespace BlackJack.BJFramework.Runtime.Lua
{
	// Token: 0x02000059 RID: 89
	[HotFix]
	public class LuaExportChecker
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x000125E8 File Offset: 0x000107E8
		public LuaExportChecker()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00012650 File Offset: 0x00010850
		public static void PublicStaticMethod()
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00012654 File Offset: 0x00010854
		protected static void ProtectedStaticMethod()
		{
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00012658 File Offset: 0x00010858
		private static void PrivateStaticMethod()
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0001265C File Offset: 0x0001085C
		public void PublicMethod()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PublicMethod_hotfix != null)
			{
				this.m_PublicMethod_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000126BC File Offset: 0x000108BC
		protected void ProtectedMethod()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ProtectedMethod_hotfix != null)
			{
				this.m_ProtectedMethod_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0001271C File Offset: 0x0001091C
		private void PrivateMethod()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PrivateMethod_hotfix != null)
			{
				this.m_PrivateMethod_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0001277C File Offset: 0x0001097C
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00012784 File Offset: 0x00010984
		public static int PublicStaticProperty { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0001278C File Offset: 0x0001098C
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00012794 File Offset: 0x00010994
		protected static int ProtectedStaticProperty { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0001279C File Offset: 0x0001099C
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x000127A4 File Offset: 0x000109A4
		private static int PrivateStaticProperty { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000127AC File Offset: 0x000109AC
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00012820 File Offset: 0x00010A20
		public int PublicProperty
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PublicProperty_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_PublicProperty_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<PublicProperty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_PublicPropertyInt32_hotfix != null)
				{
					this.m_set_PublicPropertyInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<PublicProperty>k__BackingField = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00012898 File Offset: 0x00010A98
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0001290C File Offset: 0x00010B0C
		protected int ProtectedProperty
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ProtectedProperty_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_ProtectedProperty_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<ProtectedProperty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ProtectedPropertyInt32_hotfix != null)
				{
					this.m_set_ProtectedPropertyInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<ProtectedProperty>k__BackingField = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00012984 File Offset: 0x00010B84
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x000129F8 File Offset: 0x00010BF8
		private int PrivateProperty
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PrivateProperty_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_PrivateProperty_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<PrivateProperty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_PrivatePropertyInt32_hotfix != null)
				{
					this.m_set_PrivatePropertyInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<PrivateProperty>k__BackingField = value;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060003FD RID: 1021 RVA: 0x00012A70 File Offset: 0x00010C70
		// (remove) Token: 0x060003FE RID: 1022 RVA: 0x00012AA4 File Offset: 0x00010CA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action PublicStaticEvent;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060003FF RID: 1023 RVA: 0x00012AD8 File Offset: 0x00010CD8
		// (remove) Token: 0x06000400 RID: 1024 RVA: 0x00012B0C File Offset: 0x00010D0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected static event Action ProtectedStaticEvent;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000401 RID: 1025 RVA: 0x00012B40 File Offset: 0x00010D40
		// (remove) Token: 0x06000402 RID: 1026 RVA: 0x00012B74 File Offset: 0x00010D74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static event Action PrivateStaticEvent;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000403 RID: 1027 RVA: 0x00012BA8 File Offset: 0x00010DA8
		// (remove) Token: 0x06000404 RID: 1028 RVA: 0x00012C44 File Offset: 0x00010E44
		public event Action PublicEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_PublicEventAction_hotfix != null)
				{
					this.m_add_PublicEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.PublicEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.PublicEvent, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_PublicEventAction_hotfix != null)
				{
					this.m_remove_PublicEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.PublicEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.PublicEvent, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000405 RID: 1029 RVA: 0x00012CE0 File Offset: 0x00010EE0
		// (remove) Token: 0x06000406 RID: 1030 RVA: 0x00012D7C File Offset: 0x00010F7C
		protected event Action ProtectedEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_ProtectedEventAction_hotfix != null)
				{
					this.m_add_ProtectedEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.ProtectedEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.ProtectedEvent, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_ProtectedEventAction_hotfix != null)
				{
					this.m_remove_ProtectedEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.ProtectedEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.ProtectedEvent, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000407 RID: 1031 RVA: 0x00012E18 File Offset: 0x00011018
		// (remove) Token: 0x06000408 RID: 1032 RVA: 0x00012EB4 File Offset: 0x000110B4
		private event Action PrivateEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_PrivateEventAction_hotfix != null)
				{
					this.m_add_PrivateEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.PrivateEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.PrivateEvent, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_PrivateEventAction_hotfix != null)
				{
					this.m_remove_PrivateEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.PrivateEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.PrivateEvent, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000409 RID: 1033 RVA: 0x00012F50 File Offset: 0x00011150
		// (remove) Token: 0x0600040A RID: 1034 RVA: 0x00012FEC File Offset: 0x000111EC
		public event LuaExportChecker.ReturnIntDelegate ReturnIntEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_ReturnIntEventReturnIntDelegate_hotfix != null)
				{
					this.m_add_ReturnIntEventReturnIntDelegate_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				LuaExportChecker.ReturnIntDelegate returnIntDelegate = this.ReturnIntEvent;
				LuaExportChecker.ReturnIntDelegate returnIntDelegate2;
				do
				{
					returnIntDelegate2 = returnIntDelegate;
					returnIntDelegate = Interlocked.CompareExchange<LuaExportChecker.ReturnIntDelegate>(ref this.ReturnIntEvent, (LuaExportChecker.ReturnIntDelegate)Delegate.Combine(returnIntDelegate2, value), returnIntDelegate);
				}
				while (returnIntDelegate != returnIntDelegate2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_ReturnIntEventReturnIntDelegate_hotfix != null)
				{
					this.m_remove_ReturnIntEventReturnIntDelegate_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				LuaExportChecker.ReturnIntDelegate returnIntDelegate = this.ReturnIntEvent;
				LuaExportChecker.ReturnIntDelegate returnIntDelegate2;
				do
				{
					returnIntDelegate2 = returnIntDelegate;
					returnIntDelegate = Interlocked.CompareExchange<LuaExportChecker.ReturnIntDelegate>(ref this.ReturnIntEvent, (LuaExportChecker.ReturnIntDelegate)Delegate.Remove(returnIntDelegate2, value), returnIntDelegate);
				}
				while (returnIntDelegate != returnIntDelegate2);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00013088 File Offset: 0x00011288
		public Action ReturnAction()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReturnAction_hotfix != null)
			{
				return (Action)this.m_ReturnAction_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return delegate()
			{
			};
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00013114 File Offset: 0x00011314
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00013134 File Offset: 0x00011334
		[DoNotToLua]
		public LuaExportChecker.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new LuaExportChecker.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00013140 File Offset: 0x00011340
		private static void __callDele_PublicStaticEvent()
		{
			Action publicStaticEvent = LuaExportChecker.PublicStaticEvent;
			if (publicStaticEvent != null)
			{
				publicStaticEvent();
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00013160 File Offset: 0x00011360
		private static void __clearDele_PublicStaticEvent()
		{
			LuaExportChecker.PublicStaticEvent = null;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00013168 File Offset: 0x00011368
		private static void __callDele_ProtectedStaticEvent()
		{
			Action protectedStaticEvent = LuaExportChecker.ProtectedStaticEvent;
			if (protectedStaticEvent != null)
			{
				protectedStaticEvent();
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00013188 File Offset: 0x00011388
		private static void __clearDele_ProtectedStaticEvent()
		{
			LuaExportChecker.ProtectedStaticEvent = null;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00013190 File Offset: 0x00011390
		private static void __callDele_PrivateStaticEvent()
		{
			Action privateStaticEvent = LuaExportChecker.PrivateStaticEvent;
			if (privateStaticEvent != null)
			{
				privateStaticEvent();
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000131B0 File Offset: 0x000113B0
		private static void __clearDele_PrivateStaticEvent()
		{
			LuaExportChecker.PrivateStaticEvent = null;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000131B8 File Offset: 0x000113B8
		private void __callDele_PublicEvent()
		{
			Action publicEvent = this.PublicEvent;
			if (publicEvent != null)
			{
				publicEvent();
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000131D8 File Offset: 0x000113D8
		private void __clearDele_PublicEvent()
		{
			this.PublicEvent = null;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000131E4 File Offset: 0x000113E4
		private void __callDele_ProtectedEvent()
		{
			Action protectedEvent = this.ProtectedEvent;
			if (protectedEvent != null)
			{
				protectedEvent();
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00013204 File Offset: 0x00011404
		private void __clearDele_ProtectedEvent()
		{
			this.ProtectedEvent = null;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00013210 File Offset: 0x00011410
		private void __callDele_PrivateEvent()
		{
			Action privateEvent = this.PrivateEvent;
			if (privateEvent != null)
			{
				privateEvent();
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00013230 File Offset: 0x00011430
		private void __clearDele_PrivateEvent()
		{
			this.PrivateEvent = null;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0001323C File Offset: 0x0001143C
		private int __callDele_ReturnIntEvent(int a)
		{
			int result = 0;
			LuaExportChecker.ReturnIntDelegate returnIntEvent = this.ReturnIntEvent;
			if (returnIntEvent != null)
			{
				result = returnIntEvent(a);
			}
			return result;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00013264 File Offset: 0x00011464
		private void __clearDele_ReturnIntEvent(int a)
		{
			this.ReturnIntEvent = null;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00013270 File Offset: 0x00011470
		private void __callDele_m_protectedDelegate()
		{
			Action protectedDelegate = this.m_protectedDelegate;
			if (protectedDelegate != null)
			{
				protectedDelegate();
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00013290 File Offset: 0x00011490
		private void __clearDele_m_protectedDelegate()
		{
			this.m_protectedDelegate = null;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0001329C File Offset: 0x0001149C
		private void __callDele_m_privateDelegate()
		{
			Action privateDelegate = this.m_privateDelegate;
			if (privateDelegate != null)
			{
				privateDelegate();
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000132BC File Offset: 0x000114BC
		private void __clearDele_m_privateDelegate()
		{
			this.m_privateDelegate = null;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000132C8 File Offset: 0x000114C8
		private int __callDele_ReturnInt(int a)
		{
			int result = 0;
			LuaExportChecker.ReturnIntDelegate returnInt = this.ReturnInt;
			if (returnInt != null)
			{
				result = returnInt(a);
			}
			return result;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000132F0 File Offset: 0x000114F0
		private void __clearDele_ReturnInt(int a)
		{
			this.ReturnInt = null;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0001330C File Offset: 0x0001150C
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
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_PublicMethod_hotfix = (luaObj.RawGet("PublicMethod") as LuaFunction);
					this.m_ProtectedMethod_hotfix = (luaObj.RawGet("ProtectedMethod") as LuaFunction);
					this.m_PrivateMethod_hotfix = (luaObj.RawGet("PrivateMethod") as LuaFunction);
					this.m_get_PublicProperty_hotfix = (luaObj.RawGet("get_PublicProperty") as LuaFunction);
					this.m_set_PublicPropertyInt32_hotfix = (luaObj.RawGet("set_PublicProperty") as LuaFunction);
					this.m_get_ProtectedProperty_hotfix = (luaObj.RawGet("get_ProtectedProperty") as LuaFunction);
					this.m_set_ProtectedPropertyInt32_hotfix = (luaObj.RawGet("set_ProtectedProperty") as LuaFunction);
					this.m_get_PrivateProperty_hotfix = (luaObj.RawGet("get_PrivateProperty") as LuaFunction);
					this.m_set_PrivatePropertyInt32_hotfix = (luaObj.RawGet("set_PrivateProperty") as LuaFunction);
					this.m_add_PublicEventAction_hotfix = (luaObj.RawGet("add_PublicEvent") as LuaFunction);
					this.m_remove_PublicEventAction_hotfix = (luaObj.RawGet("remove_PublicEvent") as LuaFunction);
					this.m_add_ProtectedEventAction_hotfix = (luaObj.RawGet("add_ProtectedEvent") as LuaFunction);
					this.m_remove_ProtectedEventAction_hotfix = (luaObj.RawGet("remove_ProtectedEvent") as LuaFunction);
					this.m_add_PrivateEventAction_hotfix = (luaObj.RawGet("add_PrivateEvent") as LuaFunction);
					this.m_remove_PrivateEventAction_hotfix = (luaObj.RawGet("remove_PrivateEvent") as LuaFunction);
					this.m_add_ReturnIntEventReturnIntDelegate_hotfix = (luaObj.RawGet("add_ReturnIntEvent") as LuaFunction);
					this.m_remove_ReturnIntEventReturnIntDelegate_hotfix = (luaObj.RawGet("remove_ReturnIntEvent") as LuaFunction);
					this.m_ReturnAction_hotfix = (luaObj.RawGet("ReturnAction") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0001359C File Offset: 0x0001179C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LuaExportChecker));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040001C5 RID: 453
		public static int m_publicStaticField;

		// Token: 0x040001C6 RID: 454
		protected static int m_protectedStaticField;

		// Token: 0x040001C7 RID: 455
		private static int m_privateStaticField;

		// Token: 0x040001C8 RID: 456
		public int m_publicField;

		// Token: 0x040001C9 RID: 457
		protected int m_protectedField;

		// Token: 0x040001CA RID: 458
		private int m_privateField;

		// Token: 0x040001D1 RID: 465
		public Action m_publicDelegate;

		// Token: 0x040001D2 RID: 466
		protected Action m_protectedDelegate;

		// Token: 0x040001D3 RID: 467
		private Action m_privateDelegate;

		// Token: 0x040001D5 RID: 469
		private LuaExportChecker.ReturnIntDelegate ReturnInt;

		// Token: 0x040001D6 RID: 470
		[DoNotToLua]
		private LuaExportChecker.LuaExportHelper luaExportHelper;

		// Token: 0x040001D8 RID: 472
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040001D9 RID: 473
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040001DA RID: 474
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040001DB RID: 475
		private LuaFunction m_PublicMethod_hotfix;

		// Token: 0x040001DC RID: 476
		private LuaFunction m_ProtectedMethod_hotfix;

		// Token: 0x040001DD RID: 477
		private LuaFunction m_PrivateMethod_hotfix;

		// Token: 0x040001DE RID: 478
		private LuaFunction m_get_PublicProperty_hotfix;

		// Token: 0x040001DF RID: 479
		private LuaFunction m_set_PublicPropertyInt32_hotfix;

		// Token: 0x040001E0 RID: 480
		private LuaFunction m_get_ProtectedProperty_hotfix;

		// Token: 0x040001E1 RID: 481
		private LuaFunction m_set_ProtectedPropertyInt32_hotfix;

		// Token: 0x040001E2 RID: 482
		private LuaFunction m_get_PrivateProperty_hotfix;

		// Token: 0x040001E3 RID: 483
		private LuaFunction m_set_PrivatePropertyInt32_hotfix;

		// Token: 0x040001E4 RID: 484
		private LuaFunction m_add_PublicEventAction_hotfix;

		// Token: 0x040001E5 RID: 485
		private LuaFunction m_remove_PublicEventAction_hotfix;

		// Token: 0x040001E6 RID: 486
		private LuaFunction m_add_ProtectedEventAction_hotfix;

		// Token: 0x040001E7 RID: 487
		private LuaFunction m_remove_ProtectedEventAction_hotfix;

		// Token: 0x040001E8 RID: 488
		private LuaFunction m_add_PrivateEventAction_hotfix;

		// Token: 0x040001E9 RID: 489
		private LuaFunction m_remove_PrivateEventAction_hotfix;

		// Token: 0x040001EA RID: 490
		private LuaFunction m_add_ReturnIntEventReturnIntDelegate_hotfix;

		// Token: 0x040001EB RID: 491
		private LuaFunction m_remove_ReturnIntEventReturnIntDelegate_hotfix;

		// Token: 0x040001EC RID: 492
		private LuaFunction m_ReturnAction_hotfix;

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x06000426 RID: 1062
		public delegate int ReturnIntDelegate(int a);

		// Token: 0x0200005B RID: 91
		public class LuaExportHelper
		{
			// Token: 0x06000429 RID: 1065 RVA: 0x00013604 File Offset: 0x00011804
			public LuaExportHelper(LuaExportChecker owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600042A RID: 1066 RVA: 0x00013614 File Offset: 0x00011814
			public static void __callDele_PublicStaticEvent()
			{
				LuaExportChecker.__callDele_PublicStaticEvent();
			}

			// Token: 0x0600042B RID: 1067 RVA: 0x0001361C File Offset: 0x0001181C
			public static void __clearDele_PublicStaticEvent()
			{
				LuaExportChecker.__clearDele_PublicStaticEvent();
			}

			// Token: 0x0600042C RID: 1068 RVA: 0x00013624 File Offset: 0x00011824
			public static void __callDele_ProtectedStaticEvent()
			{
				LuaExportChecker.__callDele_ProtectedStaticEvent();
			}

			// Token: 0x0600042D RID: 1069 RVA: 0x0001362C File Offset: 0x0001182C
			public static void __clearDele_ProtectedStaticEvent()
			{
				LuaExportChecker.__clearDele_ProtectedStaticEvent();
			}

			// Token: 0x0600042E RID: 1070 RVA: 0x00013634 File Offset: 0x00011834
			public static void __callDele_PrivateStaticEvent()
			{
				LuaExportChecker.__callDele_PrivateStaticEvent();
			}

			// Token: 0x0600042F RID: 1071 RVA: 0x0001363C File Offset: 0x0001183C
			public static void __clearDele_PrivateStaticEvent()
			{
				LuaExportChecker.__clearDele_PrivateStaticEvent();
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x00013644 File Offset: 0x00011844
			public void __callDele_PublicEvent()
			{
				this.m_owner.__callDele_PublicEvent();
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x00013654 File Offset: 0x00011854
			public void __clearDele_PublicEvent()
			{
				this.m_owner.__clearDele_PublicEvent();
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x00013664 File Offset: 0x00011864
			public void __callDele_ProtectedEvent()
			{
				this.m_owner.__callDele_ProtectedEvent();
			}

			// Token: 0x06000433 RID: 1075 RVA: 0x00013674 File Offset: 0x00011874
			public void __clearDele_ProtectedEvent()
			{
				this.m_owner.__clearDele_ProtectedEvent();
			}

			// Token: 0x06000434 RID: 1076 RVA: 0x00013684 File Offset: 0x00011884
			public void __callDele_PrivateEvent()
			{
				this.m_owner.__callDele_PrivateEvent();
			}

			// Token: 0x06000435 RID: 1077 RVA: 0x00013694 File Offset: 0x00011894
			public void __clearDele_PrivateEvent()
			{
				this.m_owner.__clearDele_PrivateEvent();
			}

			// Token: 0x06000436 RID: 1078 RVA: 0x000136A4 File Offset: 0x000118A4
			public int __callDele_ReturnIntEvent(int a)
			{
				return this.m_owner.__callDele_ReturnIntEvent(a);
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x000136C4 File Offset: 0x000118C4
			public void __clearDele_ReturnIntEvent(int a)
			{
				this.m_owner.__clearDele_ReturnIntEvent(a);
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x000136D4 File Offset: 0x000118D4
			public void __callDele_m_protectedDelegate()
			{
				this.m_owner.__callDele_m_protectedDelegate();
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x000136E4 File Offset: 0x000118E4
			public void __clearDele_m_protectedDelegate()
			{
				this.m_owner.__clearDele_m_protectedDelegate();
			}

			// Token: 0x0600043A RID: 1082 RVA: 0x000136F4 File Offset: 0x000118F4
			public void __callDele_m_privateDelegate()
			{
				this.m_owner.__callDele_m_privateDelegate();
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x00013704 File Offset: 0x00011904
			public void __clearDele_m_privateDelegate()
			{
				this.m_owner.__clearDele_m_privateDelegate();
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x00013714 File Offset: 0x00011914
			public int __callDele_ReturnInt(int a)
			{
				return this.m_owner.__callDele_ReturnInt(a);
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x00013734 File Offset: 0x00011934
			public void __clearDele_ReturnInt(int a)
			{
				this.m_owner.__clearDele_ReturnInt(a);
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600043E RID: 1086 RVA: 0x00013744 File Offset: 0x00011944
			// (set) Token: 0x0600043F RID: 1087 RVA: 0x0001374C File Offset: 0x0001194C
			public static int m_protectedStaticField
			{
				get
				{
					return LuaExportChecker.m_protectedStaticField;
				}
				set
				{
					LuaExportChecker.m_protectedStaticField = value;
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x06000440 RID: 1088 RVA: 0x00013754 File Offset: 0x00011954
			// (set) Token: 0x06000441 RID: 1089 RVA: 0x0001375C File Offset: 0x0001195C
			public static int m_privateStaticField
			{
				get
				{
					return LuaExportChecker.m_privateStaticField;
				}
				set
				{
					LuaExportChecker.m_privateStaticField = value;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000442 RID: 1090 RVA: 0x00013764 File Offset: 0x00011964
			// (set) Token: 0x06000443 RID: 1091 RVA: 0x00013774 File Offset: 0x00011974
			public int m_protectedField
			{
				get
				{
					return this.m_owner.m_protectedField;
				}
				set
				{
					this.m_owner.m_protectedField = value;
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000444 RID: 1092 RVA: 0x00013784 File Offset: 0x00011984
			// (set) Token: 0x06000445 RID: 1093 RVA: 0x00013794 File Offset: 0x00011994
			public int m_privateField
			{
				get
				{
					return this.m_owner.m_privateField;
				}
				set
				{
					this.m_owner.m_privateField = value;
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000446 RID: 1094 RVA: 0x000137A4 File Offset: 0x000119A4
			// (set) Token: 0x06000447 RID: 1095 RVA: 0x000137B4 File Offset: 0x000119B4
			public Action m_protectedDelegate
			{
				get
				{
					return this.m_owner.m_protectedDelegate;
				}
				set
				{
					this.m_owner.m_protectedDelegate = value;
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000448 RID: 1096 RVA: 0x000137C4 File Offset: 0x000119C4
			// (set) Token: 0x06000449 RID: 1097 RVA: 0x000137D4 File Offset: 0x000119D4
			public Action m_privateDelegate
			{
				get
				{
					return this.m_owner.m_privateDelegate;
				}
				set
				{
					this.m_owner.m_privateDelegate = value;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x0600044A RID: 1098 RVA: 0x000137E4 File Offset: 0x000119E4
			// (set) Token: 0x0600044B RID: 1099 RVA: 0x000137F4 File Offset: 0x000119F4
			public LuaExportChecker.ReturnIntDelegate ReturnInt
			{
				get
				{
					return this.m_owner.ReturnInt;
				}
				set
				{
					this.m_owner.ReturnInt = value;
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x00013804 File Offset: 0x00011A04
			// (set) Token: 0x0600044D RID: 1101 RVA: 0x0001380C File Offset: 0x00011A0C
			public static int ProtectedStaticProperty
			{
				get
				{
					return LuaExportChecker.ProtectedStaticProperty;
				}
				set
				{
					LuaExportChecker.ProtectedStaticProperty = value;
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x0600044E RID: 1102 RVA: 0x00013814 File Offset: 0x00011A14
			// (set) Token: 0x0600044F RID: 1103 RVA: 0x0001381C File Offset: 0x00011A1C
			public static int PrivateStaticProperty
			{
				get
				{
					return LuaExportChecker.PrivateStaticProperty;
				}
				set
				{
					LuaExportChecker.PrivateStaticProperty = value;
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000450 RID: 1104 RVA: 0x00013824 File Offset: 0x00011A24
			// (set) Token: 0x06000451 RID: 1105 RVA: 0x00013834 File Offset: 0x00011A34
			public int ProtectedProperty
			{
				get
				{
					return this.m_owner.ProtectedProperty;
				}
				set
				{
					this.m_owner.ProtectedProperty = value;
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000452 RID: 1106 RVA: 0x00013844 File Offset: 0x00011A44
			// (set) Token: 0x06000453 RID: 1107 RVA: 0x00013854 File Offset: 0x00011A54
			public int PrivateProperty
			{
				get
				{
					return this.m_owner.PrivateProperty;
				}
				set
				{
					this.m_owner.PrivateProperty = value;
				}
			}

			// Token: 0x06000454 RID: 1108 RVA: 0x00013864 File Offset: 0x00011A64
			public static void ProtectedStaticMethod()
			{
				LuaExportChecker.ProtectedStaticMethod();
			}

			// Token: 0x06000455 RID: 1109 RVA: 0x0001386C File Offset: 0x00011A6C
			public static void PrivateStaticMethod()
			{
				LuaExportChecker.PrivateStaticMethod();
			}

			// Token: 0x06000456 RID: 1110 RVA: 0x00013874 File Offset: 0x00011A74
			public void ProtectedMethod()
			{
				this.m_owner.ProtectedMethod();
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x00013884 File Offset: 0x00011A84
			public void PrivateMethod()
			{
				this.m_owner.PrivateMethod();
			}

			// Token: 0x1400000A RID: 10
			// (add) Token: 0x06000458 RID: 1112 RVA: 0x00013894 File Offset: 0x00011A94
			// (remove) Token: 0x06000459 RID: 1113 RVA: 0x000138C8 File Offset: 0x00011AC8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public static event Action ProtectedStaticEvent;

			// Token: 0x1400000B RID: 11
			// (add) Token: 0x0600045A RID: 1114 RVA: 0x000138FC File Offset: 0x00011AFC
			// (remove) Token: 0x0600045B RID: 1115 RVA: 0x00013930 File Offset: 0x00011B30
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public static event Action PrivateStaticEvent;

			// Token: 0x1400000C RID: 12
			// (add) Token: 0x0600045C RID: 1116 RVA: 0x00013964 File Offset: 0x00011B64
			// (remove) Token: 0x0600045D RID: 1117 RVA: 0x00013974 File Offset: 0x00011B74
			public event Action ProtectedEvent
			{
				add
				{
					this.m_owner.ProtectedEvent += value;
				}
				remove
				{
					this.m_owner.ProtectedEvent += value;
				}
			}

			// Token: 0x1400000D RID: 13
			// (add) Token: 0x0600045E RID: 1118 RVA: 0x00013984 File Offset: 0x00011B84
			// (remove) Token: 0x0600045F RID: 1119 RVA: 0x00013994 File Offset: 0x00011B94
			public event Action PrivateEvent
			{
				add
				{
					this.m_owner.PrivateEvent += value;
				}
				remove
				{
					this.m_owner.PrivateEvent += value;
				}
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x000139A4 File Offset: 0x00011BA4
			// Note: this type is marked as 'beforefieldinit'.
			static LuaExportHelper()
			{
				LuaExportChecker.LuaExportHelper.ProtectedStaticEvent = LuaExportChecker.ProtectedStaticEvent;
				LuaExportChecker.LuaExportHelper.PrivateStaticEvent = LuaExportChecker.PrivateStaticEvent;
			}

			// Token: 0x040001ED RID: 493
			private LuaExportChecker m_owner;
		}
	}
}
