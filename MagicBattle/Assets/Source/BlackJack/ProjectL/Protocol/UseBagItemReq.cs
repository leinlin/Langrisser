using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005CE RID: 1486
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "UseBagItemReq")]
	[Serializable]
	public class UseBagItemReq : IExtensible
	{
		// Token: 0x0600538D RID: 21389 RVA: 0x0018B238 File Offset: 0x00189438
		public UseBagItemReq()
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

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x0600538E RID: 21390 RVA: 0x0018B2A0 File Offset: 0x001894A0
		// (set) Token: 0x0600538F RID: 21391 RVA: 0x0018B2A8 File Offset: 0x001894A8
		[ProtoMember(1, IsRequired = true, Name = "ItemType", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06005390 RID: 21392 RVA: 0x0018B2B4 File Offset: 0x001894B4
		// (set) Token: 0x06005391 RID: 21393 RVA: 0x0018B2BC File Offset: 0x001894BC
		[ProtoMember(2, IsRequired = true, Name = "ItemId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06005392 RID: 21394 RVA: 0x0018B2C8 File Offset: 0x001894C8
		// (set) Token: 0x06005393 RID: 21395 RVA: 0x0018B2D0 File Offset: 0x001894D0
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

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06005394 RID: 21396 RVA: 0x0018B2DC File Offset: 0x001894DC
		// (set) Token: 0x06005395 RID: 21397 RVA: 0x0018B2E4 File Offset: 0x001894E4
		[ProtoMember(4, IsRequired = true, Name = "SelectedIndex", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005396 RID: 21398 RVA: 0x0018B2F0 File Offset: 0x001894F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x0018B300 File Offset: 0x00189500
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

		// Token: 0x06005398 RID: 21400 RVA: 0x0018B3CC File Offset: 0x001895CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UseBagItemReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003EC7 RID: 16071
		private int _ItemType;

		// Token: 0x04003EC8 RID: 16072
		private int _ItemId;

		// Token: 0x04003EC9 RID: 16073
		private int _Nums;

		// Token: 0x04003ECA RID: 16074
		private int _SelectedIndex;

		// Token: 0x04003ECB RID: 16075
		private IExtension extensionObject;

		// Token: 0x04003ECC RID: 16076
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003ECD RID: 16077
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003ECE RID: 16078
		private LuaFunction m_ctor_hotfix;
	}
}
