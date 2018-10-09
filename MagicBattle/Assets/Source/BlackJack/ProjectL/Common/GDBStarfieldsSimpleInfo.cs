using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000325 RID: 805
	[ProtoContract(Name = "GDBStarfieldsSimpleInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GDBStarfieldsSimpleInfo : IExtensible
	{
		// Token: 0x06002F97 RID: 12183 RVA: 0x000BD258 File Offset: 0x000BB458
		public GDBStarfieldsSimpleInfo()
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

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x000BD2CC File Offset: 0x000BB4CC
		// (set) Token: 0x06002F99 RID: 12185 RVA: 0x000BD2D4 File Offset: 0x000BB4D4
		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06002F9A RID: 12186 RVA: 0x000BD2E0 File Offset: 0x000BB4E0
		// (set) Token: 0x06002F9B RID: 12187 RVA: 0x000BD2E8 File Offset: 0x000BB4E8
		[ProtoMember(2, IsRequired = true, Name = "name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x000BD2F4 File Offset: 0x000BB4F4
		// (set) Token: 0x06002F9D RID: 12189 RVA: 0x000BD2FC File Offset: 0x000BB4FC
		[ProtoMember(3, IsRequired = true, Name = "gLocationX", DataFormat = DataFormat.FixedSize)]
		public float GLocationX
		{
			get
			{
				return this._gLocationX;
			}
			set
			{
				this._gLocationX = value;
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x000BD308 File Offset: 0x000BB508
		// (set) Token: 0x06002F9F RID: 12191 RVA: 0x000BD310 File Offset: 0x000BB510
		[ProtoMember(4, IsRequired = true, Name = "gLocationZ", DataFormat = DataFormat.FixedSize)]
		public float GLocationZ
		{
			get
			{
				return this._gLocationZ;
			}
			set
			{
				this._gLocationZ = value;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06002FA0 RID: 12192 RVA: 0x000BD31C File Offset: 0x000BB51C
		// (set) Token: 0x06002FA1 RID: 12193 RVA: 0x000BD324 File Offset: 0x000BB524
		[ProtoMember(5, IsRequired = true, Name = "isNeedLocalization", DataFormat = DataFormat.Default)]
		public bool IsNeedLocalization
		{
			get
			{
				return this._isNeedLocalization;
			}
			set
			{
				this._isNeedLocalization = value;
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x000BD330 File Offset: 0x000BB530
		// (set) Token: 0x06002FA3 RID: 12195 RVA: 0x000BD338 File Offset: 0x000BB538
		[DefaultValue("")]
		[ProtoMember(6, IsRequired = false, Name = "localizationKey", DataFormat = DataFormat.Default)]
		public string LocalizationKey
		{
			get
			{
				return this._localizationKey;
			}
			set
			{
				this._localizationKey = value;
			}
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x000BD344 File Offset: 0x000BB544
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x000BD354 File Offset: 0x000BB554
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

		// Token: 0x06002FA6 RID: 12198 RVA: 0x000BD420 File Offset: 0x000BB620
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBStarfieldsSimpleInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002470 RID: 9328
		private int _Id;

		// Token: 0x04002471 RID: 9329
		private string _name;

		// Token: 0x04002472 RID: 9330
		private float _gLocationX;

		// Token: 0x04002473 RID: 9331
		private float _gLocationZ;

		// Token: 0x04002474 RID: 9332
		private bool _isNeedLocalization;

		// Token: 0x04002475 RID: 9333
		private string _localizationKey = string.Empty;

		// Token: 0x04002476 RID: 9334
		private IExtension extensionObject;

		// Token: 0x04002477 RID: 9335
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002478 RID: 9336
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002479 RID: 9337
		private LuaFunction m_ctor_hotfix;
	}
}
