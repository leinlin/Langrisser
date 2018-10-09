using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005D1 RID: 1489
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "SellBagItemAck")]
	[Serializable]
	public class SellBagItemAck : IExtensible
	{
		// Token: 0x060053B3 RID: 21427 RVA: 0x0018B840 File Offset: 0x00189A40
		public SellBagItemAck()
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

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x060053B4 RID: 21428 RVA: 0x0018B8A8 File Offset: 0x00189AA8
		// (set) Token: 0x060053B5 RID: 21429 RVA: 0x0018B8B0 File Offset: 0x00189AB0
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x060053B6 RID: 21430 RVA: 0x0018B8BC File Offset: 0x00189ABC
		// (set) Token: 0x060053B7 RID: 21431 RVA: 0x0018B8C4 File Offset: 0x00189AC4
		[ProtoMember(2, IsRequired = true, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x060053B8 RID: 21432 RVA: 0x0018B8D0 File Offset: 0x00189AD0
		// (set) Token: 0x060053B9 RID: 21433 RVA: 0x0018B8D8 File Offset: 0x00189AD8
		[ProtoMember(3, IsRequired = true, Name = "Nums", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x060053BA RID: 21434 RVA: 0x0018B8E4 File Offset: 0x00189AE4
		// (set) Token: 0x060053BB RID: 21435 RVA: 0x0018B8EC File Offset: 0x00189AEC
		[ProtoMember(4, IsRequired = true, Name = "ReqNums", DataFormat = DataFormat.TwosComplement)]
		public int ReqNums
		{
			get
			{
				return this._ReqNums;
			}
			set
			{
				this._ReqNums = value;
			}
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x0018B8F8 File Offset: 0x00189AF8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x0018B908 File Offset: 0x00189B08
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

		// Token: 0x060053BE RID: 21438 RVA: 0x0018B9D4 File Offset: 0x00189BD4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SellBagItemAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003EE0 RID: 16096
		private int _Result;

		// Token: 0x04003EE1 RID: 16097
		private ulong _InstanceId;

		// Token: 0x04003EE2 RID: 16098
		private int _Nums;

		// Token: 0x04003EE3 RID: 16099
		private int _ReqNums;

		// Token: 0x04003EE4 RID: 16100
		private IExtension extensionObject;

		// Token: 0x04003EE5 RID: 16101
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003EE6 RID: 16102
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003EE7 RID: 16103
		private LuaFunction m_ctor_hotfix;
	}
}
