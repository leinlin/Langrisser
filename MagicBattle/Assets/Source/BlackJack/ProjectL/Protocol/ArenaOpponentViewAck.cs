using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005B5 RID: 1461
	[ProtoContract(Name = "ArenaOpponentViewAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ArenaOpponentViewAck : IExtensible
	{
		// Token: 0x060052C8 RID: 21192 RVA: 0x0018845C File Offset: 0x0018665C
		public ArenaOpponentViewAck()
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

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x060052C9 RID: 21193 RVA: 0x001884D0 File Offset: 0x001866D0
		// (set) Token: 0x060052CA RID: 21194 RVA: 0x001884D8 File Offset: 0x001866D8
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

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x060052CB RID: 21195 RVA: 0x001884E4 File Offset: 0x001866E4
		// (set) Token: 0x060052CC RID: 21196 RVA: 0x001884EC File Offset: 0x001866EC
		[ProtoMember(2, IsRequired = true, Name = "OpponentIndex", DataFormat = DataFormat.TwosComplement)]
		public int OpponentIndex
		{
			get
			{
				return this._OpponentIndex;
			}
			set
			{
				this._OpponentIndex = value;
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x060052CD RID: 21197 RVA: 0x001884F8 File Offset: 0x001866F8
		[ProtoMember(3, Name = "Heroes", DataFormat = DataFormat.Default)]
		public List<ProBattleHero> Heroes
		{
			get
			{
				return this._Heroes;
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x060052CE RID: 21198 RVA: 0x00188500 File Offset: 0x00186700
		// (set) Token: 0x060052CF RID: 21199 RVA: 0x00188508 File Offset: 0x00186708
		[DefaultValue(0)]
		[ProtoMember(4, IsRequired = false, Name = "BattlePower", DataFormat = DataFormat.TwosComplement)]
		public int BattlePower
		{
			get
			{
				return this._BattlePower;
			}
			set
			{
				this._BattlePower = value;
			}
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x00188514 File Offset: 0x00186714
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x00188524 File Offset: 0x00186724
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

		// Token: 0x060052D2 RID: 21202 RVA: 0x001885F0 File Offset: 0x001867F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaOpponentViewAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E2F RID: 15919
		private int _Result;

		// Token: 0x04003E30 RID: 15920
		private int _OpponentIndex;

		// Token: 0x04003E31 RID: 15921
		private readonly List<ProBattleHero> _Heroes = new List<ProBattleHero>();

		// Token: 0x04003E32 RID: 15922
		private int _BattlePower;

		// Token: 0x04003E33 RID: 15923
		private IExtension extensionObject;

		// Token: 0x04003E34 RID: 15924
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E35 RID: 15925
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E36 RID: 15926
		private LuaFunction m_ctor_hotfix;
	}
}
