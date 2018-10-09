using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200068D RID: 1677
	[ProtoContract(Name = "ProNovice")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProNovice : IExtensible
	{
		// Token: 0x06005B3E RID: 23358 RVA: 0x001A24B8 File Offset: 0x001A06B8
		public ProNovice()
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

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06005B3F RID: 23359 RVA: 0x001A252C File Offset: 0x001A072C
		// (set) Token: 0x06005B40 RID: 23360 RVA: 0x001A2534 File Offset: 0x001A0734
		[ProtoMember(1, IsRequired = true, Name = "MissionPoints", DataFormat = DataFormat.TwosComplement)]
		public int MissionPoints
		{
			get
			{
				return this._MissionPoints;
			}
			set
			{
				this._MissionPoints = value;
			}
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06005B41 RID: 23361 RVA: 0x001A2540 File Offset: 0x001A0740
		[ProtoMember(2, Name = "RewardClaimedSlots", DataFormat = DataFormat.TwosComplement)]
		public List<int> RewardClaimedSlots
		{
			get
			{
				return this._RewardClaimedSlots;
			}
		}

		// Token: 0x06005B42 RID: 23362 RVA: 0x001A2548 File Offset: 0x001A0748
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B43 RID: 23363 RVA: 0x001A2558 File Offset: 0x001A0758
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

		// Token: 0x06005B44 RID: 23364 RVA: 0x001A2624 File Offset: 0x001A0824
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProNovice));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400444E RID: 17486
		private int _MissionPoints;

		// Token: 0x0400444F RID: 17487
		private readonly List<int> _RewardClaimedSlots = new List<int>();

		// Token: 0x04004450 RID: 17488
		private IExtension extensionObject;

		// Token: 0x04004451 RID: 17489
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004452 RID: 17490
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004453 RID: 17491
		private LuaFunction m_ctor_hotfix;
	}
}
