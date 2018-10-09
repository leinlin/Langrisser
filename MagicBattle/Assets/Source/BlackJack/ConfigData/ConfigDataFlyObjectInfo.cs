using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000232 RID: 562
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataFlyObjectInfo")]
	[Serializable]
	public class ConfigDataFlyObjectInfo : IExtensible
	{
		// Token: 0x06002264 RID: 8804 RVA: 0x000A3678 File Offset: 0x000A1878
		public ConfigDataFlyObjectInfo()
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

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x000A36E0 File Offset: 0x000A18E0
		// (set) Token: 0x06002266 RID: 8806 RVA: 0x000A36E8 File Offset: 0x000A18E8
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

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06002267 RID: 8807 RVA: 0x000A36F4 File Offset: 0x000A18F4
		// (set) Token: 0x06002268 RID: 8808 RVA: 0x000A36FC File Offset: 0x000A18FC
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

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06002269 RID: 8809 RVA: 0x000A3708 File Offset: 0x000A1908
		// (set) Token: 0x0600226A RID: 8810 RVA: 0x000A3710 File Offset: 0x000A1910
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

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x000A371C File Offset: 0x000A191C
		// (set) Token: 0x0600226C RID: 8812 RVA: 0x000A3724 File Offset: 0x000A1924
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

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x000A3730 File Offset: 0x000A1930
		// (set) Token: 0x0600226E RID: 8814 RVA: 0x000A3738 File Offset: 0x000A1938
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

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600226F RID: 8815 RVA: 0x000A3744 File Offset: 0x000A1944
		// (set) Token: 0x06002270 RID: 8816 RVA: 0x000A374C File Offset: 0x000A194C
		[ProtoMember(7, IsRequired = true, Name = "Speed", DataFormat = DataFormat.TwosComplement)]
		public int Speed
		{
			get
			{
				return this._Speed;
			}
			set
			{
				this._Speed = value;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06002271 RID: 8817 RVA: 0x000A3758 File Offset: 0x000A1958
		// (set) Token: 0x06002272 RID: 8818 RVA: 0x000A3760 File Offset: 0x000A1960
		[ProtoMember(8, IsRequired = true, Name = "Distance", DataFormat = DataFormat.TwosComplement)]
		public int Distance
		{
			get
			{
				return this._Distance;
			}
			set
			{
				this._Distance = value;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x000A376C File Offset: 0x000A196C
		// (set) Token: 0x06002274 RID: 8820 RVA: 0x000A3774 File Offset: 0x000A1974
		[ProtoMember(9, IsRequired = true, Name = "TrackType", DataFormat = DataFormat.TwosComplement)]
		public TrackType TrackType
		{
			get
			{
				return this._TrackType;
			}
			set
			{
				this._TrackType = value;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06002275 RID: 8821 RVA: 0x000A3780 File Offset: 0x000A1980
		// (set) Token: 0x06002276 RID: 8822 RVA: 0x000A3788 File Offset: 0x000A1988
		[ProtoMember(10, IsRequired = true, Name = "Gravity", DataFormat = DataFormat.TwosComplement)]
		public int Gravity
		{
			get
			{
				return this._Gravity;
			}
			set
			{
				this._Gravity = value;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x000A3794 File Offset: 0x000A1994
		// (set) Token: 0x06002278 RID: 8824 RVA: 0x000A379C File Offset: 0x000A199C
		[ProtoMember(11, IsRequired = true, Name = "CollisionRadius", DataFormat = DataFormat.TwosComplement)]
		public int CollisionRadius
		{
			get
			{
				return this._CollisionRadius;
			}
			set
			{
				this._CollisionRadius = value;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x000A37A8 File Offset: 0x000A19A8
		// (set) Token: 0x0600227A RID: 8826 RVA: 0x000A37B0 File Offset: 0x000A19B0
		[ProtoMember(12, IsRequired = true, Name = "Model", DataFormat = DataFormat.Default)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				this._Model = value;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x000A37BC File Offset: 0x000A19BC
		// (set) Token: 0x0600227C RID: 8828 RVA: 0x000A37C4 File Offset: 0x000A19C4
		[ProtoMember(13, IsRequired = true, Name = "ModelScale", DataFormat = DataFormat.TwosComplement)]
		public int ModelScale
		{
			get
			{
				return this._ModelScale;
			}
			set
			{
				this._ModelScale = value;
			}
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x000A37D0 File Offset: 0x000A19D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x000A37E0 File Offset: 0x000A19E0
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

		// Token: 0x0600227F RID: 8831 RVA: 0x000A38AC File Offset: 0x000A1AAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataFlyObjectInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040014D2 RID: 5330
		private int _ID;

		// Token: 0x040014D3 RID: 5331
		private string _Name;

		// Token: 0x040014D4 RID: 5332
		private string _NameStrKey;

		// Token: 0x040014D5 RID: 5333
		private string _Desc;

		// Token: 0x040014D6 RID: 5334
		private string _DescStrKey;

		// Token: 0x040014D7 RID: 5335
		private int _Speed;

		// Token: 0x040014D8 RID: 5336
		private int _Distance;

		// Token: 0x040014D9 RID: 5337
		private TrackType _TrackType;

		// Token: 0x040014DA RID: 5338
		private int _Gravity;

		// Token: 0x040014DB RID: 5339
		private int _CollisionRadius;

		// Token: 0x040014DC RID: 5340
		private string _Model;

		// Token: 0x040014DD RID: 5341
		private int _ModelScale;

		// Token: 0x040014DE RID: 5342
		private IExtension extensionObject;

		// Token: 0x040014DF RID: 5343
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040014E0 RID: 5344
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040014E1 RID: 5345
		private LuaFunction m_ctor_hotfix;
	}
}
