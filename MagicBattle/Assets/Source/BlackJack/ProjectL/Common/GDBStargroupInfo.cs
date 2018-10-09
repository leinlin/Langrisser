using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000326 RID: 806
	[ProtoContract(Name = "GDBStargroupInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GDBStargroupInfo : IExtensible
	{
		// Token: 0x06002FA7 RID: 12199 RVA: 0x000BD488 File Offset: 0x000BB688
		public GDBStargroupInfo()
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

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06002FA8 RID: 12200 RVA: 0x000BD510 File Offset: 0x000BB710
		// (set) Token: 0x06002FA9 RID: 12201 RVA: 0x000BD518 File Offset: 0x000BB718
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

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06002FAA RID: 12202 RVA: 0x000BD524 File Offset: 0x000BB724
		// (set) Token: 0x06002FAB RID: 12203 RVA: 0x000BD52C File Offset: 0x000BB72C
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

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06002FAC RID: 12204 RVA: 0x000BD538 File Offset: 0x000BB738
		// (set) Token: 0x06002FAD RID: 12205 RVA: 0x000BD540 File Offset: 0x000BB740
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

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x000BD54C File Offset: 0x000BB74C
		// (set) Token: 0x06002FAF RID: 12207 RVA: 0x000BD554 File Offset: 0x000BB754
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

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06002FB0 RID: 12208 RVA: 0x000BD560 File Offset: 0x000BB760
		[ProtoMember(5, Name = "solarSystems", DataFormat = DataFormat.Default)]
		public List<GDBSolarSystemSimpleInfo> SolarSystems
		{
			get
			{
				return this._solarSystems;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x000BD568 File Offset: 0x000BB768
		[ProtoMember(6, Name = "LinkList", DataFormat = DataFormat.Default)]
		public List<GDBLinkInfo> LinkList
		{
			get
			{
				return this._LinkList;
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x000BD570 File Offset: 0x000BB770
		// (set) Token: 0x06002FB3 RID: 12211 RVA: 0x000BD578 File Offset: 0x000BB778
		[ProtoMember(7, IsRequired = true, Name = "isNeedLocalization", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06002FB4 RID: 12212 RVA: 0x000BD584 File Offset: 0x000BB784
		// (set) Token: 0x06002FB5 RID: 12213 RVA: 0x000BD58C File Offset: 0x000BB78C
		[DefaultValue("")]
		[ProtoMember(8, IsRequired = false, Name = "localizationKey", DataFormat = DataFormat.Default)]
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

		// Token: 0x06002FB6 RID: 12214 RVA: 0x000BD598 File Offset: 0x000BB798
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x000BD5A8 File Offset: 0x000BB7A8
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

		// Token: 0x06002FB8 RID: 12216 RVA: 0x000BD674 File Offset: 0x000BB874
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBStargroupInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400247A RID: 9338
		private int _Id;

		// Token: 0x0400247B RID: 9339
		private string _name;

		// Token: 0x0400247C RID: 9340
		private float _gLocationX;

		// Token: 0x0400247D RID: 9341
		private float _gLocationZ;

		// Token: 0x0400247E RID: 9342
		private readonly List<GDBSolarSystemSimpleInfo> _solarSystems = new List<GDBSolarSystemSimpleInfo>();

		// Token: 0x0400247F RID: 9343
		private readonly List<GDBLinkInfo> _LinkList = new List<GDBLinkInfo>();

		// Token: 0x04002480 RID: 9344
		private bool _isNeedLocalization;

		// Token: 0x04002481 RID: 9345
		private string _localizationKey = string.Empty;

		// Token: 0x04002482 RID: 9346
		private IExtension extensionObject;

		// Token: 0x04002483 RID: 9347
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002484 RID: 9348
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002485 RID: 9349
		private LuaFunction m_ctor_hotfix;
	}
}
