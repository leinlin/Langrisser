using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005D0 RID: 1488
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "SellBagItemReq")]
	[Serializable]
	public class SellBagItemReq : IExtensible
	{
		// Token: 0x060053AB RID: 21419 RVA: 0x0018B66C File Offset: 0x0018986C
		public SellBagItemReq()
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

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x060053AC RID: 21420 RVA: 0x0018B6D4 File Offset: 0x001898D4
		// (set) Token: 0x060053AD RID: 21421 RVA: 0x0018B6DC File Offset: 0x001898DC
		[ProtoMember(1, IsRequired = true, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong InstanceId
		{
			get
			{
				return this._InstanceId;
			}
			set
			{
				this._InstanceId = value;
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x060053AE RID: 21422 RVA: 0x0018B6E8 File Offset: 0x001898E8
		// (set) Token: 0x060053AF RID: 21423 RVA: 0x0018B6F0 File Offset: 0x001898F0
		[ProtoMember(2, IsRequired = true, Name = "Nums", DataFormat = DataFormat.TwosComplement)]
		public int Nums
		{
			get
			{
				return this._Nums;
			}
			set
			{
				this._Nums = value;
			}
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x0018B6FC File Offset: 0x001898FC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x0018B70C File Offset: 0x0018990C
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

		// Token: 0x060053B2 RID: 21426 RVA: 0x0018B7D8 File Offset: 0x001899D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SellBagItemReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003EDA RID: 16090
		private ulong _InstanceId;

		// Token: 0x04003EDB RID: 16091
		private int _Nums;

		// Token: 0x04003EDC RID: 16092
		private IExtension extensionObject;

		// Token: 0x04003EDD RID: 16093
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003EDE RID: 16094
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003EDF RID: 16095
		private LuaFunction m_ctor_hotfix;
	}
}
