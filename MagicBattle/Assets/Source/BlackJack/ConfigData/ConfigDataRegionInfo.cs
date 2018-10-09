using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000280 RID: 640
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataRegionInfo")]
	[Serializable]
	public class ConfigDataRegionInfo : IExtensible
	{
		// Token: 0x06002905 RID: 10501 RVA: 0x000AF4C8 File Offset: 0x000AD6C8
		public ConfigDataRegionInfo()
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

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002906 RID: 10502 RVA: 0x000AF53C File Offset: 0x000AD73C
		// (set) Token: 0x06002907 RID: 10503 RVA: 0x000AF544 File Offset: 0x000AD744
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002908 RID: 10504 RVA: 0x000AF550 File Offset: 0x000AD750
		// (set) Token: 0x06002909 RID: 10505 RVA: 0x000AF558 File Offset: 0x000AD758
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x0600290A RID: 10506 RVA: 0x000AF564 File Offset: 0x000AD764
		// (set) Token: 0x0600290B RID: 10507 RVA: 0x000AF56C File Offset: 0x000AD76C
		[ProtoMember(4, IsRequired = true, Name = "NameStrKey", DataFormat = DataFormat.Default)]
		public string NameStrKey
		{
			get
			{
				return this._NameStrKey;
			}
			set
			{
				this._NameStrKey = value;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x000AF578 File Offset: 0x000AD778
		// (set) Token: 0x0600290D RID: 10509 RVA: 0x000AF580 File Offset: 0x000AD780
		[ProtoMember(5, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x0600290E RID: 10510 RVA: 0x000AF58C File Offset: 0x000AD78C
		// (set) Token: 0x0600290F RID: 10511 RVA: 0x000AF594 File Offset: 0x000AD794
		[ProtoMember(6, IsRequired = true, Name = "DescStrKey", DataFormat = DataFormat.Default)]
		public string DescStrKey
		{
			get
			{
				return this._DescStrKey;
			}
			set
			{
				this._DescStrKey = value;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002910 RID: 10512 RVA: 0x000AF5A0 File Offset: 0x000AD7A0
		[ProtoMember(7, Name = "Waypoints_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> Waypoints_ID
		{
			get
			{
				return this._Waypoints_ID;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x000AF5A8 File Offset: 0x000AD7A8
		// (set) Token: 0x06002912 RID: 10514 RVA: 0x000AF5B0 File Offset: 0x000AD7B0
		[ProtoMember(8, IsRequired = true, Name = "OpenByScenario_ID", DataFormat = DataFormat.TwosComplement)]
		public int OpenByScenario_ID
		{
			get
			{
				return this._OpenByScenario_ID;
			}
			set
			{
				this._OpenByScenario_ID = value;
			}
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000AF5BC File Offset: 0x000AD7BC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000AF5CC File Offset: 0x000AD7CC
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

		// Token: 0x06002915 RID: 10517 RVA: 0x000AF698 File Offset: 0x000AD898
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRegionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400193B RID: 6459
		private int _ID;

		// Token: 0x0400193C RID: 6460
		private string _Name;

		// Token: 0x0400193D RID: 6461
		private string _NameStrKey;

		// Token: 0x0400193E RID: 6462
		private string _Desc;

		// Token: 0x0400193F RID: 6463
		private string _DescStrKey;

		// Token: 0x04001940 RID: 6464
		private readonly List<int> _Waypoints_ID = new List<int>();

		// Token: 0x04001941 RID: 6465
		private int _OpenByScenario_ID;

		// Token: 0x04001942 RID: 6466
		private IExtension extensionObject;

		// Token: 0x04001943 RID: 6467
		public ConfigDataWaypointInfo[] m_waypointInfos;

		// Token: 0x04001944 RID: 6468
		public ConfigDataScenarioInfo m_openByScenarioInfo;

		// Token: 0x04001945 RID: 6469
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001946 RID: 6470
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001947 RID: 6471
		private LuaFunction m_ctor_hotfix;
	}
}
