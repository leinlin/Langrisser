using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000315 RID: 789
	[ProtoContract(Name = "HeroInteractor")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroInteractor : IExtensible
	{
		// Token: 0x06002EF3 RID: 12019 RVA: 0x000BB384 File Offset: 0x000B9584
		public HeroInteractor()
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

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x000BB3EC File Offset: 0x000B95EC
		// (set) Token: 0x06002EF5 RID: 12021 RVA: 0x000BB3F4 File Offset: 0x000B95F4
		[ProtoMember(1, IsRequired = true, Name = "FavorabilityLevel", DataFormat = DataFormat.TwosComplement)]
		public int FavorabilityLevel
		{
			get
			{
				return this._FavorabilityLevel;
			}
			set
			{
				this._FavorabilityLevel = value;
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x000BB400 File Offset: 0x000B9600
		// (set) Token: 0x06002EF7 RID: 12023 RVA: 0x000BB408 File Offset: 0x000B9608
		[ProtoMember(2, IsRequired = true, Name = "HeroInteractionId", DataFormat = DataFormat.TwosComplement)]
		public int HeroInteractionId
		{
			get
			{
				return this._HeroInteractionId;
			}
			set
			{
				this._HeroInteractionId = value;
			}
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x000BB414 File Offset: 0x000B9614
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x000BB424 File Offset: 0x000B9624
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

		// Token: 0x06002EFA RID: 12026 RVA: 0x000BB4F0 File Offset: 0x000B96F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroInteractor));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040023FC RID: 9212
		private int _FavorabilityLevel;

		// Token: 0x040023FD RID: 9213
		private int _HeroInteractionId;

		// Token: 0x040023FE RID: 9214
		private IExtension extensionObject;

		// Token: 0x040023FF RID: 9215
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002400 RID: 9216
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002401 RID: 9217
		private LuaFunction m_ctor_hotfix;
	}
}
