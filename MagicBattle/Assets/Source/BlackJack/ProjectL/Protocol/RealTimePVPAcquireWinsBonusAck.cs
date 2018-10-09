using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000816 RID: 2070
	[ProtoContract(Name = "RealTimePVPAcquireWinsBonusAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RealTimePVPAcquireWinsBonusAck : IExtensible
	{
		// Token: 0x0600686D RID: 26733 RVA: 0x001D7578 File Offset: 0x001D5778
		public RealTimePVPAcquireWinsBonusAck()
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

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x0600686E RID: 26734 RVA: 0x001D75EC File Offset: 0x001D57EC
		// (set) Token: 0x0600686F RID: 26735 RVA: 0x001D75F4 File Offset: 0x001D57F4
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

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x06006870 RID: 26736 RVA: 0x001D7600 File Offset: 0x001D5800
		// (set) Token: 0x06006871 RID: 26737 RVA: 0x001D7608 File Offset: 0x001D5808
		[ProtoMember(2, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public RealTimePVPAcquireWinsBonusReq Req
		{
			get
			{
				return this._Req;
			}
			set
			{
				this._Req = value;
			}
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x06006872 RID: 26738 RVA: 0x001D7614 File Offset: 0x001D5814
		// (set) Token: 0x06006873 RID: 26739 RVA: 0x001D761C File Offset: 0x001D581C
		[DefaultValue(null)]
		[ProtoMember(3, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x06006874 RID: 26740 RVA: 0x001D7628 File Offset: 0x001D5828
		[ProtoMember(4, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x001D7630 File Offset: 0x001D5830
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x001D7640 File Offset: 0x001D5840
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

		// Token: 0x06006877 RID: 26743 RVA: 0x001D770C File Offset: 0x001D590C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPAcquireWinsBonusAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400507C RID: 20604
		private int _Result;

		// Token: 0x0400507D RID: 20605
		private RealTimePVPAcquireWinsBonusReq _Req;

		// Token: 0x0400507E RID: 20606
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x0400507F RID: 20607
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04005080 RID: 20608
		private IExtension extensionObject;

		// Token: 0x04005081 RID: 20609
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005082 RID: 20610
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005083 RID: 20611
		private LuaFunction m_ctor_hotfix;
	}
}
