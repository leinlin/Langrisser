using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000674 RID: 1652
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProUserSummary")]
	[Serializable]
	public class ProUserSummary : IExtensible
	{
		// Token: 0x060059F8 RID: 23032 RVA: 0x0019F1A4 File Offset: 0x0019D3A4
		public ProUserSummary()
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

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x060059F9 RID: 23033 RVA: 0x0019F20C File Offset: 0x0019D40C
		// (set) Token: 0x060059FA RID: 23034 RVA: 0x0019F214 File Offset: 0x0019D414
		[ProtoMember(1, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x060059FB RID: 23035 RVA: 0x0019F220 File Offset: 0x0019D420
		// (set) Token: 0x060059FC RID: 23036 RVA: 0x0019F228 File Offset: 0x0019D428
		[ProtoMember(2, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x060059FD RID: 23037 RVA: 0x0019F234 File Offset: 0x0019D434
		// (set) Token: 0x060059FE RID: 23038 RVA: 0x0019F23C File Offset: 0x0019D43C
		[ProtoMember(3, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				this._Level = value;
			}
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x060059FF RID: 23039 RVA: 0x0019F248 File Offset: 0x0019D448
		// (set) Token: 0x06005A00 RID: 23040 RVA: 0x0019F250 File Offset: 0x0019D450
		[ProtoMember(4, IsRequired = true, Name = "Online", DataFormat = DataFormat.Default)]
		public bool Online
		{
			get
			{
				return this._Online;
			}
			set
			{
				this._Online = value;
			}
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06005A01 RID: 23041 RVA: 0x0019F25C File Offset: 0x0019D45C
		// (set) Token: 0x06005A02 RID: 23042 RVA: 0x0019F264 File Offset: 0x0019D464
		[ProtoMember(5, IsRequired = true, Name = "HeadIcon", DataFormat = DataFormat.TwosComplement)]
		public int HeadIcon
		{
			get
			{
				return this._HeadIcon;
			}
			set
			{
				this._HeadIcon = value;
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06005A03 RID: 23043 RVA: 0x0019F270 File Offset: 0x0019D470
		// (set) Token: 0x06005A04 RID: 23044 RVA: 0x0019F278 File Offset: 0x0019D478
		[ProtoMember(6, IsRequired = true, Name = "LogoutTime", DataFormat = DataFormat.TwosComplement)]
		public long LogoutTime
		{
			get
			{
				return this._LogoutTime;
			}
			set
			{
				this._LogoutTime = value;
			}
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06005A05 RID: 23045 RVA: 0x0019F284 File Offset: 0x0019D484
		// (set) Token: 0x06005A06 RID: 23046 RVA: 0x0019F28C File Offset: 0x0019D48C
		[ProtoMember(7, IsRequired = true, Name = "TopHeroBattlePower", DataFormat = DataFormat.TwosComplement)]
		public int TopHeroBattlePower
		{
			get
			{
				return this._TopHeroBattlePower;
			}
			set
			{
				this._TopHeroBattlePower = value;
			}
		}

		// Token: 0x06005A07 RID: 23047 RVA: 0x0019F298 File Offset: 0x0019D498
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005A08 RID: 23048 RVA: 0x0019F2A8 File Offset: 0x0019D4A8
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
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
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06005A09 RID: 23049 RVA: 0x0019F374 File Offset: 0x0019D574
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProUserSummary));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004373 RID: 17267
		private string _UserId;

		// Token: 0x04004374 RID: 17268
		private string _Name;

		// Token: 0x04004375 RID: 17269
		private int _Level;

		// Token: 0x04004376 RID: 17270
		private bool _Online;

		// Token: 0x04004377 RID: 17271
		private int _HeadIcon;

		// Token: 0x04004378 RID: 17272
		private long _LogoutTime;

		// Token: 0x04004379 RID: 17273
		private int _TopHeroBattlePower;

		// Token: 0x0400437A RID: 17274
		private IExtension extensionObject;

		// Token: 0x0400437B RID: 17275
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400437C RID: 17276
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400437D RID: 17277
		private LuaFunction m_ctor_hotfix;
	}
}
