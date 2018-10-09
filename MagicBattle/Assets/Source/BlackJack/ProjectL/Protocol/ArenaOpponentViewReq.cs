using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005B4 RID: 1460
	[ProtoContract(Name = "ArenaOpponentViewReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ArenaOpponentViewReq : IExtensible
	{
		// Token: 0x060052C2 RID: 21186 RVA: 0x0018829C File Offset: 0x0018649C
		public ArenaOpponentViewReq()
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

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x060052C3 RID: 21187 RVA: 0x00188304 File Offset: 0x00186504
		// (set) Token: 0x060052C4 RID: 21188 RVA: 0x0018830C File Offset: 0x0018650C
		[ProtoMember(1, IsRequired = true, Name = "OpponentIndex", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x060052C5 RID: 21189 RVA: 0x00188318 File Offset: 0x00186518
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x00188328 File Offset: 0x00186528
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

		// Token: 0x060052C7 RID: 21191 RVA: 0x001883F4 File Offset: 0x001865F4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaOpponentViewReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E2A RID: 15914
		private int _OpponentIndex;

		// Token: 0x04003E2B RID: 15915
		private IExtension extensionObject;

		// Token: 0x04003E2C RID: 15916
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E2D RID: 15917
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E2E RID: 15918
		private LuaFunction m_ctor_hotfix;
	}
}
