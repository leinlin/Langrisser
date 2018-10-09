using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005E0 RID: 1504
	[ProtoContract(Name = "BattleTeamSetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleTeamSetReq : IExtensible
	{
		// Token: 0x06005428 RID: 21544 RVA: 0x0018D3C0 File Offset: 0x0018B5C0
		public BattleTeamSetReq()
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

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06005429 RID: 21545 RVA: 0x0018D434 File Offset: 0x0018B634
		// (set) Token: 0x0600542A RID: 21546 RVA: 0x0018D43C File Offset: 0x0018B63C
		[ProtoMember(1, IsRequired = true, Name = "BattleId", DataFormat = DataFormat.TwosComplement)]
		public int BattleId
		{
			get
			{
				return this._BattleId;
			}
			set
			{
				this._BattleId = value;
			}
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x0600542B RID: 21547 RVA: 0x0018D448 File Offset: 0x0018B648
		// (set) Token: 0x0600542C RID: 21548 RVA: 0x0018D450 File Offset: 0x0018B650
		[ProtoMember(2, IsRequired = true, Name = "BattleType", DataFormat = DataFormat.TwosComplement)]
		public int BattleType
		{
			get
			{
				return this._BattleType;
			}
			set
			{
				this._BattleType = value;
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x0600542D RID: 21549 RVA: 0x0018D45C File Offset: 0x0018B65C
		[ProtoMember(3, Name = "HeroIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> HeroIds
		{
			get
			{
				return this._HeroIds;
			}
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x0018D464 File Offset: 0x0018B664
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x0018D474 File Offset: 0x0018B674
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

		// Token: 0x06005430 RID: 21552 RVA: 0x0018D540 File Offset: 0x0018B740
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleTeamSetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F3B RID: 16187
		private int _BattleId;

		// Token: 0x04003F3C RID: 16188
		private int _BattleType;

		// Token: 0x04003F3D RID: 16189
		private readonly List<int> _HeroIds = new List<int>();

		// Token: 0x04003F3E RID: 16190
		private IExtension extensionObject;

		// Token: 0x04003F3F RID: 16191
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F40 RID: 16192
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F41 RID: 16193
		private LuaFunction m_ctor_hotfix;
	}
}
