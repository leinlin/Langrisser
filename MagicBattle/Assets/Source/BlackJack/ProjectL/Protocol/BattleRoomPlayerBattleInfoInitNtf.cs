using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200060B RID: 1547
	[ProtoContract(Name = "BattleRoomPlayerBattleInfoInitNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleRoomPlayerBattleInfoInitNtf : IExtensible
	{
		// Token: 0x060055A0 RID: 21920 RVA: 0x00192474 File Offset: 0x00190674
		public BattleRoomPlayerBattleInfoInitNtf()
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

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x060055A1 RID: 21921 RVA: 0x001924E8 File Offset: 0x001906E8
		// (set) Token: 0x060055A2 RID: 21922 RVA: 0x001924F0 File Offset: 0x001906F0
		[ProtoMember(1, IsRequired = true, Name = "SessionId", DataFormat = DataFormat.TwosComplement)]
		public ulong SessionId
		{
			get
			{
				return this._SessionId;
			}
			set
			{
				this._SessionId = value;
			}
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x060055A3 RID: 21923 RVA: 0x001924FC File Offset: 0x001906FC
		[ProtoMember(2, Name = "Techs", DataFormat = DataFormat.Default)]
		public List<ProTrainingTech> Techs
		{
			get
			{
				return this._Techs;
			}
		}

		// Token: 0x060055A4 RID: 21924 RVA: 0x00192504 File Offset: 0x00190704
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060055A5 RID: 21925 RVA: 0x00192514 File Offset: 0x00190714
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

		// Token: 0x060055A6 RID: 21926 RVA: 0x001925E0 File Offset: 0x001907E0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomPlayerBattleInfoInitNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004058 RID: 16472
		private ulong _SessionId;

		// Token: 0x04004059 RID: 16473
		private readonly List<ProTrainingTech> _Techs = new List<ProTrainingTech>();

		// Token: 0x0400405A RID: 16474
		private IExtension extensionObject;

		// Token: 0x0400405B RID: 16475
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400405C RID: 16476
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400405D RID: 16477
		private LuaFunction m_ctor_hotfix;
	}
}
