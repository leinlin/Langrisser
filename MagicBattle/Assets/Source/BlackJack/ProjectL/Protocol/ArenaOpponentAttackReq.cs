using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005B6 RID: 1462
	[ProtoContract(Name = "ArenaOpponentAttackReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ArenaOpponentAttackReq : IExtensible
	{
		// Token: 0x060052D3 RID: 21203 RVA: 0x00188658 File Offset: 0x00186858
		public ArenaOpponentAttackReq()
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

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x060052D4 RID: 21204 RVA: 0x001886C0 File Offset: 0x001868C0
		// (set) Token: 0x060052D5 RID: 21205 RVA: 0x001886C8 File Offset: 0x001868C8
		[ProtoMember(1, IsRequired = true, Name = "AutoBattle", DataFormat = DataFormat.Default)]
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

		// Token: 0x060052D6 RID: 21206 RVA: 0x001886D4 File Offset: 0x001868D4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x001886E4 File Offset: 0x001868E4
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

		// Token: 0x060052D8 RID: 21208 RVA: 0x001887B0 File Offset: 0x001869B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaOpponentAttackReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E37 RID: 15927
		private bool _AutoBattle;

		// Token: 0x04003E38 RID: 15928
		private IExtension extensionObject;

		// Token: 0x04003E39 RID: 15929
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E3A RID: 15930
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E3B RID: 15931
		private LuaFunction m_ctor_hotfix;
	}
}
