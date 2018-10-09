using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007F8 RID: 2040
	[ProtoContract(Name = "NoviceClaimRewardReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class NoviceClaimRewardReq : IExtensible
	{
		// Token: 0x06006782 RID: 26498 RVA: 0x001CCAB0 File Offset: 0x001CACB0
		public NoviceClaimRewardReq()
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

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x06006783 RID: 26499 RVA: 0x001CCB18 File Offset: 0x001CAD18
		// (set) Token: 0x06006784 RID: 26500 RVA: 0x001CCB20 File Offset: 0x001CAD20
		[ProtoMember(1, IsRequired = true, Name = "Slot", DataFormat = DataFormat.TwosComplement)]
		public int Slot
		{
			get
			{
				return this._Slot;
			}
			set
			{
				this._Slot = value;
			}
		}

		// Token: 0x06006785 RID: 26501 RVA: 0x001CCB2C File Offset: 0x001CAD2C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x001CCB3C File Offset: 0x001CAD3C
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

		// Token: 0x06006787 RID: 26503 RVA: 0x001CCC08 File Offset: 0x001CAE08
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(NoviceClaimRewardReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D89 RID: 19849
		private int _Slot;

		// Token: 0x04004D8A RID: 19850
		private IExtension extensionObject;

		// Token: 0x04004D8B RID: 19851
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D8C RID: 19852
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D8D RID: 19853
		private LuaFunction m_ctor_hotfix;
	}
}
