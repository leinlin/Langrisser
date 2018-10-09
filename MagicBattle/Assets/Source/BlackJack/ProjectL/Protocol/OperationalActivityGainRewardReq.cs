using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007FE RID: 2046
	[ProtoContract(Name = "OperationalActivityGainRewardReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class OperationalActivityGainRewardReq : IExtensible
	{
		// Token: 0x060067AA RID: 26538 RVA: 0x001CD558 File Offset: 0x001CB758
		public OperationalActivityGainRewardReq()
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

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x060067AB RID: 26539 RVA: 0x001CD5C0 File Offset: 0x001CB7C0
		// (set) Token: 0x060067AC RID: 26540 RVA: 0x001CD5C8 File Offset: 0x001CB7C8
		[ProtoMember(1, IsRequired = true, Name = "OperationalActivityInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong OperationalActivityInstanceId
		{
			get
			{
				return this._OperationalActivityInstanceId;
			}
			set
			{
				this._OperationalActivityInstanceId = value;
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x060067AD RID: 26541 RVA: 0x001CD5D4 File Offset: 0x001CB7D4
		// (set) Token: 0x060067AE RID: 26542 RVA: 0x001CD5DC File Offset: 0x001CB7DC
		[ProtoMember(2, IsRequired = true, Name = "RewardIndex", DataFormat = DataFormat.TwosComplement)]
		public int RewardIndex
		{
			get
			{
				return this._RewardIndex;
			}
			set
			{
				this._RewardIndex = value;
			}
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x001CD5E8 File Offset: 0x001CB7E8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x001CD5F8 File Offset: 0x001CB7F8
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

		// Token: 0x060067B1 RID: 26545 RVA: 0x001CD6C4 File Offset: 0x001CB8C4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OperationalActivityGainRewardReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004DA9 RID: 19881
		private ulong _OperationalActivityInstanceId;

		// Token: 0x04004DAA RID: 19882
		private int _RewardIndex;

		// Token: 0x04004DAB RID: 19883
		private IExtension extensionObject;

		// Token: 0x04004DAC RID: 19884
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004DAD RID: 19885
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004DAE RID: 19886
		private LuaFunction m_ctor_hotfix;
	}
}
