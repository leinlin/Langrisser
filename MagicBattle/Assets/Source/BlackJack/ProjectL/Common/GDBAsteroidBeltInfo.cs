using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200032F RID: 815
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GDBAsteroidBeltInfo")]
	[Serializable]
	public class GDBAsteroidBeltInfo : IExtensible
	{
		// Token: 0x0600307A RID: 12410 RVA: 0x000BEB14 File Offset: 0x000BCD14
		public GDBAsteroidBeltInfo()
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

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x0600307B RID: 12411 RVA: 0x000BEB9C File Offset: 0x000BCD9C
		// (set) Token: 0x0600307C RID: 12412 RVA: 0x000BEBA4 File Offset: 0x000BCDA4
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

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x0600307D RID: 12413 RVA: 0x000BEBB0 File Offset: 0x000BCDB0
		// (set) Token: 0x0600307E RID: 12414 RVA: 0x000BEBB8 File Offset: 0x000BCDB8
		[DefaultValue("")]
		[ProtoMember(2, IsRequired = false, Name = "name", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x0600307F RID: 12415 RVA: 0x000BEBC4 File Offset: 0x000BCDC4
		[ProtoMember(3, Name = "AsteroidGatherPointPositionList", DataFormat = DataFormat.Default)]
		public List<GDBAsteroidGatherPointPositionInfo> AsteroidGatherPointPositionList
		{
			get
			{
				return this._AsteroidGatherPointPositionList;
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06003080 RID: 12416 RVA: 0x000BEBCC File Offset: 0x000BCDCC
		// (set) Token: 0x06003081 RID: 12417 RVA: 0x000BEBD4 File Offset: 0x000BCDD4
		[ProtoMember(4, IsRequired = true, Name = "OrbitRadius", DataFormat = DataFormat.TwosComplement)]
		public ulong OrbitRadius
		{
			get
			{
				return this._OrbitRadius;
			}
			set
			{
				this._OrbitRadius = value;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06003082 RID: 12418 RVA: 0x000BEBE0 File Offset: 0x000BCDE0
		// (set) Token: 0x06003083 RID: 12419 RVA: 0x000BEBE8 File Offset: 0x000BCDE8
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

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06003084 RID: 12420 RVA: 0x000BEBF4 File Offset: 0x000BCDF4
		// (set) Token: 0x06003085 RID: 12421 RVA: 0x000BEBFC File Offset: 0x000BCDFC
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

		// Token: 0x06003086 RID: 12422 RVA: 0x000BEC08 File Offset: 0x000BCE08
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x000BEC18 File Offset: 0x000BCE18
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

		// Token: 0x06003088 RID: 12424 RVA: 0x000BECE4 File Offset: 0x000BCEE4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBAsteroidBeltInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040024F9 RID: 9465
		private int _Id;

		// Token: 0x040024FA RID: 9466
		private string _name = string.Empty;

		// Token: 0x040024FB RID: 9467
		private readonly List<GDBAsteroidGatherPointPositionInfo> _AsteroidGatherPointPositionList = new List<GDBAsteroidGatherPointPositionInfo>();

		// Token: 0x040024FC RID: 9468
		private ulong _OrbitRadius;

		// Token: 0x040024FD RID: 9469
		private bool _isNeedLocalization;

		// Token: 0x040024FE RID: 9470
		private string _localizationKey = string.Empty;

		// Token: 0x040024FF RID: 9471
		private IExtension extensionObject;

		// Token: 0x04002500 RID: 9472
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002501 RID: 9473
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002502 RID: 9474
		private LuaFunction m_ctor_hotfix;
	}
}
