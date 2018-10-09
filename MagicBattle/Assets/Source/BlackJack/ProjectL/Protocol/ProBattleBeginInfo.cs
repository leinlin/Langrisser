using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200064A RID: 1610
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProBattleBeginInfo")]
	[Serializable]
	public class ProBattleBeginInfo : IExtensible
	{
		// Token: 0x060057FB RID: 22523 RVA: 0x00199C9C File Offset: 0x00197E9C
		public ProBattleBeginInfo()
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

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x060057FC RID: 22524 RVA: 0x00199D04 File Offset: 0x00197F04
		// (set) Token: 0x060057FD RID: 22525 RVA: 0x00199D0C File Offset: 0x00197F0C
		[ProtoMember(1, IsRequired = true, Name = "RandomSeed", DataFormat = DataFormat.TwosComplement)]
		public int RandomSeed
		{
			get
			{
				return this._RandomSeed;
			}
			set
			{
				this._RandomSeed = value;
			}
		}

		// Token: 0x060057FE RID: 22526 RVA: 0x00199D18 File Offset: 0x00197F18
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x00199D28 File Offset: 0x00197F28
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

		// Token: 0x06005800 RID: 22528 RVA: 0x00199DF4 File Offset: 0x00197FF4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProBattleBeginInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400420F RID: 16911
		private int _RandomSeed;

		// Token: 0x04004210 RID: 16912
		private IExtension extensionObject;

		// Token: 0x04004211 RID: 16913
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004212 RID: 16914
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004213 RID: 16915
		private LuaFunction m_ctor_hotfix;
	}
}
