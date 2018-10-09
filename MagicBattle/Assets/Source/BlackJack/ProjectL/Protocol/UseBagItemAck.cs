using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005CF RID: 1487
	[ProtoContract(Name = "UseBagItemAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class UseBagItemAck : IExtensible
	{
		// Token: 0x06005399 RID: 21401 RVA: 0x0018B434 File Offset: 0x00189634
		public UseBagItemAck()
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

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x0600539A RID: 21402 RVA: 0x0018B49C File Offset: 0x0018969C
		// (set) Token: 0x0600539B RID: 21403 RVA: 0x0018B4A4 File Offset: 0x001896A4
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

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x0600539C RID: 21404 RVA: 0x0018B4B0 File Offset: 0x001896B0
		// (set) Token: 0x0600539D RID: 21405 RVA: 0x0018B4B8 File Offset: 0x001896B8
		[ProtoMember(2, IsRequired = true, Name = "ItemType", DataFormat = DataFormat.TwosComplement)]
		public int ItemType
		{
			get
			{
				return this._ItemType;
			}
			set
			{
				this._ItemType = value;
			}
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x0600539E RID: 21406 RVA: 0x0018B4C4 File Offset: 0x001896C4
		// (set) Token: 0x0600539F RID: 21407 RVA: 0x0018B4CC File Offset: 0x001896CC
		[ProtoMember(3, IsRequired = true, Name = "ItemId", DataFormat = DataFormat.TwosComplement)]
		public int ItemId
		{
			get
			{
				return this._ItemId;
			}
			set
			{
				this._ItemId = value;
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x060053A0 RID: 21408 RVA: 0x0018B4D8 File Offset: 0x001896D8
		// (set) Token: 0x060053A1 RID: 21409 RVA: 0x0018B4E0 File Offset: 0x001896E0
		[ProtoMember(4, IsRequired = true, Name = "Nums", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x060053A2 RID: 21410 RVA: 0x0018B4EC File Offset: 0x001896EC
		// (set) Token: 0x060053A3 RID: 21411 RVA: 0x0018B4F4 File Offset: 0x001896F4
		[ProtoMember(5, IsRequired = true, Name = "SelectedIndex", DataFormat = DataFormat.TwosComplement)]
		public int SelectedIndex
		{
			get
			{
				return this._SelectedIndex;
			}
			set
			{
				this._SelectedIndex = value;
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x060053A4 RID: 21412 RVA: 0x0018B500 File Offset: 0x00189700
		// (set) Token: 0x060053A5 RID: 21413 RVA: 0x0018B508 File Offset: 0x00189708
		[ProtoMember(6, IsRequired = true, Name = "ReqNums", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x060053A6 RID: 21414 RVA: 0x0018B514 File Offset: 0x00189714
		// (set) Token: 0x060053A7 RID: 21415 RVA: 0x0018B51C File Offset: 0x0018971C
		[DefaultValue(null)]
		[ProtoMember(7, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x060053A8 RID: 21416 RVA: 0x0018B528 File Offset: 0x00189728
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060053A9 RID: 21417 RVA: 0x0018B538 File Offset: 0x00189738
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

		// Token: 0x060053AA RID: 21418 RVA: 0x0018B604 File Offset: 0x00189804
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UseBagItemAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003ECF RID: 16079
		private int _Result;

		// Token: 0x04003ED0 RID: 16080
		private int _ItemType;

		// Token: 0x04003ED1 RID: 16081
		private int _ItemId;

		// Token: 0x04003ED2 RID: 16082
		private int _Nums;

		// Token: 0x04003ED3 RID: 16083
		private int _SelectedIndex;

		// Token: 0x04003ED4 RID: 16084
		private int _ReqNums;

		// Token: 0x04003ED5 RID: 16085
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04003ED6 RID: 16086
		private IExtension extensionObject;

		// Token: 0x04003ED7 RID: 16087
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003ED8 RID: 16088
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003ED9 RID: 16089
		private LuaFunction m_ctor_hotfix;
	}
}
