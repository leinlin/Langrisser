using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200064B RID: 1611
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProTeam")]
	[Serializable]
	public class ProTeam : IExtensible
	{
		// Token: 0x06005801 RID: 22529 RVA: 0x00199E5C File Offset: 0x0019805C
		public ProTeam()
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

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06005802 RID: 22530 RVA: 0x00199ED0 File Offset: 0x001980D0
		// (set) Token: 0x06005803 RID: 22531 RVA: 0x00199ED8 File Offset: 0x001980D8
		[ProtoMember(1, IsRequired = true, Name = "BattleType", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06005804 RID: 22532 RVA: 0x00199EE4 File Offset: 0x001980E4
		[ProtoMember(2, Name = "heroes", DataFormat = DataFormat.TwosComplement)]
		public List<int> Heroes
		{
			get
			{
				return this._heroes;
			}
		}

		// Token: 0x06005805 RID: 22533 RVA: 0x00199EEC File Offset: 0x001980EC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005806 RID: 22534 RVA: 0x00199EFC File Offset: 0x001980FC
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

		// Token: 0x06005807 RID: 22535 RVA: 0x00199FC8 File Offset: 0x001981C8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProTeam));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004214 RID: 16916
		private int _BattleType;

		// Token: 0x04004215 RID: 16917
		private readonly List<int> _heroes = new List<int>();

		// Token: 0x04004216 RID: 16918
		private IExtension extensionObject;

		// Token: 0x04004217 RID: 16919
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004218 RID: 16920
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004219 RID: 16921
		private LuaFunction m_ctor_hotfix;
	}
}
