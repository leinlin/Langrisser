using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006ED RID: 1773
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "PlayerInfoInitAck")]
	[Serializable]
	public class PlayerInfoInitAck : IExtensible
	{
		// Token: 0x06005ECA RID: 24266 RVA: 0x001ADB9C File Offset: 0x001ABD9C
		public PlayerInfoInitAck()
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

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06005ECB RID: 24267 RVA: 0x001ADC18 File Offset: 0x001ABE18
		// (set) Token: 0x06005ECC RID: 24268 RVA: 0x001ADC20 File Offset: 0x001ABE20
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06005ECD RID: 24269 RVA: 0x001ADC2C File Offset: 0x001ABE2C
		// (set) Token: 0x06005ECE RID: 24270 RVA: 0x001ADC34 File Offset: 0x001ABE34
		[ProtoMember(2, IsRequired = true, Name = "ServerCurrTime", DataFormat = DataFormat.TwosComplement)]
		public long ServerCurrTime
		{
			get
			{
				return this._ServerCurrTime;
			}
			set
			{
				this._ServerCurrTime = value;
			}
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x06005ECF RID: 24271 RVA: 0x001ADC40 File Offset: 0x001ABE40
		// (set) Token: 0x06005ED0 RID: 24272 RVA: 0x001ADC48 File Offset: 0x001ABE48
		[ProtoMember(3, IsRequired = true, Name = "NeedCreateCharactor", DataFormat = DataFormat.Default)]
		public bool NeedCreateCharactor
		{
			get
			{
				return this._NeedCreateCharactor;
			}
			set
			{
				this._NeedCreateCharactor = value;
			}
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06005ED1 RID: 24273 RVA: 0x001ADC54 File Offset: 0x001ABE54
		// (set) Token: 0x06005ED2 RID: 24274 RVA: 0x001ADC5C File Offset: 0x001ABE5C
		[ProtoMember(4, IsRequired = false, Name = "CharactorNickName", DataFormat = DataFormat.Default)]
		[DefaultValue("")]
		public string CharactorNickName
		{
			get
			{
				return this._CharactorNickName;
			}
			set
			{
				this._CharactorNickName = value;
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06005ED3 RID: 24275 RVA: 0x001ADC68 File Offset: 0x001ABE68
		// (set) Token: 0x06005ED4 RID: 24276 RVA: 0x001ADC70 File Offset: 0x001ABE70
		[DefaultValue("")]
		[ProtoMember(5, IsRequired = false, Name = "GameUserId", DataFormat = DataFormat.Default)]
		public string GameUserId
		{
			get
			{
				return this._GameUserId;
			}
			set
			{
				this._GameUserId = value;
			}
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06005ED5 RID: 24277 RVA: 0x001ADC7C File Offset: 0x001ABE7C
		// (set) Token: 0x06005ED6 RID: 24278 RVA: 0x001ADC84 File Offset: 0x001ABE84
		[DefaultValue(false)]
		[ProtoMember(6, IsRequired = false, Name = "IsNeedBattleReportLog", DataFormat = DataFormat.Default)]
		public bool IsNeedBattleReportLog
		{
			get
			{
				return this._IsNeedBattleReportLog;
			}
			set
			{
				this._IsNeedBattleReportLog = value;
			}
		}

		// Token: 0x06005ED7 RID: 24279 RVA: 0x001ADC90 File Offset: 0x001ABE90
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005ED8 RID: 24280 RVA: 0x001ADCA0 File Offset: 0x001ABEA0
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

		// Token: 0x06005ED9 RID: 24281 RVA: 0x001ADD6C File Offset: 0x001ABF6C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerInfoInitAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040046EE RID: 18158
		private int _Result;

		// Token: 0x040046EF RID: 18159
		private long _ServerCurrTime;

		// Token: 0x040046F0 RID: 18160
		private bool _NeedCreateCharactor;

		// Token: 0x040046F1 RID: 18161
		private string _CharactorNickName = string.Empty;

		// Token: 0x040046F2 RID: 18162
		private string _GameUserId = string.Empty;

		// Token: 0x040046F3 RID: 18163
		private bool _IsNeedBattleReportLog;

		// Token: 0x040046F4 RID: 18164
		private IExtension extensionObject;

		// Token: 0x040046F5 RID: 18165
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040046F6 RID: 18166
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040046F7 RID: 18167
		private LuaFunction m_ctor_hotfix;
	}
}
