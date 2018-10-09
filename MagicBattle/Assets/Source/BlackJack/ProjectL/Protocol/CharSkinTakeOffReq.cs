using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007C9 RID: 1993
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "CharSkinTakeOffReq")]
	[Serializable]
	public class CharSkinTakeOffReq : IExtensible
	{
		// Token: 0x060065E4 RID: 26084 RVA: 0x001C72D0 File Offset: 0x001C54D0
		public CharSkinTakeOffReq()
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

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x060065E5 RID: 26085 RVA: 0x001C7338 File Offset: 0x001C5538
		// (set) Token: 0x060065E6 RID: 26086 RVA: 0x001C7340 File Offset: 0x001C5540
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x060065E7 RID: 26087 RVA: 0x001C734C File Offset: 0x001C554C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060065E8 RID: 26088 RVA: 0x001C735C File Offset: 0x001C555C
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

		// Token: 0x060065E9 RID: 26089 RVA: 0x001C7428 File Offset: 0x001C5628
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CharSkinTakeOffReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C56 RID: 19542
		private int _HeroId;

		// Token: 0x04004C57 RID: 19543
		private IExtension extensionObject;

		// Token: 0x04004C58 RID: 19544
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C59 RID: 19545
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C5A RID: 19546
		private LuaFunction m_ctor_hotfix;
	}
}
