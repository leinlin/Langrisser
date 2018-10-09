using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007AD RID: 1965
	[ProtoContract(Name = "HeroSoldierSelectReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroSoldierSelectReq : IExtensible
	{
		// Token: 0x060064DB RID: 25819 RVA: 0x001C3DFC File Offset: 0x001C1FFC
		public HeroSoldierSelectReq()
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

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x060064DC RID: 25820 RVA: 0x001C3E64 File Offset: 0x001C2064
		// (set) Token: 0x060064DD RID: 25821 RVA: 0x001C3E6C File Offset: 0x001C206C
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

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x060064DE RID: 25822 RVA: 0x001C3E78 File Offset: 0x001C2078
		// (set) Token: 0x060064DF RID: 25823 RVA: 0x001C3E80 File Offset: 0x001C2080
		[ProtoMember(2, IsRequired = true, Name = "SoldierId", DataFormat = DataFormat.TwosComplement)]
		public int SoldierId
		{
			get
			{
				return this._SoldierId;
			}
			set
			{
				this._SoldierId = value;
			}
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x001C3E8C File Offset: 0x001C208C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x001C3E9C File Offset: 0x001C209C
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

		// Token: 0x060064E2 RID: 25826 RVA: 0x001C3F68 File Offset: 0x001C2168
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroSoldierSelectReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B99 RID: 19353
		private int _HeroId;

		// Token: 0x04004B9A RID: 19354
		private int _SoldierId;

		// Token: 0x04004B9B RID: 19355
		private IExtension extensionObject;

		// Token: 0x04004B9C RID: 19356
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B9D RID: 19357
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B9E RID: 19358
		private LuaFunction m_ctor_hotfix;
	}
}
