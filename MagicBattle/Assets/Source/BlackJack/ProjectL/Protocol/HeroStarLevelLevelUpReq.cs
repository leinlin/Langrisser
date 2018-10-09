using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007A7 RID: 1959
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroStarLevelLevelUpReq")]
	[Serializable]
	public class HeroStarLevelLevelUpReq : IExtensible
	{
		// Token: 0x060064AB RID: 25771 RVA: 0x001C32F0 File Offset: 0x001C14F0
		public HeroStarLevelLevelUpReq()
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

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x060064AC RID: 25772 RVA: 0x001C3358 File Offset: 0x001C1558
		// (set) Token: 0x060064AD RID: 25773 RVA: 0x001C3360 File Offset: 0x001C1560
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

		// Token: 0x060064AE RID: 25774 RVA: 0x001C336C File Offset: 0x001C156C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x001C337C File Offset: 0x001C157C
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

		// Token: 0x060064B0 RID: 25776 RVA: 0x001C3448 File Offset: 0x001C1648
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroStarLevelLevelUpReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B74 RID: 19316
		private int _HeroId;

		// Token: 0x04004B75 RID: 19317
		private IExtension extensionObject;

		// Token: 0x04004B76 RID: 19318
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B77 RID: 19319
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B78 RID: 19320
		private LuaFunction m_ctor_hotfix;
	}
}
