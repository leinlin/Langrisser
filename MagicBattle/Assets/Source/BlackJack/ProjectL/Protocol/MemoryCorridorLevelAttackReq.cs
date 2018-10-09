using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007F1 RID: 2033
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "MemoryCorridorLevelAttackReq")]
	[Serializable]
	public class MemoryCorridorLevelAttackReq : IExtensible
	{
		// Token: 0x06006741 RID: 26433 RVA: 0x001CBD70 File Offset: 0x001C9F70
		public MemoryCorridorLevelAttackReq()
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

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x06006742 RID: 26434 RVA: 0x001CBDD8 File Offset: 0x001C9FD8
		// (set) Token: 0x06006743 RID: 26435 RVA: 0x001CBDE0 File Offset: 0x001C9FE0
		[ProtoMember(1, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
		public int LevelId
		{
			get
			{
				return this._LevelId;
			}
			set
			{
				this._LevelId = value;
			}
		}

		// Token: 0x06006744 RID: 26436 RVA: 0x001CBDEC File Offset: 0x001C9FEC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006745 RID: 26437 RVA: 0x001CBDFC File Offset: 0x001C9FFC
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

		// Token: 0x06006746 RID: 26438 RVA: 0x001CBEC8 File Offset: 0x001CA0C8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MemoryCorridorLevelAttackReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D59 RID: 19801
		private int _LevelId;

		// Token: 0x04004D5A RID: 19802
		private IExtension extensionObject;

		// Token: 0x04004D5B RID: 19803
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D5C RID: 19804
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D5D RID: 19805
		private LuaFunction m_ctor_hotfix;
	}
}
