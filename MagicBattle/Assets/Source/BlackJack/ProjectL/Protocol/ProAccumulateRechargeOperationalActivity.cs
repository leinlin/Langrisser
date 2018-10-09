using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200069D RID: 1693
	[ProtoContract(Name = "ProAccumulateRechargeOperationalActivity")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProAccumulateRechargeOperationalActivity : IExtensible
	{
		// Token: 0x06005BE5 RID: 23525 RVA: 0x001A43F0 File Offset: 0x001A25F0
		public ProAccumulateRechargeOperationalActivity()
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

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06005BE6 RID: 23526 RVA: 0x001A4464 File Offset: 0x001A2664
		// (set) Token: 0x06005BE7 RID: 23527 RVA: 0x001A446C File Offset: 0x001A266C
		[ProtoMember(1, IsRequired = true, Name = "BasicInfo", DataFormat = DataFormat.Default)]
		public ProOperationalActivityBasicInfo BasicInfo
		{
			get
			{
				return this._BasicInfo;
			}
			set
			{
				this._BasicInfo = value;
			}
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06005BE8 RID: 23528 RVA: 0x001A4478 File Offset: 0x001A2678
		// (set) Token: 0x06005BE9 RID: 23529 RVA: 0x001A4480 File Offset: 0x001A2680
		[ProtoMember(2, IsRequired = true, Name = "AccumulateRechargeRMB", DataFormat = DataFormat.TwosComplement)]
		public int AccumulateRechargeRMB
		{
			get
			{
				return this._AccumulateRechargeRMB;
			}
			set
			{
				this._AccumulateRechargeRMB = value;
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x06005BEA RID: 23530 RVA: 0x001A448C File Offset: 0x001A268C
		[ProtoMember(3, Name = "GainRewardIndexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> GainRewardIndexs
		{
			get
			{
				return this._GainRewardIndexs;
			}
		}

		// Token: 0x06005BEB RID: 23531 RVA: 0x001A4494 File Offset: 0x001A2694
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005BEC RID: 23532 RVA: 0x001A44A4 File Offset: 0x001A26A4
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

		// Token: 0x06005BED RID: 23533 RVA: 0x001A4570 File Offset: 0x001A2770
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProAccumulateRechargeOperationalActivity));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040044C8 RID: 17608
		private ProOperationalActivityBasicInfo _BasicInfo;

		// Token: 0x040044C9 RID: 17609
		private int _AccumulateRechargeRMB;

		// Token: 0x040044CA RID: 17610
		private readonly List<int> _GainRewardIndexs = new List<int>();

		// Token: 0x040044CB RID: 17611
		private IExtension extensionObject;

		// Token: 0x040044CC RID: 17612
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040044CD RID: 17613
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040044CE RID: 17614
		private LuaFunction m_ctor_hotfix;
	}
}
