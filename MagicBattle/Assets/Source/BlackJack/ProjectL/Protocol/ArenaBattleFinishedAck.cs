using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005C4 RID: 1476
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaBattleFinishedAck")]
	[Serializable]
	public class ArenaBattleFinishedAck : IExtensible
	{
		// Token: 0x0600533D RID: 21309 RVA: 0x00189FC8 File Offset: 0x001881C8
		public ArenaBattleFinishedAck()
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

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x0600533E RID: 21310 RVA: 0x0018A03C File Offset: 0x0018823C
		// (set) Token: 0x0600533F RID: 21311 RVA: 0x0018A044 File Offset: 0x00188244
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

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x06005340 RID: 21312 RVA: 0x0018A050 File Offset: 0x00188250
		// (set) Token: 0x06005341 RID: 21313 RVA: 0x0018A058 File Offset: 0x00188258
		[ProtoMember(2, IsRequired = true, Name = "Win", DataFormat = DataFormat.Default)]
		public bool Win
		{
			get
			{
				return this._Win;
			}
			set
			{
				this._Win = value;
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x06005342 RID: 21314 RVA: 0x0018A064 File Offset: 0x00188264
		// (set) Token: 0x06005343 RID: 21315 RVA: 0x0018A06C File Offset: 0x0018826C
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

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06005344 RID: 21316 RVA: 0x0018A078 File Offset: 0x00188278
		[ProtoMember(4, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x06005345 RID: 21317 RVA: 0x0018A080 File Offset: 0x00188280
		// (set) Token: 0x06005346 RID: 21318 RVA: 0x0018A088 File Offset: 0x00188288
		[DefaultValue(0f)]
		[ProtoMember(5, IsRequired = false, Name = "BattleReportInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong BattleReportInstanceId
		{
			get
			{
				return this._BattleReportInstanceId;
			}
			set
			{
				this._BattleReportInstanceId = value;
			}
		}

		// Token: 0x06005347 RID: 21319 RVA: 0x0018A094 File Offset: 0x00188294
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005348 RID: 21320 RVA: 0x0018A0A4 File Offset: 0x001882A4
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

		// Token: 0x06005349 RID: 21321 RVA: 0x0018A170 File Offset: 0x00188370
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaBattleFinishedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E89 RID: 16009
		private int _Result;

		// Token: 0x04003E8A RID: 16010
		private bool _Win;

		// Token: 0x04003E8B RID: 16011
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04003E8C RID: 16012
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04003E8D RID: 16013
		private ulong _BattleReportInstanceId;

		// Token: 0x04003E8E RID: 16014
		private IExtension extensionObject;

		// Token: 0x04003E8F RID: 16015
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E90 RID: 16016
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E91 RID: 16017
		private LuaFunction m_ctor_hotfix;
	}
}
