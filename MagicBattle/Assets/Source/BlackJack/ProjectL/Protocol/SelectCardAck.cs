using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000821 RID: 2081
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "SelectCardAck")]
	[Serializable]
	public class SelectCardAck : IExtensible
	{
		// Token: 0x060068DC RID: 26844 RVA: 0x001D8AB8 File Offset: 0x001D6CB8
		public SelectCardAck()
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

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x060068DD RID: 26845 RVA: 0x001D8B2C File Offset: 0x001D6D2C
		// (set) Token: 0x060068DE RID: 26846 RVA: 0x001D8B34 File Offset: 0x001D6D34
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

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x060068DF RID: 26847 RVA: 0x001D8B40 File Offset: 0x001D6D40
		// (set) Token: 0x060068E0 RID: 26848 RVA: 0x001D8B48 File Offset: 0x001D6D48
		[ProtoMember(2, IsRequired = true, Name = "CardPoolId", DataFormat = DataFormat.TwosComplement)]
		public int CardPoolId
		{
			get
			{
				return this._CardPoolId;
			}
			set
			{
				this._CardPoolId = value;
			}
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x060068E1 RID: 26849 RVA: 0x001D8B54 File Offset: 0x001D6D54
		// (set) Token: 0x060068E2 RID: 26850 RVA: 0x001D8B5C File Offset: 0x001D6D5C
		[ProtoMember(3, IsRequired = true, Name = "IsSingleSelect", DataFormat = DataFormat.Default)]
		public bool IsSingleSelect
		{
			get
			{
				return this._IsSingleSelect;
			}
			set
			{
				this._IsSingleSelect = value;
			}
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x060068E3 RID: 26851 RVA: 0x001D8B68 File Offset: 0x001D6D68
		// (set) Token: 0x060068E4 RID: 26852 RVA: 0x001D8B70 File Offset: 0x001D6D70
		[ProtoMember(4, IsRequired = true, Name = "IsUsingTicket", DataFormat = DataFormat.Default)]
		public bool IsUsingTicket
		{
			get
			{
				return this._IsUsingTicket;
			}
			set
			{
				this._IsUsingTicket = value;
			}
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x060068E5 RID: 26853 RVA: 0x001D8B7C File Offset: 0x001D6D7C
		// (set) Token: 0x060068E6 RID: 26854 RVA: 0x001D8B84 File Offset: 0x001D6D84
		[DefaultValue(null)]
		[ProtoMember(5, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x060068E7 RID: 26855 RVA: 0x001D8B90 File Offset: 0x001D6D90
		[ProtoMember(6, Name = "SelectedGoods", DataFormat = DataFormat.Default)]
		public List<ProGoods> SelectedGoods
		{
			get
			{
				return this._SelectedGoods;
			}
		}

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x060068E8 RID: 26856 RVA: 0x001D8B98 File Offset: 0x001D6D98
		// (set) Token: 0x060068E9 RID: 26857 RVA: 0x001D8BA0 File Offset: 0x001D6DA0
		[ProtoMember(7, IsRequired = true, Name = "GuaranteedAccumulatedValue", DataFormat = DataFormat.TwosComplement)]
		public int GuaranteedAccumulatedValue
		{
			get
			{
				return this._GuaranteedAccumulatedValue;
			}
			set
			{
				this._GuaranteedAccumulatedValue = value;
			}
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x060068EA RID: 26858 RVA: 0x001D8BAC File Offset: 0x001D6DAC
		// (set) Token: 0x060068EB RID: 26859 RVA: 0x001D8BB4 File Offset: 0x001D6DB4
		[ProtoMember(8, IsRequired = true, Name = "GuaranteedSelectCardCount", DataFormat = DataFormat.TwosComplement)]
		public int GuaranteedSelectCardCount
		{
			get
			{
				return this._GuaranteedSelectCardCount;
			}
			set
			{
				this._GuaranteedSelectCardCount = value;
			}
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x001D8BC0 File Offset: 0x001D6DC0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x001D8BD0 File Offset: 0x001D6DD0
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

		// Token: 0x060068EE RID: 26862 RVA: 0x001D8C9C File Offset: 0x001D6E9C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SelectCardAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040050CD RID: 20685
		private int _Result;

		// Token: 0x040050CE RID: 20686
		private int _CardPoolId;

		// Token: 0x040050CF RID: 20687
		private bool _IsSingleSelect;

		// Token: 0x040050D0 RID: 20688
		private bool _IsUsingTicket;

		// Token: 0x040050D1 RID: 20689
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x040050D2 RID: 20690
		private readonly List<ProGoods> _SelectedGoods = new List<ProGoods>();

		// Token: 0x040050D3 RID: 20691
		private int _GuaranteedAccumulatedValue;

		// Token: 0x040050D4 RID: 20692
		private int _GuaranteedSelectCardCount;

		// Token: 0x040050D5 RID: 20693
		private IExtension extensionObject;

		// Token: 0x040050D6 RID: 20694
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050D7 RID: 20695
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040050D8 RID: 20696
		private LuaFunction m_ctor_hotfix;
	}
}
