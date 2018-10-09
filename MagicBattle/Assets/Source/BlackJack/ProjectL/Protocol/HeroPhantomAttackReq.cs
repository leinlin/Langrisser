using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007A1 RID: 1953
	[ProtoContract(Name = "HeroPhantomAttackReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroPhantomAttackReq : IExtensible
	{
		// Token: 0x06006472 RID: 25714 RVA: 0x001C2784 File Offset: 0x001C0984
		public HeroPhantomAttackReq()
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

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x06006473 RID: 25715 RVA: 0x001C27EC File Offset: 0x001C09EC
		// (set) Token: 0x06006474 RID: 25716 RVA: 0x001C27F4 File Offset: 0x001C09F4
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

		// Token: 0x06006475 RID: 25717 RVA: 0x001C2800 File Offset: 0x001C0A00
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006476 RID: 25718 RVA: 0x001C2810 File Offset: 0x001C0A10
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

		// Token: 0x06006477 RID: 25719 RVA: 0x001C28DC File Offset: 0x001C0ADC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroPhantomAttackReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B4A RID: 19274
		private int _LevelId;

		// Token: 0x04004B4B RID: 19275
		private IExtension extensionObject;

		// Token: 0x04004B4C RID: 19276
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B4D RID: 19277
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B4E RID: 19278
		private LuaFunction m_ctor_hotfix;
	}
}
