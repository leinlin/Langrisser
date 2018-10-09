using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005B7 RID: 1463
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaOpponentAttackAck")]
	[Serializable]
	public class ArenaOpponentAttackAck : IExtensible
	{
		// Token: 0x060052D9 RID: 21209 RVA: 0x00188818 File Offset: 0x00186A18
		public ArenaOpponentAttackAck()
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

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x060052DA RID: 21210 RVA: 0x00188880 File Offset: 0x00186A80
		// (set) Token: 0x060052DB RID: 21211 RVA: 0x00188888 File Offset: 0x00186A88
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

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x060052DC RID: 21212 RVA: 0x00188894 File Offset: 0x00186A94
		// (set) Token: 0x060052DD RID: 21213 RVA: 0x0018889C File Offset: 0x00186A9C
		[ProtoMember(2, IsRequired = true, Name = "AutoBattle", DataFormat = DataFormat.Default)]
		public bool AutoBattle
		{
			get
			{
				return this._AutoBattle;
			}
			set
			{
				this._AutoBattle = value;
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x060052DE RID: 21214 RVA: 0x001888A8 File Offset: 0x00186AA8
		// (set) Token: 0x060052DF RID: 21215 RVA: 0x001888B0 File Offset: 0x00186AB0
		[ProtoMember(3, IsRequired = false, Name = "OpponentDefensiveBattleInfo", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public ProArenaDefensiveBattleInfo OpponentDefensiveBattleInfo
		{
			get
			{
				return this._OpponentDefensiveBattleInfo;
			}
			set
			{
				this._OpponentDefensiveBattleInfo = value;
			}
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x001888BC File Offset: 0x00186ABC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x001888CC File Offset: 0x00186ACC
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

		// Token: 0x060052E2 RID: 21218 RVA: 0x00188998 File Offset: 0x00186B98
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaOpponentAttackAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E3C RID: 15932
		private int _Result;

		// Token: 0x04003E3D RID: 15933
		private bool _AutoBattle;

		// Token: 0x04003E3E RID: 15934
		private ProArenaDefensiveBattleInfo _OpponentDefensiveBattleInfo;

		// Token: 0x04003E3F RID: 15935
		private IExtension extensionObject;

		// Token: 0x04003E40 RID: 15936
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E41 RID: 15937
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E42 RID: 15938
		private LuaFunction m_ctor_hotfix;
	}
}
