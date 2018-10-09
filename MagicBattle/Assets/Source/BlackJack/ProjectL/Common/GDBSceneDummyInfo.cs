using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000329 RID: 809
	[ProtoContract(Name = "GDBSceneDummyInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GDBSceneDummyInfo : IExtensible
	{
		// Token: 0x06002FE3 RID: 12259 RVA: 0x000BDBC4 File Offset: 0x000BBDC4
		public GDBSceneDummyInfo()
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

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06002FE4 RID: 12260 RVA: 0x000BDC38 File Offset: 0x000BBE38
		// (set) Token: 0x06002FE5 RID: 12261 RVA: 0x000BDC40 File Offset: 0x000BBE40
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

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06002FE6 RID: 12262 RVA: 0x000BDC4C File Offset: 0x000BBE4C
		// (set) Token: 0x06002FE7 RID: 12263 RVA: 0x000BDC54 File Offset: 0x000BBE54
		[ProtoMember(2, IsRequired = true, Name = "confId", DataFormat = DataFormat.TwosComplement)]
		public int ConfId
		{
			get
			{
				return this._confId;
			}
			set
			{
				this._confId = value;
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06002FE8 RID: 12264 RVA: 0x000BDC60 File Offset: 0x000BBE60
		// (set) Token: 0x06002FE9 RID: 12265 RVA: 0x000BDC68 File Offset: 0x000BBE68
		[ProtoMember(3, IsRequired = true, Name = "name", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06002FEA RID: 12266 RVA: 0x000BDC74 File Offset: 0x000BBE74
		// (set) Token: 0x06002FEB RID: 12267 RVA: 0x000BDC7C File Offset: 0x000BBE7C
		[ProtoMember(4, IsRequired = true, Name = "location", DataFormat = DataFormat.Default)]
		public PVector3D Location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location = value;
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06002FEC RID: 12268 RVA: 0x000BDC88 File Offset: 0x000BBE88
		// (set) Token: 0x06002FED RID: 12269 RVA: 0x000BDC90 File Offset: 0x000BBE90
		[ProtoMember(5, IsRequired = true, Name = "rotationY", DataFormat = DataFormat.TwosComplement)]
		public uint RotationY
		{
			get
			{
				return this._rotationY;
			}
			set
			{
				this._rotationY = value;
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06002FEE RID: 12270 RVA: 0x000BDC9C File Offset: 0x000BBE9C
		// (set) Token: 0x06002FEF RID: 12271 RVA: 0x000BDCA4 File Offset: 0x000BBEA4
		[ProtoMember(6, IsRequired = true, Name = "isNeedLocalization", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06002FF0 RID: 12272 RVA: 0x000BDCB0 File Offset: 0x000BBEB0
		// (set) Token: 0x06002FF1 RID: 12273 RVA: 0x000BDCB8 File Offset: 0x000BBEB8
		[ProtoMember(7, IsRequired = false, Name = "localizationKey", DataFormat = DataFormat.Default)]
		[DefaultValue("")]
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

		// Token: 0x06002FF2 RID: 12274 RVA: 0x000BDCC4 File Offset: 0x000BBEC4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x000BDCD4 File Offset: 0x000BBED4
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

		// Token: 0x06002FF4 RID: 12276 RVA: 0x000BDDA0 File Offset: 0x000BBFA0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBSceneDummyInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040024A1 RID: 9377
		private int _Id;

		// Token: 0x040024A2 RID: 9378
		private int _confId;

		// Token: 0x040024A3 RID: 9379
		private string _name;

		// Token: 0x040024A4 RID: 9380
		private PVector3D _location;

		// Token: 0x040024A5 RID: 9381
		private uint _rotationY;

		// Token: 0x040024A6 RID: 9382
		private bool _isNeedLocalization;

		// Token: 0x040024A7 RID: 9383
		private string _localizationKey = string.Empty;

		// Token: 0x040024A8 RID: 9384
		private IExtension extensionObject;

		// Token: 0x040024A9 RID: 9385
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040024AA RID: 9386
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040024AB RID: 9387
		private LuaFunction m_ctor_hotfix;
	}
}
