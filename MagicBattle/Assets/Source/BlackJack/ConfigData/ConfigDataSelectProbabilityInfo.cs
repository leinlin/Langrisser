using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000287 RID: 647
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSelectProbabilityInfo")]
	[Serializable]
	public class ConfigDataSelectProbabilityInfo : IExtensible
	{
		// Token: 0x06002A07 RID: 10759 RVA: 0x000B0A10 File Offset: 0x000AEC10
		public ConfigDataSelectProbabilityInfo()
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

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x000B0A78 File Offset: 0x000AEC78
		// (set) Token: 0x06002A09 RID: 10761 RVA: 0x000B0A80 File Offset: 0x000AEC80
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

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x000B0A8C File Offset: 0x000AEC8C
		// (set) Token: 0x06002A0B RID: 10763 RVA: 0x000B0A94 File Offset: 0x000AEC94
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

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002A0C RID: 10764 RVA: 0x000B0AA0 File Offset: 0x000AECA0
		// (set) Token: 0x06002A0D RID: 10765 RVA: 0x000B0AA8 File Offset: 0x000AECA8
		[ProtoMember(4, IsRequired = true, Name = "SSRCardProbability", DataFormat = DataFormat.Default)]
		public string SSRCardProbability
		{
			get
			{
				return this._SSRCardProbability;
			}
			set
			{
				this._SSRCardProbability = value;
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002A0E RID: 10766 RVA: 0x000B0AB4 File Offset: 0x000AECB4
		// (set) Token: 0x06002A0F RID: 10767 RVA: 0x000B0ABC File Offset: 0x000AECBC
		[ProtoMember(5, IsRequired = true, Name = "SRCardProbability", DataFormat = DataFormat.Default)]
		public string SRCardProbability
		{
			get
			{
				return this._SRCardProbability;
			}
			set
			{
				this._SRCardProbability = value;
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002A10 RID: 10768 RVA: 0x000B0AC8 File Offset: 0x000AECC8
		// (set) Token: 0x06002A11 RID: 10769 RVA: 0x000B0AD0 File Offset: 0x000AECD0
		[ProtoMember(6, IsRequired = true, Name = "RCardProbability", DataFormat = DataFormat.Default)]
		public string RCardProbability
		{
			get
			{
				return this._RCardProbability;
			}
			set
			{
				this._RCardProbability = value;
			}
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x000B0ADC File Offset: 0x000AECDC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x000B0AEC File Offset: 0x000AECEC
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

		// Token: 0x06002A14 RID: 10772 RVA: 0x000B0BB8 File Offset: 0x000AEDB8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSelectProbabilityInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040019E2 RID: 6626
		private int _ID;

		// Token: 0x040019E3 RID: 6627
		private string _Name;

		// Token: 0x040019E4 RID: 6628
		private string _SSRCardProbability;

		// Token: 0x040019E5 RID: 6629
		private string _SRCardProbability;

		// Token: 0x040019E6 RID: 6630
		private string _RCardProbability;

		// Token: 0x040019E7 RID: 6631
		private IExtension extensionObject;

		// Token: 0x040019E8 RID: 6632
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040019E9 RID: 6633
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040019EA RID: 6634
		private LuaFunction m_ctor_hotfix;
	}
}
